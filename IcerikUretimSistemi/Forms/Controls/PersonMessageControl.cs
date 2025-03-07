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
using IcerikUretimSistemi.Entites.Models;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class PersonMessageControl : UserControl
    {
        private readonly UserRepository _userRepository;
        private Guid _userID;
        private Guid _currentID;
        private string _userName;
        public PersonMessageControl(string ImagePath, string userName, Guid userID)
        {
            InitializeComponent();

            profilePhoto.ImageLocation = ImagePath;
            lblUserName.Text = userName;

            var context = new AppDBContext();
            _userRepository = new UserRepository(context);

            _userID = userID;
            _userName = userName;
            _currentID = CurrentUser.LoggedInUser.ID;
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageSendForm gonder2 = Application.OpenForms.OfType<MessageSendForm>().FirstOrDefault();
            if (gonder2 != null)
            {
                gonder2.Close();
            }

            MessageSendForm gonder = new MessageSendForm(_currentID, _userID);
            gonder.Show();


        }
    }
}
