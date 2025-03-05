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
using System.Windows.Controls;
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
            
            var users = _userService.GetAll();
            var follow = _followRepository.GetAll();

            var userId = CurrentUser.LoggedInUser.ID;

            var persons = _userService.GetByID(userId);

            SearchPosts();
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            SearchPosts(searchText);
        }

        private void SearchPosts(string searchText ="")
        {
            flowLayoutPanelUsers.Controls.Clear();

            var filteredPosts = _userService.GetAll()
                .Where(person => person.UserName.Contains(searchText, StringComparison.OrdinalIgnoreCase) && person.ID != CurrentUser.LoggedInUser.ID)
                .ToList();

            var currentUserID = CurrentUser.GetUser().ID;

            foreach (var item in filteredPosts)
            {
                var user = _userService.GetByID(item.ID);
                PersonsControl PersonCard = new PersonsControl(user.ImagePath, user.UserName, user.ID, user.Followers.ToList().Count().ToString());
                flowLayoutPanelUsers.Controls.Add(PersonCard);
            }
        }
    }
}
