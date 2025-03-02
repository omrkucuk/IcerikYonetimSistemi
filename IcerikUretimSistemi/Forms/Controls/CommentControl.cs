using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.Entites.Models;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class CommentControl : UserControl
    {
        private readonly CommentsRepository _commentRepo;
        private readonly CommentService _commentService;
        private Guid _currentID;
        private Guid _postID;
        public CommentControl(Guid currentID, Guid postID, string ImagePath, string userName, string commentText, DateTime createdDate)
        {
            InitializeComponent();

            pctCommentUser.ImageLocation = ImagePath;
            lblCommentDate.Text = createdDate.ToString("dd.MM.yyyy HH:mm");
            lblCommentText.Text = commentText;
            lblCommentUserName.Text = userName;

            var context = new AppDBContext();
            _commentRepo = new CommentsRepository(context);
            _commentService = new CommentService(_commentRepo);

            _currentID = currentID;
            _postID = postID;
        }

        private void CommentControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCommnet_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
