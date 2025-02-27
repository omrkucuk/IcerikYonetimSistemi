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
    public partial class SignUpForm : Form
    {
        private readonly UserService _userService;
        private readonly UserRepository _userRepository;
        public SignUpForm()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _userRepository = new UserRepository(context);
            _userService = new UserService(_userRepository);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                User kullanici = new User()
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text
                };

                _userService.Create(kullanici);
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
