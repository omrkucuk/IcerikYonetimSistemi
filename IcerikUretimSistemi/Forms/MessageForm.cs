using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using IcerikUretimSistemi.UI.Forms.Controls;
using Microsoft.EntityFrameworkCore;
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
    public partial class MessageForm : Form
    {
        private readonly UserService _userService;
        private readonly UserRepository _userRepository;
        private readonly FollowService _followService;
        private readonly FollowRepository _followRepository;
        private readonly MessageRepository _messageRepository;
        private readonly MessageService _messageService;

        private User _currentUser;
        private Guid _activeChatUserId; // Aktif mesajlaşılan kişi

        public MessageForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _userRepository = new UserRepository(context);
            _userService = new UserService(_userRepository);

            _followRepository = new FollowRepository(context);
            _followService = new FollowService(_followRepository);

            _messageRepository = new MessageRepository(context);
            _messageService = new MessageService(_messageRepository);

        }


        private void MessageForm_Load(object sender, EventArgs e)
        {
            _currentUser = CurrentUser.GetUser();

            if (_currentUser == null)
            {
                MessageBox.Show("Mevcut kullanıcı bulunamadı.");
                return;
            }

            // Takip edilen kullanıcıları çekiyoruz
            var followedUsers = _followRepository.GetFollowedUsers(_currentUser.ID);

            // Kullanıcıları ekrana ekleyelim
            foreach (var user in followedUsers)
            {
                if (user != null)
                {
                    PersonMessageControl personMessage = new PersonMessageControl(
                        user.ImagePath ?? "",
                        user.UserName ?? "Bilinmeyen Kullanıcı",
                        user.ID
                    );

                    flowLayoutPersons.Controls.Add(personMessage);
                }
            }

        }

  
        private void iconBack_Click(object sender, EventArgs e)
        {
            HomePageForm ev = new();
            ev.Show();
            this.Close();

            MessageSendForm homePage = Application.OpenForms.OfType<MessageSendForm>().FirstOrDefault();
            if (homePage != null)
            {
                homePage.Close();

            }
        }


    }
}
