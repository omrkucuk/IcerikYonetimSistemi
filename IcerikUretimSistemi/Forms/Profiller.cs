using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
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
    public partial class Profiller : Form
    {
        private readonly UserRepository _userRepo;
        public Profiller()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _userRepo = new UserRepository(context);
        }

        private void Profiller_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _userRepo.GetAll(); // Veritabanındaki tüm kullanıcıları al
            foreach (var user in users)
            {
                listBoxUsers.Items.Add(user.UserName); // Kullanıcı adı ile ListBox'a ekle
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)  // Seçilen öğe null değilse
            {
                string selectedUserName = listBoxUsers.SelectedItem.ToString();
                var user = _userRepo.GetAll().FirstOrDefault(x => x.UserName == selectedUserName);

                if (user != null)
                {
                    ProfileForm profileForm = new ProfileForm(user.ID);  // Seçilen kullanıcının ID'si ile formu aç
                    this.Close();  // Profil formu açılmadan önce mevcut formu kapat
                    profileForm.Show();  // Profil formunu modal olarak aç
                }
            }
        }
    }
}
