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
            panel1 = new Panel();
            btnFollow = new Button();
            button1 = new Button();
            lblFollowing = new Label();
            label4 = new Label();
            lblFollowers = new Label();
            label2 = new Label();
            lblUserName = new Label();
            pictureBoxProfile = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFollow);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblFollowing);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblFollowers);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(pictureBoxProfile);
            panel1.Location = new Point(80, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 128);
            panel1.TabIndex = 0;
            // 
            // btnFollow
            // 
            btnFollow.Location = new Point(641, 95);
            btnFollow.Name = "btnFollow";
            btnFollow.Size = new Size(98, 23);
            btnFollow.TabIndex = 3;
            btnFollow.Tag = "userToFollow";
            btnFollow.Text = "Takip Et";
            btnFollow.UseVisualStyleBackColor = true;
            btnFollow.Click += btnFollow_Click;
            // 
            // button1
            // 
            button1.Location = new Point(641, 13);
            button1.Name = "button1";
            button1.Size = new Size(98, 76);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblFollowing
            // 
            lblFollowing.AutoSize = true;
            lblFollowing.Location = new Point(539, 52);
            lblFollowing.Name = "lblFollowing";
            lblFollowing.Size = new Size(38, 15);
            lblFollowing.TabIndex = 1;
            lblFollowing.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 52);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 1;
            label4.Text = "Takip";
            // 
            // lblFollowers
            // 
            lblFollowers.AutoSize = true;
            lblFollowers.Location = new Point(333, 52);
            lblFollowers.Name = "lblFollowers";
            lblFollowers.Size = new Size(38, 15);
            lblFollowers.TabIndex = 1;
            lblFollowers.Text = "label1";
            lblFollowers.Click += lblFollowers_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 52);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Takipçiler";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(160, 52);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(38, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(29, 19);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(86, 77);
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(80, 174);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(854, 331);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 598);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += ProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxProfile;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblFollowing;
        private Label label4;
        private Label lblFollowers;
        private Label label2;
        private Label lblUserName;
        private Button button1;
        private Button btnFollow;
    }
}