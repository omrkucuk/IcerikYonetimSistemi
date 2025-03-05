using FontAwesome.Sharp;
using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using IcerikUretimSistemi.UI.Forms.Controls;
using Microsoft.Extensions.Logging.Abstractions;
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

        public event EventHandler ContentRefreshRequested;
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

        PostCard postCard;
        private void HomePageForm_Load(object sender, EventArgs e)
        {
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
                postCard = new PostCard(user.UserName, post.Title, post.Content, post.CreatedDate, user.ImagePath, post.ID, currentUserID, post.UserID);
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

        }

        private void btnPersons_Click_1(object sender, EventArgs e)
        {
            Persons personsPage = new();
            personsPage.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click_2(object sender, EventArgs e)
        {
            var user = CurrentUser.GetUser();

            ProfileForm profileForm = new ProfileForm(user.ID);
            profileForm.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            SearchPosts(searchText);
        }

        private void SearchPosts(string searchText)
        {
            flowLayoutPanel1.Controls.Clear();

            var filteredPosts = _postService.GetAll()
                .Where(post => post.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            var currentUserID = CurrentUser.GetUser().ID;

            foreach (var post in filteredPosts)
            {
                var user = _userService.GetByID(post.UserID);
                PostCard postCard = new PostCard(user.UserName, post.Title, post.Content, post.CreatedDate, user.ImagePath, post.ID, currentUserID, post.UserID);
                postCard.UpdateLikeCount();
                postCard.UpdateLikeIcon();
                flowLayoutPanel1.Controls.Add(postCard);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MessageForm mesForm = new();
            mesForm.Show();
            this.Close();
        }

        public void RefreshContent()
        {
            flowLayoutPanel1.Controls.Clear();
            HomePageForm_Load(null, null); 
        }
        private void SomeMethodThatTriggersRefresh()
        {
            ContentRefreshRequested?.Invoke(this, EventArgs.Empty);
        }

        private void gunaPictureProfil_Click(object sender, EventArgs e)
        {
            var user = CurrentUser.GetUser();

            ProfileForm profileForm = new ProfileForm(user.ID);
            profileForm.Show();
            this.Close();
        }
    }
}
