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
    public partial class PersonMessageControl : UserControl
    {
        private readonly UserRepository _userRepository;
        private Guid _userID;
        public PersonMessageControl(string ImagePath, string userName, Guid userID)
        {
            InitializeComponent();

            profilePhoto.ImageLocation = ImagePath;
            lblUserName.Text = userName;

            var context = new AppDBContext();
            _userRepository = new UserRepository(context);

            _userID = userID;
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
