using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms
{
    public partial class PostCreate : Form
    {
        private readonly PostService _postService;
        private readonly PostRepository _postRepository;

        public PostCreate()
        {
            InitializeComponent();

            var context = new AppDBContext();

            _postRepository = new PostRepository(context);
            _postService = new PostService(_postRepository);
        }



        private void PostCreate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var currentUser = CurrentUser.LoggedInUser;

                if (currentUser == null)
                {
                    MessageBox.Show("Lütfen önce giriş yapın.");
                    return;
                }

                Posts newPost = new Posts()
                {
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    UserID = currentUser.ID
                };

                _postService.Create(newPost);
                MessageBox.Show("Gönderi Başarıyla Kaydedilmiştir");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            txtTitle.Text = "";
            txtContent.Text = "";
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
