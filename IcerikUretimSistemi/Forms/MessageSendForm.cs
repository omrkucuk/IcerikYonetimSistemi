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

        // Mesajları yüklemek için bir yardımcı fonksiyon
        private void LoadMessages()
        {
            try
            {
                // Mesajları alıyoruz
                var messages = _messageService.GetMessages(_currentID, _receiverID);

                // FlowLayoutPanel'i temizliyoruz
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

                    // FlowLayoutPanel'a yeni kontrol ekliyoruz
                    flowLayoutPanel1.Controls.Add(messageControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mesajları yüklerken hata oluştu: {ex.Message}");
            }
        }

        // Mesaj gönderme butonuna tıklanma olayı
        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan gelen mesajı alıyoruz
                string messageContent = txtMesajYazma.Text.Trim();

                // Eğer mesaj boş değilse
                if (!string.IsNullOrEmpty(messageContent))
                {
                    // Yeni mesaj nesnesi oluşturuyoruz
                    Entites.Models.Message mesaj = new()
                    {
                        SenderID = _currentID,
                        ReceiverID = _receiverID,
                        Content = messageContent,
                        SendAt = DateTime.Now,
                        IsRead = false
                    };

                    // Mesajı veritabanına kaydediyoruz
                    _messageService.Create(mesaj);
                    
                    // Mesajlar yeniden yükleniyor
                    LoadMessages();
                }
                else
                {
                    MessageBox.Show("Mesaj boş olamaz.");
                }

                // Mesaj kutusunu temizliyoruz
                txtMesajYazma.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mesaj gönderme hatası: {ex.Message}");
            }
        }

        // Geri butonuna tıklanma olayı
        private void iconBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
