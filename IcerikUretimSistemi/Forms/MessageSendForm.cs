using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.UI.Forms.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IcerikUretimSistemi.UI.Forms
{
    public partial class MessageSendForm : Form
    {
        private readonly MessageService _messageService;
        private readonly UserService _userService;

        private readonly Guid _currentID;
        private readonly Guid _receiverID;

        public MessageSendForm(Guid currentID, Guid receiverID)
        {
            InitializeComponent();

            var context = new AppDBContext();
            var messageRepository = new MessageRepository(context);
            _messageService = new MessageService(messageRepository);

            var userRepository = new UserRepository(context);
            _userService = new UserService(userRepository);

            _currentID = currentID;
            _receiverID = receiverID;
        }

        private void MessageSendForm_Load(object sender, EventArgs e)
        {
            LoadMessages();
        }

        private void LoadMessages()
        {
            try
            {
                // Gönderen veya alıcı kimliği ile mesajları alıyoruz
                var messages = _messageService.GetMessagesBySenderOrReceiver(_currentID, _receiverID);

                
                flowLayoutPanel1.Controls.Clear();

                // Her bir mesaj için MessageControl ekliyoruz
                foreach (var message in messages)
                {
                    var sender = _userService.GetByID(message.SenderID);

                    var messageControl = new MessageControl(
                        _currentID,
                        _receiverID,
                        sender.ImagePath,
                        message.Content,
                        message.SendAt
                    );

                    
                    flowLayoutPanel1.Controls.Add(messageControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mesajları yüklerken hata oluştu: {ex.Message}");
            }
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
               
                string messageContent = txtMesajYazma.Text.Trim();

               
                if (!string.IsNullOrEmpty(messageContent))
                {
                    
                    Entites.Models.Message mesaj = new()
                    {
                        SenderID = _currentID,
                        ReceiverID = _receiverID,
                        Content = messageContent,
                        SendAt = DateTime.Now,
                        IsRead = false
                    };

                    
                    _messageService.Create(mesaj);
                    
                    
                    LoadMessages();
                }
                else
                {
                    MessageBox.Show("Mesaj boş olamaz.");
                }

                
                txtMesajYazma.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mesaj gönderme hatası: {ex.Message}");
            }

            txtMesajYazma.Text = "";
        }

       
        private void iconBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
