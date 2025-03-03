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

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class PersonsControl : UserControl
    {
        private readonly UserRepository _userRepository;
        private Guid _userID;
        public PersonsControl(string ImagePath, string userName, Guid userID, string followers)
        {
            InitializeComponent();

            profilePhoto.ImageLocation = ImagePath;
            lbluserName.Text = userName;
            lblFollowers.Text = followers;


            var context = new AppDBContext();
            _userRepository = new UserRepository(context);

            _userID = userID;
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void lbluserName_Click(object sender, EventArgs e)
        {
            ProfileForm proForm = new ProfileForm(_userID);
            proForm.Show();
        }

        private void profilePhoto_Click(object sender, EventArgs e)
        {
            ProfileForm proForm = new ProfileForm(_userID);
            proForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProfileForm proForm = new ProfileForm(_userID);
            proForm.Show();


            Persons personPage = Application.OpenForms.OfType<Persons>().FirstOrDefault();

            personPage.Close();

        }
    }
}
