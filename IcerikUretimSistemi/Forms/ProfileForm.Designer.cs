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
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            lblFollowers = new Label();
            label4 = new Label();
            label2 = new Label();
            lblFollowing = new Label();
            lblUserName = new Label();
            btnFollow = new Button();
            pictureBoxProfile = new PictureBox();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnFollow);
            flowLayoutPanel1.Location = new Point(80, 174);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(854, 331);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
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
            // 
            // lblFollowers
            // 
            lblFollowers.AutoSize = true;
            lblFollowers.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFollowers.Location = new Point(367, 54);
            lblFollowers.Name = "lblFollowers";
            lblFollowers.Size = new Size(48, 20);
            lblFollowers.TabIndex = 1;
            lblFollowers.Text = "label1";
            lblFollowers.Click += lblFollowers_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(491, 54);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 1;
            label4.Text = "Takip :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(279, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Takipçiler :";
            // 
            // lblFollowing
            // 
            lblFollowing.AutoSize = true;
            lblFollowing.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFollowing.Location = new Point(550, 54);
            lblFollowing.Name = "lblFollowing";
            lblFollowing.Size = new Size(48, 20);
            lblFollowing.TabIndex = 1;
            lblFollowing.Text = "label1";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.Location = new Point(144, 54);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(48, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            // 
            // btnFollow
            // 
            btnFollow.Location = new Point(3, 3);
            btnFollow.Name = "btnFollow";
            btnFollow.Size = new Size(98, 23);
            btnFollow.TabIndex = 3;
            btnFollow.Tag = "userToFollow";
            btnFollow.Text = "Takip Et";
            btnFollow.UseVisualStyleBackColor = true;
            btnFollow.Click += btnFollow_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(6, 22);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(86, 77);
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += pictureBoxProfile_Click;
            // 
            // ıconButton1
            // 
            ıconButton1.BackgroundImageLayout = ImageLayout.Stretch;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 20;
            ıconButton1.Location = new Point(11, 34);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(75, 23);
            ıconButton1.TabIndex = 5;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 581);
            Controls.Add(ıconButton1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += ProfileForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private PictureBox pictureBoxProfile;
        private Button btnFollow;
        private Label lblUserName;
        private Label lblFollowing;
        private Label label2;
        private Label label4;
        private Label lblFollowers;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}