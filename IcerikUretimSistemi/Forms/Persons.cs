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
    public partial class Persons : Form
    {
        private readonly UserService _userService;
        private readonly UserRepository _userRepository;
        public Persons()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _userRepository = new UserRepository(context);
            _userService = new UserService(_userRepository);
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            // Veritabanından kullanıcıları çekin. Bu örnekte, kullanıcıları manuel bir listeyle ekliyoruz.
            var users = _userService.GetAll();

            foreach (var user in users)
            {
                Button userButton = new Button();
                userButton.Text = user.UserName; // Kullanıcı adı
                userButton.Click += (sender, e) => OpenProfile(user); // Tıklanınca profilini aç
                userButton.Dock = DockStyle.Top;
                flowLayoutPanelUsers.Controls.Add(userButton); // Listede göstermek için FlowLayoutPanel'e ekliyoruz
            }
        }

        // Kullanıcı ismine tıklandığında profilini açacak metod
        private void OpenProfile(User user)
        {
            ProfileForm profileForm = new ProfileForm(user.ID);
            profileForm.ShowDialog();
        }
    }
}
