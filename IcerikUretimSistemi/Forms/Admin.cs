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
    public partial class Admin : Form
    {
        private readonly UserRepository _userRepository;
        private readonly UserService _userService;
        private readonly PostRepository _postRepository;
        private readonly PostService _postService;
        private readonly CommentsRepository _commentsRepository;
        private readonly CommentService _commentService;
        public Admin()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _userRepository = new UserRepository(context);
            _userService = new UserService(_userRepository);
            _postRepository = new PostRepository(context);
            _postService = new PostService(_postRepository);
            _commentsRepository = new CommentsRepository(context);
            _commentService = new CommentService(_commentsRepository);
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            var kullanicilar = _userRepository.GetAllWithPosts().SelectMany(u => u.Posts.Any() ? u.Posts.Select(p => new
            {
                CreatedDate = (DateTime?)p.CreatedDate,
                KullaniciID = u.ID,
                u.UserName,
                PostID = p.ID,
                PostTitle = p.Title,
                YorumSayisi = p.Comments?.Count() ?? 0,
                KarakterUzunlugu = p.Content?.Length ?? 0
            })
        : new[] { new { CreatedDate = (DateTime?)null, KullaniciID = u.ID, u.UserName, PostID = Guid.Empty, PostTitle = "Postu yok", YorumSayisi = 0, KarakterUzunlugu = 0 } })
    .ToList();

            dataGrid.DataSource = kullanicilar;


        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGrid.Rows[e.RowIndex];


                if (selectedRow.Cells["PostID"].Value != null)
                {
                    Guid postID = Guid.Parse(selectedRow.Cells["PostID"].Value.ToString());


                    var yorumlar = _commentsRepository.GetAll()
                        .Where(c => c.PostID == postID)
                        .Select(c => new
                        {
                            c.CreatedDate,
                            c.ID,
                            c.Text,
                            c.User.UserName,
                            c.PostID
                        })
                        .ToList();


                    dataGridComment.DataSource = yorumlar;
                }
            }
        }

        private void dataGridComment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.ToLower();

            var filteredUsers = _userRepository.GetAllWithPosts()
                .SelectMany(u => u.Posts.Any()
                    ? u.Posts.Select(p => new
                    {
                        p.CreatedDate,
                        u.ID,
                        u.UserName,
                        PostID = p.ID,
                        PostTitle = p.Title,
                        YorumSayisi = p.Comments?.Count() ?? 0,
                        KarakterUzunlugu = p.Content?.Length ?? 0
                    })
                    : new[] { new { u.CreatedDate, u.ID, u.UserName, PostID = Guid.Empty, PostTitle = "Postu yok", YorumSayisi = 0, KarakterUzunlugu = 0 } })
                .Where(u => u.UserName.ToLower().Contains(searchText))
                .ToList();

            dataGrid.DataSource = filteredUsers;
        }

        private void Search()
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTime.Value.Date;

            var filteredUsersByDate = _userRepository.GetAllWithPosts()
                .SelectMany(u => u.Posts
                    .Where(p => p.CreatedDate.Date == selectedDate)
                    .Select(p => new
                    {
                        p.CreatedDate,
                        u.ID,
                        u.UserName,
                        PostID = p.ID,
                        PostTitle = p.Title,
                        YorumSayisi = p.Comments?.Count() ?? 0,
                        KarakterUzunlugu = p.Content?.Length ?? 0
                    }))
                .ToList();

            dataGrid.DataSource = filteredUsersByDate;
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new();
            signUp.Show();
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
        }
    }


}

