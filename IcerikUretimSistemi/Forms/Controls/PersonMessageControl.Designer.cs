namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class PersonMessageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonMessageControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            btnMessage = new Guna.UI2.WinForms.Guna2Button();
            guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            profilePhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilePhoto).BeginInit();
            SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 15;
            guna2ContainerControl1.Controls.Add(btnMessage);
            guna2ContainerControl1.Controls.Add(guna2PictureBox6);
            guna2ContainerControl1.Controls.Add(lblUserName);
            guna2ContainerControl1.Controls.Add(profilePhoto);
            guna2ContainerControl1.CustomizableEdges = customizableEdges6;
            guna2ContainerControl1.Location = new Point(3, 3);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ContainerControl1.Size = new Size(274, 104);
            guna2ContainerControl1.TabIndex = 0;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            guna2ContainerControl1.Click += guna2ContainerControl1_Click;
            // 
            // btnMessage
            // 
            btnMessage.Animated = true;
            btnMessage.AnimatedGIF = true;
            btnMessage.BorderRadius = 10;
            btnMessage.CustomizableEdges = customizableEdges1;
            btnMessage.DisabledState.BorderColor = Color.DarkGray;
            btnMessage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMessage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMessage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMessage.Font = new Font("Segoe UI", 9F);
            btnMessage.ForeColor = Color.White;
            btnMessage.Location = new Point(94, 39);
            btnMessage.Name = "btnMessage";
            btnMessage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMessage.Size = new Size(125, 41);
            btnMessage.TabIndex = 24;
            btnMessage.Text = "Mesaj At";
            btnMessage.Click += btnMessage_Click;
            // 
            // guna2PictureBox6
            // 
            guna2PictureBox6.BackColor = Color.Transparent;
            guna2PictureBox6.CustomizableEdges = customizableEdges3;
            guna2PictureBox6.Image = (Image)resources.GetObject("guna2PictureBox6.Image");
            guna2PictureBox6.ImageRotate = 0F;
            guna2PictureBox6.Location = new Point(225, 39);
            guna2PictureBox6.Name = "guna2PictureBox6";
            guna2PictureBox6.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox6.Size = new Size(35, 35);
            guna2PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox6.TabIndex = 23;
            guna2PictureBox6.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Location = new Point(102, 16);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 17);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "guna2HtmlLabel1";
            // 
            // profilePhoto
            // 
            profilePhoto.ErrorImage = (Image)resources.GetObject("profilePhoto.ErrorImage");
            profilePhoto.Image = (Image)resources.GetObject("profilePhoto.Image");
            profilePhoto.ImageRotate = 0F;
            profilePhoto.Location = new Point(13, 16);
            profilePhoto.Name = "profilePhoto";
            profilePhoto.ShadowDecoration.CustomizableEdges = customizableEdges5;
            profilePhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            profilePhoto.Size = new Size(64, 64);
            profilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePhoto.TabIndex = 0;
            profilePhoto.TabStop = false;
            // 
            // PersonMessageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ContainerControl1);
            Margin = new Padding(1);
            Name = "PersonMessageControl";
            Size = new Size(280, 110);
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilePhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePhoto;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private Guna.UI2.WinForms.Guna2Button btnMessage;
    }
}
