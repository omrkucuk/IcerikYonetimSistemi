namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFollow = new Guna.UI2.WinForms.Guna2Button();
            iconSetting = new Guna.UI2.WinForms.Guna2PictureBox();
            lblUserName = new Label();
            lblFollowing = new Label();
            label2 = new Label();
            label4 = new Label();
            lblFollowers = new Label();
            pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            iconBack = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            flowLayoutPost = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)iconSetting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBack).BeginInit();
            SuspendLayout();
            // 
            // btnFollow
            // 
            btnFollow.BackColor = Color.Transparent;
            btnFollow.BorderRadius = 10;
            btnFollow.Cursor = Cursors.Hand;
            btnFollow.CustomizableEdges = customizableEdges1;
            btnFollow.DisabledState.BorderColor = Color.DarkGray;
            btnFollow.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFollow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFollow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFollow.Font = new Font("Segoe UI", 9F);
            btnFollow.ForeColor = Color.White;
            btnFollow.Location = new Point(662, 45);
            btnFollow.Name = "btnFollow";
            btnFollow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFollow.Size = new Size(109, 35);
            btnFollow.TabIndex = 17;
            btnFollow.Text = "Takip Et";
            btnFollow.Click += btnFollow_Click;
            // 
            // iconSetting
            // 
            iconSetting.BackColor = Color.Transparent;
            iconSetting.Cursor = Cursors.Hand;
            iconSetting.CustomizableEdges = customizableEdges3;
            iconSetting.Image = (Image)resources.GetObject("iconSetting.Image");
            iconSetting.ImageRotate = 0F;
            iconSetting.Location = new Point(796, 40);
            iconSetting.Name = "iconSetting";
            iconSetting.ShadowDecoration.CustomizableEdges = customizableEdges4;
            iconSetting.Size = new Size(40, 40);
            iconSetting.SizeMode = PictureBoxSizeMode.StretchImage;
            iconSetting.TabIndex = 16;
            iconSetting.TabStop = false;
            iconSetting.Click += iconSetting_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.Location = new Point(152, 45);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(48, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            // 
            // lblFollowing
            // 
            lblFollowing.AutoSize = true;
            lblFollowing.BackColor = Color.Transparent;
            lblFollowing.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFollowing.Location = new Point(488, 78);
            lblFollowing.Name = "lblFollowing";
            lblFollowing.Size = new Size(48, 20);
            lblFollowing.TabIndex = 1;
            lblFollowing.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(310, 45);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Takipçiler";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(488, 45);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 1;
            label4.Text = "Takip";
            // 
            // lblFollowers
            // 
            lblFollowers.AutoSize = true;
            lblFollowers.BackColor = Color.Transparent;
            lblFollowers.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFollowers.Location = new Point(321, 78);
            lblFollowers.Name = "lblFollowers";
            lblFollowers.Size = new Size(48, 20);
            lblFollowers.TabIndex = 1;
            lblFollowers.Text = "label1";
            lblFollowers.Click += lblFollowers_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackColor = Color.Transparent;
            pictureBoxProfile.ErrorImage = Properties.Resources.user;
            pictureBoxProfile.Image = Properties.Resources.user;
            pictureBoxProfile.ImageRotate = 0F;
            pictureBoxProfile.Location = new Point(13, 13);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pictureBoxProfile.Size = new Size(100, 100);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 18;
            pictureBoxProfile.TabStop = false;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 30;
            guna2ContainerControl1.Controls.Add(pictureBoxProfile);
            guna2ContainerControl1.Controls.Add(btnFollow);
            guna2ContainerControl1.Controls.Add(lblFollowers);
            guna2ContainerControl1.Controls.Add(iconSetting);
            guna2ContainerControl1.Controls.Add(label4);
            guna2ContainerControl1.Controls.Add(lblUserName);
            guna2ContainerControl1.Controls.Add(label2);
            guna2ContainerControl1.Controls.Add(lblFollowing);
            guna2ContainerControl1.CustomizableEdges = customizableEdges6;
            guna2ContainerControl1.FillColor = Color.FromArgb(192, 192, 255);
            guna2ContainerControl1.Location = new Point(92, 32);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ContainerControl1.Size = new Size(882, 126);
            guna2ContainerControl1.TabIndex = 6;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // iconBack
            // 
            iconBack.BackColor = Color.Transparent;
            iconBack.Cursor = Cursors.Hand;
            iconBack.CustomizableEdges = customizableEdges8;
            iconBack.Image = (Image)resources.GetObject("iconBack.Image");
            iconBack.ImageRotate = 0F;
            iconBack.Location = new Point(30, 77);
            iconBack.Name = "iconBack";
            iconBack.ShadowDecoration.CustomizableEdges = customizableEdges9;
            iconBack.Size = new Size(40, 40);
            iconBack.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBack.TabIndex = 17;
            iconBack.TabStop = false;
            iconBack.Click += iconBack_Click;
            // 
            // guna2Shapes1
            // 
            guna2Shapes1.BackColor = Color.Transparent;
            guna2Shapes1.BorderThickness = 5;
            guna2Shapes1.LineThickness = 3;
            guna2Shapes1.Location = new Point(92, 164);
            guna2Shapes1.Name = "guna2Shapes1";
            guna2Shapes1.PolygonSides = 10;
            guna2Shapes1.PolygonSkip = 1;
            guna2Shapes1.Rotate = 0F;
            guna2Shapes1.RoundedEdges = customizableEdges10;
            guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            guna2Shapes1.Size = new Size(882, 10);
            guna2Shapes1.TabIndex = 32;
            guna2Shapes1.Text = "guna2Shapes1";
            guna2Shapes1.Zoom = 100;
            // 
            // flowLayoutPost
            // 
            flowLayoutPost.AutoScroll = true;
            flowLayoutPost.FlowDirection = FlowDirection.TopDown;
            flowLayoutPost.Location = new Point(244, 215);
            flowLayoutPost.Name = "flowLayoutPost";
            flowLayoutPost.Size = new Size(857, 407);
            flowLayoutPost.TabIndex = 33;
            flowLayoutPost.WrapContents = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1050, 750);
            Controls.Add(flowLayoutPost);
            Controls.Add(guna2Shapes1);
            Controls.Add(iconBack);
            Controls.Add(guna2ContainerControl1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)iconSetting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBack).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblUserName;
        private Label lblFollowing;
        private Label label2;
        private Label label4;
        private Label lblFollowers;
        private Guna.UI2.WinForms.Guna2Button btnFollow;
        private Guna.UI2.WinForms.Guna2PictureBox iconSetting;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2PictureBox iconBack;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private FlowLayoutPanel flowLayoutPost;
    }
}