using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Business.Services;
using IcerikUretimSistemi.DataAccess.Context;

namespace IcerikUretimSistemi.UI.Forms.Controls
{
    public partial class MessageControl : UserControl
    {
        private readonly MessageRepository _messageRepo;
        private readonly MessageService _messageService;
        private Guid _currentID;
        private Guid _messageID;

        public MessageControl(Guid currentID, Guid messageID, string ImagePath, string Message, DateTime SendTime)
        {
            InitializeComponent();

            var context = new AppDBContext();
            _messageRepo = new MessageRepository(context);
            _messageService = new MessageService(_messageRepo);
            _currentID = currentID;
            _messageID = messageID;

            pctPhoto.ImageLocation = ImagePath;
            txtMessage.Text = Message;
            lblDate.Text = SendTime.ToString("dd.MM.yyyy HH:mm");
        }

        private void MessageControl_Load(object sender, EventArgs e)
        {

        }
    }
}
