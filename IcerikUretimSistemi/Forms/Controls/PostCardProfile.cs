using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class PostCardProfile : UserControl
    {
        private readonly LikeService _likeService;
        private readonly LikeRepository _likeRepo;

        private readonly CommentService _commentService;
        private readonly CommentsRepository _commentRepository;

        private readonly PostRepository _postRepository;
        private readonly PostService _postService;

        private Guid _postID;
        private Guid _currentUserID;
        private Guid _postOwnerID;
        public PostCardProfile(string title, string content, DateTime createdAt, Guid postID, Guid currentUserID, Guid postOwnerID)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblContent.Text = content;
            lblDate.Text = createdAt.ToString("dd.MM.yyyy HH:mm");


            var context = new AppDBContext();
            _likeRepo = new LikeRepository(context);
            _likeService = new LikeService(_likeRepo);

            _commentRepository = new CommentsRepository(context);
            _commentService = new CommentService(_commentRepository);

            _postRepository = new PostRepository(context);
            _postService = new PostService(_postRepository);

            _postID = postID;
            _currentUserID = currentUserID;
            _postOwnerID = postOwnerID;
        }

        private void iconComment_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateLikeIcon()
        {
            bool isLiked = _likeService.IsPostLikedByUser(_postID, _currentUserID); 

            
            if (isLiked)
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png";
                iconLike.Image = errorImage;
            }
            else
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png";
                iconLike.Image = errorImage;
            }
        }

        public void UpdateLikeCount()
        {
            
            var likeCount = _likeRepo.GetLikeCountByPostId(_postID); 
            lblLikeCount.Text = likeCount.ToString(); 
        }

        private void ToggleLike()
        {

            bool isLiked = _likeService.ToggleLike(_postID, _currentUserID);

            // Duruma göre geri bildirim mesajı
            if (isLiked)
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\red-heart-icon.png";
                iconLike.Image = errorImage;
            }
            else
            {
                Image errorImage = Image.FromFile(@"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png");
                iconLike.ImageLocation = @"C:\Users\bes080124\Desktop\Proje\IcerikUretimSistemi\Icons\heart-thin-icon.png";
                iconLike.Image = errorImage;
            }

            
            UpdateLikeCount(); 
        }

        private void PostCardProfile_Load(object sender, EventArgs e)
        {
            UpdateLikeCount();
            UpdateLikeIcon();
            UpdateCommentCount();

            guna2PictureBox1.Visible = (_postOwnerID == _currentUserID);
        }

        private void iconLike_Click(object sender, EventArgs e)
        {
            ToggleLike();
        }

        public void UpdateCommentCount()
        {
            var yorumSayisi = _commentService.GetAll().Count(c => c.PostID == _postID);
            lblCommentCount.Text = yorumSayisi.ToString();
        }

        private void guna2ContainerControl2_Click(object sender, EventArgs e)
        {

        }

        private void iconComment_Click_1(object sender, EventArgs e)
        {
            CommentForm comForm = new CommentForm(_currentUserID, _postID);
            comForm.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _postService.Delete(_postID);

                    ProfileForm homePage = Application.OpenForms.OfType<ProfileForm>().FirstOrDefault();

                    if (homePage != null)
                    {
                        homePage.RefreshContent();
                    }
                    else
                    {
                        MessageBox.Show("ProfileForm bulunamadı!");
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
