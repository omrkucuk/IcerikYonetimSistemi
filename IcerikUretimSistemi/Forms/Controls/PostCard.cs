using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class PostCard : UserControl
    {
        public PostCard(string creatorName, string title, string content, DateTime createdAt, string ImagePath)
        {
            InitializeComponent();

            lblCreator.Text = creatorName;
            lblTitle.Text = title;
            lblContent.Text = content;
            pictureProfil.ImageLocation = ImagePath;
            lblDate.Text = createdAt.ToString("dd.MM.yyyy HH:mm");
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

        }

        private void PostCard_Load_1(object sender, EventArgs e)
        {

        }

        private void lblCreator_Click(object sender, EventArgs e)
        {

        }
    }
}
