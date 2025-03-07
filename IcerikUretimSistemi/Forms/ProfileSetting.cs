using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using IcerikUretimSistemi.UI.Forms.Controls;
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
    public partial class ProfileSetting : Form
    {
        private readonly UserRepository _userRepo;
        private readonly UserService _userService;
        public ProfileSetting()
        {
            InitializeComponent();
            LoadImages();

            var context = new AppDBContext();
            _userRepo = new UserRepository(context);
            _userService = new UserService(_userRepo);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProfileSetting_Load(object sender, EventArgs e)
        {

        }

        private void LoadImages()
        {
            string imagesFolderPath = @"C:\Users\bes080124\Desktop\CMS6\Proje\IcerikUretimSistemi\ProfileImages\";  

            
            var imageFiles = Directory.GetFiles(imagesFolderPath, "*.jpg")
                                      .Concat(Directory.GetFiles(imagesFolderPath, "*.jpeg"))
                                      .Concat(Directory.GetFiles(imagesFolderPath, "*.png"))
                                      .ToList();

            
            foreach (var imagePath in imageFiles)
            {
                PictureBox pictureBox = new PictureBox
                {
                    ImageLocation = imagePath,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand
                };

                
                pictureBox.Click += (sender, e) => OnImageSelected(imagePath);

                
                flowLayoutPanelImages.Controls.Add(pictureBox);
            }
        }

        private void OnImageSelected(string imagePath)
        {
            
            var currentUser = CurrentUser.GetUser();
            if (currentUser != null)
            {
                currentUser.ImagePath = imagePath;
                var userRepository = new UserRepository(new AppDBContext());
                userRepository.Update(currentUser);

                MessageBox.Show("Profil resmi başarıyla güncellendi.");
            }
        }

        private void btnSaveProfileImage_Click(object sender, EventArgs e)
        {
            
            var currentUser = CurrentUser.GetUser();
            string selectedImagePath = currentUser.ImagePath;

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                
                MessageBox.Show($"Profil resminiz {selectedImagePath} olarak kaydedildi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir resim seçin.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                var userName = CurrentUser.LoggedInUser;


                userName.UserName = txtUserName.Text;
                userName.Email = txtEmail.Text;
                userName.Password = txtPassword.Text;


                _userService.Update(userName);
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            txtUserName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUpForm signUpForm = new();
            signUpForm.Show();
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            ProfileForm profForm = new(CurrentUser.LoggedInUser.ID);
            profForm.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var userId = CurrentUser.LoggedInUser.ID;         

               
                    var userToDelete = _userRepo.GetByID(userId);

                    _userRepo.RemoveFollowRelations(userId);
                    _userRepo.RemoveComments(userId);
                    _userRepo.RemoveLikes(userId);


                    if (userToDelete == null)
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.");
                        return;
                    }

                    _userRepo.Delete(userId);

                    this.Close();
                    SignUpForm giris = new();
                    giris.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Silme işlemi sırasında hata oluştu: {ex.Message}");
                }
            }
        
        }
    }
}
