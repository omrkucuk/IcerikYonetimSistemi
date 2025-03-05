using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class PostCard : UserControl
    {
        private LikeService _likeService;
        private LikeRepository _likeRepo;
        private CommentService _commentService;
        private CommentsRepository _commentRepository;
        private readonly PostRepository _postRepository;
        private readonly PostService _postService;

        private Guid _postID;
        private Guid _currentUserID;
        private Guid _postOwnerID;
        public PostCard(string creatorName, string title, string content, DateTime createdAt, string ImagePath, Guid postID, Guid currentUserID, Guid postOwnerID)
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
            _commentRepository = new CommentsRepository(context);
            _commentService = new CommentService(_commentRepository);

            _postRepository = new PostRepository(context);
            _postService = new PostService(_postRepository);

            _postID = postID; // _postID'yi doğru şekilde ayarlıyoruz
            _currentUserID = currentUserID;
            _postOwnerID = postOwnerID;
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
            UpdateCommentCount();

            guna2PictureBox1.Visible = (_postOwnerID == _currentUserID);
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
            bool isLiked = _likeService.ToggleLike(_postID, _currentUserID);

            if (isLiked)
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png";
                iconLike.ErrorImage = errorImage;
            }
            else
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png";
                iconLike.ErrorImage = errorImage;
            }


            UpdateLikeCount();
        }


        public void UpdateLikeCount()
        {
            // Beğeni sayısını güncelleme işlemi
            var likeCount = _likeRepo.GetLikeCountByPostId(_postID); 
            lblLikeCount.Text = likeCount.ToString(); 
        }
        public void UpdateLikeIcon()
        {
            bool isLiked = _likeService.IsPostLikedByUser(_postID, _currentUserID); 

            
            if (isLiked)
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png";
                iconLike.ErrorImage = errorImage;
            }
            else
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png";
                iconLike.ErrorImage = errorImage;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateCommentCount()
        {
            var yorumSayisi = _commentService.GetAll().Count(c => c.PostID == _postID);
            lblCommentCount.Text = yorumSayisi.ToString();
        }


        private void iconComment_Click(object sender, EventArgs e)
        {
            CommentForm comForm = new CommentForm(_currentUserID, _postID);
            comForm.Show();
        }

        private void lblCommentCount_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _postService.Delete(_postID);

                    HomePageForm homePage = Application.OpenForms.OfType<HomePageForm>().FirstOrDefault();

                    if (homePage != null)
                    {
                        homePage.RefreshContent();
                    }
                    else
                    {
                        MessageBox.Show("HomePageForm bulunamadı!");
                    }

                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

    }
}
