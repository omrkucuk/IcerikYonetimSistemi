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
            flowLayoutPost = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            btnFollow = new Guna.UI2.WinForms.Guna2Button();
            iconSetting = new Guna.UI2.WinForms.Guna2PictureBox();
            pictureBoxProfile = new PictureBox();
            lblUserName = new Label();
            lblFollowing = new Label();
            label2 = new Label();
            label4 = new Label();
            lblFollowers = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconSetting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPost
            // 
            flowLayoutPost.Location = new Point(92, 174);
            flowLayoutPost.Name = "flowLayoutPost";
            flowLayoutPost.Size = new Size(854, 331);
            flowLayoutPost.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFollow);
            groupBox1.Controls.Add(iconSetting);
            groupBox1.Controls.Add(pictureBoxProfile);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Controls.Add(lblFollowing);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblFollowers);
            groupBox1.Location = new Point(92, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 132);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnFollow
            // 
            btnFollow.BorderRadius = 10;
            btnFollow.CustomizableEdges = customizableEdges1;
            btnFollow.DisabledState.BorderColor = Color.DarkGray;
            btnFollow.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFollow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFollow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFollow.Font = new Font("Segoe UI", 9F);
            btnFollow.ForeColor = Color.White;
            btnFollow.Location = new Point(665, 54);
            btnFollow.Name = "btnFollow";
            btnFollow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFollow.Size = new Size(109, 35);
            btnFollow.TabIndex = 17;
            btnFollow.Text = "Takip Et";
            // 
            // iconSetting
            // 
            iconSetting.Cursor = Cursors.Hand;
            iconSetting.CustomizableEdges = customizableEdges3;
            iconSetting.Image = (Image)resources.GetObject("iconSetting.Image");
            iconSetting.ImageRotate = 0F;
            iconSetting.Location = new Point(799, 49);
            iconSetting.Name = "iconSetting";
            iconSetting.ShadowDecoration.CustomizableEdges = customizableEdges4;
            iconSetting.Size = new Size(40, 40);
            iconSetting.SizeMode = PictureBoxSizeMode.StretchImage;
            iconSetting.TabIndex = 16;
            iconSetting.TabStop = false;
            iconSetting.Click += iconSetting_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxProfile.Location = new Point(6, 22);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(86, 85);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += pictureBoxProfile_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.Location = new Point(124, 54);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(48, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            // 
            // lblFollowing
            // 
            lblFollowing.AutoSize = true;
            lblFollowing.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFollowing.Location = new Point(491, 87);
            lblFollowing.Name = "lblFollowing";
            lblFollowing.Size = new Size(48, 20);
            lblFollowing.TabIndex = 1;
            lblFollowing.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(313, 54);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Takipçiler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(491, 54);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 1;
            label4.Text = "Takip";
            // 
            // lblFollowers
            // 
            lblFollowers.AutoSize = true;
            lblFollowers.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFollowers.Location = new Point(324, 87);
            lblFollowers.Name = "lblFollowers";
            lblFollowers.Size = new Size(48, 20);
            lblFollowers.TabIndex = 1;
            lblFollowers.Text = "label1";
            lblFollowers.Click += lblFollowers_Click;
            // 
            // ıconButton1
            // 
            ıconButton1.BackgroundImageLayout = ImageLayout.Stretch;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 20;
            ıconButton1.Location = new Point(11, 21);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(75, 32);
            ıconButton1.TabIndex = 5;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1034, 711);
            Controls.Add(ıconButton1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPost);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += ProfileForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconSetting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPost;
        private GroupBox groupBox1;
        private PictureBox pictureBoxProfile;
        private Label lblUserName;
        private Label lblFollowing;
        private Label label2;
        private Label label4;
        private Label lblFollowers;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Guna.UI2.WinForms.Guna2Button btnFollow;
        private Guna.UI2.WinForms.Guna2PictureBox iconSetting;
    }
}