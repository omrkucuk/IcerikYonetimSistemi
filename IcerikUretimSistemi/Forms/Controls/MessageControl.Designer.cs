namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class MessageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pctPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pctPhoto
            // 
            pctPhoto.ErrorImage = Properties.Resources.user;
            pctPhoto.Image = (Image)resources.GetObject("pctPhoto.Image");
            pctPhoto.ImageRotate = 0F;
            pctPhoto.Location = new Point(20, 2);
            pctPhoto.Name = "pctPhoto";
            pctPhoto.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pctPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pctPhoto.Size = new Size(60, 60);
            pctPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPhoto.TabIndex = 1;
            pctPhoto.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Location = new Point(451, 23);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(97, 17);
            lblDate.TabIndex = 2;
            lblDate.Text = "guna2HtmlLabel1";
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoSize = true;
            guna2Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            guna2Panel1.BackColor = Color.FromArgb(192, 192, 255);
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(txtMessage);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Location = new Point(113, 12);
            guna2Panel1.MaximumSize = new Size(300, 500);
            guna2Panel1.MinimumSize = new Size(300, 45);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(300, 45);
            guna2Panel1.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.CustomizableEdges = customizableEdges2;
            txtMessage.DefaultText = "";
            txtMessage.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMessage.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMessage.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Font = new Font("Segoe UI", 9F);
            txtMessage.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Location = new Point(5, 3);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "";
            txtMessage.ReadOnly = true;
            txtMessage.SelectedText = "";
            txtMessage.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtMessage.Size = new Size(290, 38);
            txtMessage.TabIndex = 0;
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // MessageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Controls.Add(lblDate);
            Controls.Add(pctPhoto);
            Name = "MessageControl";
            Size = new Size(551, 66);
            Load += MessageControl_Load;
            ((System.ComponentModel.ISupportInitialize)pctPhoto).EndInit();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctPhoto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
    }
}
