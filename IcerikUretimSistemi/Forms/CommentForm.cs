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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms
{
    public partial class CommentForm : Form
    {
        private readonly CommentsRepository _commentRepo;
        private readonly CommentService _commentService;

        private readonly UserRepository _userRepo;
        private readonly UserService _userService;


        private Guid _currentID;
        private Guid _postID;
        public CommentForm(Guid currentID, Guid postID)
        {
            InitializeComponent();

            var context = new AppDBContext();
            _commentRepo = new CommentsRepository(context);
            _commentService = new CommentService(_commentRepo);

            _userRepo = new UserRepository(context);
            _userService = new UserService(_userRepo);

            _currentID = currentID;
            _postID = postID;
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                Comments newCommnet = new Comments()
                {
                    Text = txtComment.Text,
                    UserID = _currentID,
                    PostID = _postID
                };

                _commentService.Create(newCommnet);
                GetAllComment();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            txtComment.Text = "";
        }
        CommentControl comControl;
        private void CommentForm_Load(object sender, EventArgs e)
        {
            GetAllComment();


        }

        public void GetAllComment()
        {

            var commentList = _commentService.GetAll().Where(c => c.PostID == _postID);

            foreach (var item in commentList)
            {
                var user = _userService.GetByID(item.UserID);
                comControl = new CommentControl(_currentID, _postID, user.ImagePath, user.UserName, item.Text, item.CreatedDate);
                flowLayoutPanel1.Controls.Add(comControl);
            }

        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
