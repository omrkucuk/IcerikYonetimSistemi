using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class ProfileForm : Form
    {
        private readonly UserRepository _userRepo;
        private readonly Guid _userId; // Ziyaret edilen profilin ID'si
        private readonly Guid _currentUserId; // Giriş yapan kullanıcının ID'si

        public ProfileForm(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
            _currentUserId = CurrentUser.LoggedInUser.ID; // Şu an giriş yapan kullanıcı

            var context = new AppDBContext();
            _userRepo = new UserRepository(context);
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserProfile(_userId);

            if (_currentUserId == _userId)
            {
                btnFollow.Visible = false;
            }
            else
            {
                btnFollow.Visible = true;
            }
        }

        private void LoadUserProfile(Guid userId)
        {
            var user = _userRepo.GetByID(userId);

            if (user != null)
            {
                lblUserName.Text = user.UserName;
                UpdateFollowCounts(user); // Takipçi sayısını hedef kullanıcıya göre güncelle

                bool isFollowing = _userRepo.IsFollowing(_currentUserId, user.ID);
                UpdateFollowButton(isFollowing);
                btnFollow.Tag = user;
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            var userToFollow = (Entites.Models.User)((Button)sender).Tag;

            if (userToFollow != null)
            {
                bool takipEdildi = ToggleFollowStatus(_currentUserId, userToFollow.ID);

                // Takipçi ve takip edilen sayısını hem hedef kullanıcı hem de giriş yapan kullanıcı için güncelle
                UpdateFollowCounts(userToFollow);
                UpdateFollowButton(takipEdildi);

                // Profil sayfasını yeniden yükle
                LoadUserProfile(_userId);
            }
        }

        private bool ToggleFollowStatus(Guid currentUserId, Guid targetUserId)
        {
            using (var context = new AppDBContext())
            {
                var currentUser = context.Users.Include(u => u.Following).Include(u => u.Followers).FirstOrDefault(u => u.ID == currentUserId);
                var targetUser = context.Users.Include(u => u.Following).Include(u => u.Followers).FirstOrDefault(u => u.ID == targetUserId);

                if (currentUser != null && targetUser != null)
                {
                    // Mevcut Follow kaydını kontrol et
                    var existingFollow = context.Follows
                        .FirstOrDefault(f => f.FollowerID == currentUserId && f.FollowingID == targetUserId);

                    if (existingFollow == null)
                    {
                        // Takip etme işlemi
                        var newFollow = new Follow { FollowerID = currentUserId, FollowingID = targetUserId };

                        // Takip edilen ve takip eden kişi listesine ekleyin
                        currentUser.Following.Add(newFollow);
                        targetUser.Followers.Add(newFollow);

                        // Veritabanına kaydetmeden önce Follow nesnelerini bağlamaya ekleyin.
                        context.Follows.Add(newFollow);
                        context.SaveChanges();

                        return true; // Takip edildi
                    }
                    else
                    {
                        // Takipten çıkma işlemi
                        context.Follows.Remove(existingFollow);

                        // Takipten çıkan ve çıkarılan kişinin listelerinden çıkarın.
                        currentUser.Following.Remove(existingFollow);
                        targetUser.Followers.Remove(existingFollow);

                        context.SaveChanges();
                        return false; // Takipten çıkıldı
                    }
                }
                return false;
            }
        }

        private void UpdateFollowButton(bool isFollowing)
        {
            btnFollow.Text = isFollowing ? "Takipten Çık" : "Takip Et";
            btnFollow.BackColor = isFollowing ? Color.Red : Color.Green;
        }

        private void UpdateFollowCounts(Entites.Models.User userToFollow)
        {
            using (var context = new AppDBContext())
            {
                var targetUser = context.Users.Include(u => u.Followers).Include(u => u.Following).FirstOrDefault(u => u.ID == userToFollow.ID);

                if (targetUser != null)
                {
                    var takipciSayisi = targetUser.Followers.Count;
                    var takipEdilenSayisi = targetUser.Following.Count;

                    lblFollowers.Text = takipciSayisi.ToString();
                    lblFollowing.Text = takipEdilenSayisi.ToString();
                }
            }
        }

        private void lblFollowers_Click(object sender, EventArgs e)
        {
            // Takipçi listesine yönlendirme veya başka bir işlem eklenebilir
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }
    }
}

