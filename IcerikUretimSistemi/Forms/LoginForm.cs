using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
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
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly UserService _userService;
        public LoginForm()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _userRepository = new UserRepository(context);
            _userService = new UserService(_userRepository);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                var kullaniciadi = txtUserName.Text;
                var sifre = txtPassword.Text;

                var bulkullaniciadi = _userRepository.GetAll().Any(x => x.UserName == kullaniciadi);
                var bulkullanicisifre = _userRepository.GetAll().Any(x => x.Password == sifre);

                if (bulkullaniciadi && bulkullanicisifre)
                {
                    MessageBox.Show("Giriş Başarılı");

                    // Profil UserControl'ünü oluştur ve göster
                    ProfileControl profileControl = new ProfileControl();
                    profileControl.UserName = kullaniciadi; // Kullanıcı adını al
                    profileControl.UserEmail = "user@example.com"; // Burada kullanıcı e-postasını veritabanından alabilirsin
                    //profileControl.ProfileImage = Image.FromFile("path_to_image.jpg"); // Profil fotoğrafını da veritabanından alabilirsin

                    // Ana formda profili göster
                    this.Controls.Clear(); // Giriş formunu temizle
                    this.Controls.Add(profileControl); // Profil sayfasını ekle
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
