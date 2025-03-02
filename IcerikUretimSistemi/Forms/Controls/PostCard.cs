using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.Entites.Models;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class PostCard : UserControl
    {
        private LikeService _likeService;
        private LikeRepository _likeRepo;

        private Guid _postID;
        private Guid _currentUserID;
        public PostCard(string creatorName, string title, string content, DateTime createdAt, string ImagePath, Guid postID, Guid currentUserID)
        {
            InitializeComponent();

            lblCreator.Text = creatorName;
            lblTitle.Text = title;
            lblContent.Text = content;
            pictureProfil.ImageLocation = ImagePath;
            lblDate.Text = createdAt.ToString("dd.MM.yyyy HH:mm");

            var context = new AppDBContext();
            _likeRepo = new LikeRepository(context);
            _likeService = new LikeService(_likeRepo);

            _postID = postID; // _postID'yi doğru şekilde ayarlıyoruz
            _currentUserID = currentUserID;
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beğenildi!");
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yorum yapıldı!");
        }

        private void PostCard_Load(object sender, EventArgs e)
        {
            UpdateLikeCount();
            UpdateLikeIcon();
        }

        private void PostCard_Load_1(object sender, EventArgs e)
        {

        }

        private void lblCreator_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            ToggleLike();

        }

        private void ToggleLike()
        {
            // ToggleLike metoduyla beğeni durumunu değiştiriyoruz.
            bool isLiked = _likeService.ToggleLike(_postID, _currentUserID);

            // Duruma göre geri bildirim mesajı
            if (isLiked)
            {
                iconLike.ImageLocation = @"C:\Users\husey\OneDrive\Masaüstü\CMSV2\IcerikUretimSistemi\Icons\red-heart-icon.png";
            }
            else
            {
                iconLike.ImageLocation = @"C:\Users\husey\OneDrive\Masaüstü\CMSV2\IcerikUretimSistemi\Icons\heart-thin-icon.png";
            }

            // Beğeni sayısını güncelleyebiliriz, örneğin butonun yanındaki beğeni sayısını...
            UpdateLikeCount();
        }
        public void UpdateLikeCount()
        {
            // Beğeni sayısını güncelleme işlemi
            var likeCount = _likeRepo.GetLikeCountByPostId(_postID); // Burada veritabanından beğeni sayısını alıyoruz
            lblLikeCount.Text = likeCount.ToString(); // Sayıyı gösteren bir label'ınız olduğunu varsayalım
        }
        public void UpdateLikeIcon()
        {
            // Sayfa yüklendiğinde mevcut beğeni durumu kontrol edilir
            bool isLiked = _likeService.IsPostLikedByUser(_postID, _currentUserID); // Beğeni durumu kontrolü

            // Duruma göre ikon belirleniyor
            if (isLiked)
            {
                iconLike.ImageLocation = @"C:\Users\husey\OneDrive\Masaüstü\CMSV2\IcerikUretimSistemi\Icons\red-heart-icon.png";
            }
            else
            {
                iconLike.ImageLocation = @"C:\Users\husey\OneDrive\Masaüstü\CMSV2\IcerikUretimSistemi\Icons\heart-thin-icon.png";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
