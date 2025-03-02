namespace IcerikUretimSistemi.UI.Forms
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnPersons = new FontAwesome.Sharp.IconButton();
            btnPost = new FontAwesome.Sharp.IconButton();
            btnProfil = new FontAwesome.Sharp.IconButton();
            btnMessage = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            lblUserName = new Label();
            pictureBox2 = new PictureBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gunaPictureProfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gunaPictureProfil).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(596, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPersons);
            groupBox1.Controls.Add(btnPost);
            groupBox1.Controls.Add(btnProfil);
            groupBox1.Controls.Add(btnMessage);
            groupBox1.Location = new Point(27, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 494);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPersons
            // 
            btnPersons.BackColor = Color.Transparent;
            btnPersons.FlatStyle = FlatStyle.Flat;
            btnPersons.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersons.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnPersons.IconColor = Color.Black;
            btnPersons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPersons.IconSize = 35;
            btnPersons.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersons.Location = new Point(25, 200);
            btnPersons.Name = "btnPersons";
            btnPersons.Size = new Size(145, 34);
            btnPersons.TabIndex = 3;
            btnPersons.Text = "Kişiler";
            btnPersons.UseVisualStyleBackColor = false;
            btnPersons.Click += btnPersons_Click_1;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.Transparent;
            btnPost.FlatStyle = FlatStyle.Flat;
            btnPost.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPost.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnPost.IconColor = Color.Black;
            btnPost.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPost.IconSize = 35;
            btnPost.ImageAlign = ContentAlignment.MiddleLeft;
            btnPost.Location = new Point(25, 130);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(145, 34);
            btnPost.TabIndex = 2;
            btnPost.Text = "        Gönderiler";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnProfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            btnProfil.IconColor = Color.Black;
            btnProfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfil.IconSize = 35;
            btnProfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfil.Location = new Point(25, 54);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(145, 34);
            btnProfil.TabIndex = 1;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click_1;
            // 
            // btnMessage
            // 
            btnMessage.BackColor = Color.Transparent;
            btnMessage.FlatStyle = FlatStyle.Flat;
            btnMessage.IconChar = FontAwesome.Sharp.IconChar.Message;
            btnMessage.IconColor = Color.Black;
            btnMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMessage.Location = new Point(48, 368);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(89, 89);
            btnMessage.TabIndex = 0;
            btnMessage.Text = "Mesajlaşma";
            btnMessage.TextAlign = ContentAlignment.BottomCenter;
            btnMessage.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMessage.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-39, -42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.Location = new Point(925, 115);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(73, 19);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "UserName";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(967, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.Location = new Point(874, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 25);
            btnSearch.TabIndex = 7;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(264, 187);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(672, 471);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // gunaPictureProfil
            // 
            gunaPictureProfil.BackgroundImageLayout = ImageLayout.Stretch;
            gunaPictureProfil.ImageRotate = 0F;
            gunaPictureProfil.Location = new Point(917, 12);
            gunaPictureProfil.Name = "gunaPictureProfil";
            gunaPictureProfil.ShadowDecoration.CustomizableEdges = customizableEdges1;
            gunaPictureProfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gunaPictureProfil.Size = new Size(90, 90);
            gunaPictureProfil.SizeMode = PictureBoxSizeMode.StretchImage;
            gunaPictureProfil.TabIndex = 8;
            gunaPictureProfil.TabStop = false;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1034, 711);
            Controls.Add(gunaPictureProfil);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSearch);
            Controls.Add(pictureBox2);
            Controls.Add(lblUserName);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePageForm";
            Load += HomePageForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gunaPictureProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label lblUserName;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnMessage;
        private FontAwesome.Sharp.IconButton btnProfil;
        private FontAwesome.Sharp.IconButton btnPost;
        private FontAwesome.Sharp.IconButton btnPersons;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunaPictureProfil;
    }
}