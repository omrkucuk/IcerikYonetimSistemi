using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms
{
    public partial class PostControl : UserControl
    {
        public string PostTitle
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string PostContent
        {
            get => lblContent.Text;
            set => lblContent.Text = value;
        }
        public PostControl()
        {
            InitializeComponent();
        }

        private void PostControl_Load(object sender, EventArgs e)
        {

        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            int likes = int.Parse(btnLike.Text);
            likes++;
            btnLike.Text = likes.ToString();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yorum ekleme ekranı açılacak!");
        }
    }
}
