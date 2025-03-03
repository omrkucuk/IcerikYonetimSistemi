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
    public partial class AdminForm : Form
    {

        private readonly UserService _userService;
        private readonly CommentService _commentService;
        private readonly PostService _postService;
        public AdminForm()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _userService = new UserService(new UserRepository(context));
            _commentService = new CommentService(new CommentsRepository(context));
            _postService = new PostService(new PostRepository(context));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = new List<object>();
        }

        private void btnGetAllUsers_Click(object sender, EventArgs e)
        {
            var users = _userService.GetAll();
            dataGridView.DataSource = users;
        }

        private void btnGetAllComments_Click(object sender, EventArgs e)
        {
            var comments = _commentService.GetAll();
            dataGridView.DataSource = comments;
        }

        private void btnGetAllPosts_Click(object sender, EventArgs e)
        {
            var posts = _postService.GetAll();
            dataGridView.DataSource = posts;
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is IEnumerable<dynamic> dataSource)
            {
                var sortedData = dataSource.OrderByDescending(item => item.CreatedDate).ToList();
                dataGridView.DataSource = sortedData;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];

                // Gönderi silme
                if (dataGridView.DataSource is IEnumerable<Posts> posts)
                {
                    var postID = (Guid)selectedRow.Cells["ID"].Value;
                    _postService.Delete(postID);
                }

                // Yorum silme
                if (dataGridView.DataSource is IEnumerable<Comments> comments)
                {
                    var commentID = (Guid)selectedRow.Cells["ID"].Value;
                    _commentService.Delete(commentID);
                }

                // Kullanıcı silme
                if (dataGridView.DataSource is IEnumerable<User> users)
                {
                    var userID = (Guid)selectedRow.Cells["ID"].Value;
                    _userService.Delete(userID);
                }

                // Veriyi güncelle
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğeyi seçin.");
            }
        }

        private void RefreshDataGrid()
        {
            dataGridView.DataSource = new List<object>(); // Mevcut veriyi sıfırlıyoruz.
        }
    }
}
