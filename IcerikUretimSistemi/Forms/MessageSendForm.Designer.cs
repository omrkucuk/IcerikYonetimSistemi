namespace IcerikUretimSistemi.UI.Forms
{
    partial class MessageSendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageSendForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtMesajYazma = new Guna.UI2.WinForms.Guna2TextBox();
            guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtMesajYazma
            // 
            txtMesajYazma.AcceptsReturn = true;
            txtMesajYazma.BorderRadius = 15;
            txtMesajYazma.CustomizableEdges = customizableEdges1;
            txtMesajYazma.DefaultText = "";
            txtMesajYazma.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMesajYazma.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMesajYazma.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMesajYazma.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMesajYazma.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMesajYazma.Font = new Font("Segoe UI", 9F);
            txtMesajYazma.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMesajYazma.Location = new Point(53, 568);
            txtMesajYazma.Name = "txtMesajYazma";
            txtMesajYazma.PlaceholderText = "";
            txtMesajYazma.SelectedText = "";
            txtMesajYazma.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMesajYazma.Size = new Size(550, 50);
            txtMesajYazma.TabIndex = 0;
            // 
            // guna2PictureBox6
            // 
            guna2PictureBox6.BackColor = Color.Transparent;
            guna2PictureBox6.Cursor = Cursors.Hand;
            guna2PictureBox6.CustomizableEdges = customizableEdges3;
            guna2PictureBox6.Image = (Image)resources.GetObject("guna2PictureBox6.Image");
            guna2PictureBox6.ImageRotate = 0F;
            guna2PictureBox6.Location = new Point(613, 568);
            guna2PictureBox6.Name = "guna2PictureBox6";
            guna2PictureBox6.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox6.Size = new Size(50, 50);
            guna2PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox6.TabIndex = 24;
            guna2PictureBox6.TabStop = false;
            guna2PictureBox6.Click += guna2PictureBox6_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(53, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(592, 530);
            flowLayoutPanel1.TabIndex = 25;
            flowLayoutPanel1.WrapContents = false;
            // 
            // MessageSendForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(675, 651);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(guna2PictureBox6);
            Controls.Add(txtMesajYazma);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(780, 220);
            Name = "MessageSendForm";
            StartPosition = FormStartPosition.Manual;
            Text = "MessageSendForm";
            Load += MessageSendForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMesajYazma;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}