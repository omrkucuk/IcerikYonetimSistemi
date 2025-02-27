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

namespace IcerikUretimSistemi.UI.Forms
{
    public partial class ProfileControl : UserControl
    {
        private readonly UserRepository _userRepo;

        public ProfileControl()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _userRepo = new UserRepository(context);
        }

        public string UserName
        {
            get { return lblUserName.Text; }
            set { lblUserName.Text = value; }
        }

        public string UserEmail
        {
            get { return lblUserEmail.Text; }
            set { lblUserEmail.Text = value; }
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
