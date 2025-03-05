using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;

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
                var existingUser = _userRepository.GetAll().FirstOrDefault(x => x.UserName == txtKayitUserName.Text || x.Email == txtEmail.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Kullanıcı adı veya e-posta adresi zaten alınmış.");
                    return;
                }

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

                if (eMail == "admin" && sifre == "admin")
                {
                    Admin adminForm = new();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    var user = _userRepository.GetAll().FirstOrDefault(x => x.Email == eMail && x.Password == sifre);

                    if (user != null)
                    {
                        MessageBox.Show("Giriş Başarılı");

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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            var acikSifre = txtGirisSifre.UseSystemPasswordChar;

            if (acikSifre == false)
            {
                txtGirisSifre.UseSystemPasswordChar = true;
            }
            else
            {

                txtGirisSifre.UseSystemPasswordChar = false;
            }
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

            txtKayitSifre.UseSystemPasswordChar = !txtKayitSifre.UseSystemPasswordChar;
        }
    }
}
