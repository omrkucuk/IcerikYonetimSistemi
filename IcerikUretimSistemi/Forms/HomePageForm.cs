using FontAwesome.Sharp;
using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using IcerikUretimSistemi.UI.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms
{
    public partial class HomePageForm : Form
    {
        private readonly PostService _postService;
        private readonly PostRepository _postRepository;

        private readonly UserService _userService;
        private readonly UserRepository _userRepository;

        public HomePageForm()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _postRepository = new PostRepository(context);
            _postService = new PostService(_postRepository);

            _userRepository = new UserRepository(context);
            _userService = new UserService(_userRepository);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnMessage.FlatAppearance.BorderSize = 0;
            btnPersons.FlatAppearance.BorderSize = 0;
            btnPost.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new Region(gp);


            var currentUserID = CurrentUser.GetUser().ID;

            lblUserName.Text = CurrentUser.GetUser().UserName;

            if (System.IO.File.Exists(CurrentUser.GetUser().ImagePath))
            {
                gunaPictureProfil.ImageLocation = CurrentUser.GetUser().ImagePath;
            }
            else
            {
                gunaPictureProfil.ImageLocation = @"C:\Users\husey\OneDrive\Masaüstü\CMSV2\IcerikUretimSistemi\ProfileImages\user.png";
            }

            var postList = _postService.GetAll();
            foreach (var post in postList)
            {
                var user = _userService.GetByID(post.UserID);
                PostCard postCard = new PostCard(user.UserName, post.Title, post.Content, post.CreatedDate, user.ImagePath, post.ID, currentUserID);
                postCard.UpdateLikeCount();
                postCard.UpdateLikeIcon();
                flowLayoutPanel1.Controls.Add(postCard);
            }

            
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            PostCreate postCreateForm = new();
            postCreateForm.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            //var user = CurrentUser.GetUser();

            //ProfileForm profileForm = new ProfileForm(user.ID);
            //profileForm.ShowDialog();
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            Profiller pro = new Profiller();
            pro.ShowDialog();
        }

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            var user = CurrentUser.GetUser();

            ProfileForm profileForm = new ProfileForm(user.ID);
            profileForm.ShowDialog();
        }

        private void btnPersons_Click_1(object sender, EventArgs e)
        {
            Persons personsPage = new();
            personsPage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
