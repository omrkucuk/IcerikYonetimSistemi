namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class PersonsControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonsControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            lblFollowers = new Label();
            label1 = new Label();
            lbluserName = new Label();
            profilePhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePhoto).BeginInit();
            SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 30;
            guna2ContainerControl1.Controls.Add(guna2Button1);
            guna2ContainerControl1.Controls.Add(lblFollowers);
            guna2ContainerControl1.Controls.Add(label1);
            guna2ContainerControl1.Controls.Add(lbluserName);
            guna2ContainerControl1.Controls.Add(profilePhoto);
            guna2ContainerControl1.CustomizableEdges = customizableEdges4;
            guna2ContainerControl1.Location = new Point(3, 3);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2ContainerControl1.Size = new Size(380, 180);
            guna2ContainerControl1.TabIndex = 0;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            guna2ContainerControl1.Click += guna2ContainerControl1_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.AnimatedGIF = true;
            guna2Button1.BorderRadius = 10;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(124, 180, 255);
            guna2Button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(127, 102);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(155, 38);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Profile Git";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // lblFollowers
            // 
            lblFollowers.AutoSize = true;
            lblFollowers.Cursor = Cursors.Hand;
            lblFollowers.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFollowers.Location = new Point(295, 60);
            lblFollowers.Name = "lblFollowers";
            lblFollowers.Size = new Size(48, 20);
            lblFollowers.TabIndex = 1;
            lblFollowers.Text = "label1";
            lblFollowers.Click += lbluserName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(225, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Takipçi :";
            label1.Click += lbluserName_Click;
            // 
            // lbluserName
            // 
            lbluserName.AutoSize = true;
            lbluserName.Cursor = Cursors.Hand;
            lbluserName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbluserName.Location = new Point(127, 60);
            lbluserName.Name = "lbluserName";
            lbluserName.Size = new Size(48, 20);
            lbluserName.TabIndex = 1;
            lbluserName.Text = "label1";
            lbluserName.Click += lbluserName_Click;
            // 
            // profilePhoto
            // 
            profilePhoto.Cursor = Cursors.Hand;
            profilePhoto.ErrorImage = Properties.Resources.user;
            profilePhoto.FillColor = Color.Transparent;
            profilePhoto.Image = (Image)resources.GetObject("profilePhoto.Image");
            profilePhoto.ImageRotate = 0F;
            profilePhoto.Location = new Point(30, 48);
            profilePhoto.Name = "profilePhoto";
            profilePhoto.ShadowDecoration.CustomizableEdges = customizableEdges3;
            profilePhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            profilePhoto.Size = new Size(64, 64);
            profilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePhoto.TabIndex = 0;
            profilePhoto.TabStop = false;
            profilePhoto.Click += profilePhoto_Click;
            // 
            // PersonsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ContainerControl1);
            Name = "PersonsControl";
            Size = new Size(390, 200);
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label lbluserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePhoto;
        private Label lblFollowers;
        private Label label1;
    }
}
