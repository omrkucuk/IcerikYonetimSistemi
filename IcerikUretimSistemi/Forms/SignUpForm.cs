using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using IcerikUretimSistemi.UI.Forms.Controls;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
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
                    UserName = txtKayitUserName.Text,
                    Password = txtKayitSifre.Text,
                    Email = txtEmail.Text
                };

                _userService.Create(kullanici);
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            txtKayitUserName.Text = "";
            txtEmail.Text = "";
            txtKayitSifre.Text = "";
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var eMail = txtGirisKullanıcıAdi.Text;
                var sifre = txtGirisSifre.Text;

                // Veritabanındaki kullanıcıyı kontrol et
                var user = _userRepository.GetAll().FirstOrDefault(x => x.Email == eMail && x.Password == sifre);

                if (user != null)
                {
                    MessageBox.Show("Giriş Başarılı");

                    // Aktif kullanıcıyı CurrentUser'a set et
                    CurrentUser.LogIn(user);

                    HomePageForm home = new HomePageForm();
                    home.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtGirisKullanıcıAdi.Text = "";
            txtGirisSifre.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
