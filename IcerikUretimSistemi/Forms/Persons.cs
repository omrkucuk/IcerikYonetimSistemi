using Guna.UI2.WinForms;
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
        private readonly FollowRepository _followRepository;
        public Persons()
        {
            InitializeComponent();

            var context = new AppDBContext();
            _userRepository = new UserRepository(context);
            _userService = new UserService(_userRepository);

            _followRepository = new FollowRepository(context);
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            // Veritabanından kullanıcıları çekin. Bu örnekte, kullanıcıları manuel bir listeyle ekliyoruz.
            var users = _userService.GetAll();
            var follow = _followRepository.GetAll();

            foreach (var user in users)
            {
                PersonsControl personControl = new PersonsControl(user.ImagePath, user.UserName, user.ID, user.Followers.ToList().Count().ToString());
                flowLayoutPanelUsers.Controls.Add(personControl);
            }
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            HomePageForm homePage = new HomePageForm();
            homePage.Show();
            this.Close();
        }

        private void flowLayoutPanelUsers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
