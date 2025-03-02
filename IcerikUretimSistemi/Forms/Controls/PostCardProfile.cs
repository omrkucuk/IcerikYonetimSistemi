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
using IcerikUretimSistemi.DataAccess.Context;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class PostCardProfile : UserControl
    {
        private LikeService _likeService;
        private LikeRepository _likeRepo;

        private Guid _postID;
        private Guid _currentUserID;
        public PostCardProfile(string title, string content, DateTime createdAt, Guid postID, Guid currentUserID)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblContent.Text = content;
            lblDate.Text = createdAt.ToString("dd.MM.yyyy HH:mm");


            var context = new AppDBContext();
            _likeRepo = new LikeRepository(context);
            _likeService = new LikeService(_likeRepo);

            _postID = postID; // _postID'yi doğru şekilde ayarlıyoruz
            _currentUserID = currentUserID;
        }

        private void iconComment_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

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

        public void UpdateLikeCount()
        {
            // Beğeni sayısını güncelleme işlemi
            var likeCount = _likeRepo.GetLikeCountByPostId(_postID); // Burada veritabanından beğeni sayısını alıyoruz
            lblLikeCount.Text = likeCount.ToString(); // Sayıyı gösteren bir label'ınız olduğunu varsayalım
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

        private void PostCardProfile_Load(object sender, EventArgs e)
        {
            UpdateLikeCount();
            UpdateLikeIcon();
        }

        private void iconLike_Click(object sender, EventArgs e)
        {
            ToggleLike();
        }
    }
}
