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
        public HomePageForm()
        {
            InitializeComponent();
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
            icnLike.FlatAppearance.BorderSize = 0;
            icnComment.FlatAppearance.BorderSize = 0;
            btnPost.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new Region(gp);

        }

        private void btnPost_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            var user = CurrentUser.GetUser();

            ProfileForm profileForm = new ProfileForm(user.ID);
            profileForm.ShowDialog();
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            Profiller pro = new Profiller();
            pro.ShowDialog();
        }
    }
}
