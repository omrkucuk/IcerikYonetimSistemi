using Guna.UI2.WinForms;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class ProfileForm : Form
    {
        private readonly UserRepository _userRepo;
        private readonly PostRepository _postRepo;
        private readonly Guid _userId; // Ziyaret edilen profilin ID'si
        private readonly Guid _currentUserId; // Giriş yapan kullanıcının ID'si

        public ProfileForm(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
            _currentUserId = CurrentUser.LoggedInUser.ID; // Şu an giriş yapan kullanıcı

            var context = new AppDBContext();
            _userRepo = new UserRepository(context);
            _postRepo = new PostRepository(context);
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserProfile(_userId);
            LoadUserPosts(_userId);

            if (_currentUserId == _userId)
            {
                btnFollow.Visible = false;
                iconSetting.Visible = true;
            }
            else
            {
                btnFollow.Visible = true;
                iconSetting.Visible = false;
            }

        }

        private void LoadUserPosts(Guid userId)
        {
            var posts = _postRepo.GetPostsByUserId(userId);

            flowLayoutPost.Controls.Clear();

            foreach (var post in posts)
            {
                PostCardProfile postCard = new PostCardProfile(post.Title, post.Content, post.CreatedDate, post.ID, _currentUserId);
                flowLayoutPost.Controls.Add(postCard);
            }
        }

        private void LoadUserProfile(Guid userId)
        {       
            var user = _userRepo.GetByID(userId);

            if (user != null)
            {
                lblUserName.Text = user.UserName;

                if (System.IO.File.Exists(user.ImagePath))
                {
                    pictureBoxProfile.ImageLocation = user.ImagePath;
                }
                else
                {
                    pictureBoxProfile.ImageLocation = @"C:\Users\husey\OneDrive\Masaüstü\CMSV2\IcerikUretimSistemi\ProfileImages\user.png";
                }

                UpdateFollowCounts(user); // Takipçi sayısını hedef kullanıcıya göre güncelle

                //pictureBoxProfile.Image

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
            var userToFollow = (Entites.Models.User)((Guna2Button)sender).Tag;

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
            btnFollow.FillColor = isFollowing ? Color.Red : Color.Green;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            ProfileSetting profSetting = new();
            profSetting.Show();
        }

        private void iconSetting_Click(object sender, EventArgs e)
        {
            ProfileSetting profSetting = new();
            profSetting.Show();
            this.Close();
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            HomePageForm home = new HomePageForm();
            home.Show();
            this.Close();
        }
    }
}

