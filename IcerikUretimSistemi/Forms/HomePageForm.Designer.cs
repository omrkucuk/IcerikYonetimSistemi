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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnPersons = new FontAwesome.Sharp.IconButton();
            btnPost = new FontAwesome.Sharp.IconButton();
            btnProfil = new FontAwesome.Sharp.IconButton();
            btnMessage = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            icnComment = new FontAwesome.Sharp.IconButton();
            icnLike = new FontAwesome.Sharp.IconButton();
            lblComment = new Label();
            lblLike = new Label();
            lblContent = new Label();
            lblTitle = new Label();
            lblName = new Label();
            lblUserName = new Label();
            pictureBox2 = new PictureBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            groupBox1.Location = new Point(30, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 405);
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
            btnPersons.Location = new Point(25, 162);
            btnPersons.Name = "btnPersons";
            btnPersons.Size = new Size(145, 34);
            btnPersons.TabIndex = 3;
            btnPersons.Text = "Kişiler";
            btnPersons.UseVisualStyleBackColor = false;
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
            btnPost.Location = new Point(25, 112);
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
            // 
            // btnMessage
            // 
            btnMessage.BackColor = Color.Transparent;
            btnMessage.FlatStyle = FlatStyle.Flat;
            btnMessage.IconChar = FontAwesome.Sharp.IconChar.Message;
            btnMessage.IconColor = Color.Black;
            btnMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMessage.Location = new Point(45, 287);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(80, 89);
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
            pictureBox1.Location = new Point(-26, -42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(264, 167);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(656, 360);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(icnComment);
            panel1.Controls.Add(icnLike);
            panel1.Controls.Add(lblComment);
            panel1.Controls.Add(lblLike);
            panel1.Controls.Add(lblContent);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 207);
            panel1.TabIndex = 0;
            // 
            // icnComment
            // 
            icnComment.Cursor = Cursors.Hand;
            icnComment.FlatStyle = FlatStyle.Flat;
            icnComment.IconChar = FontAwesome.Sharp.IconChar.Comment;
            icnComment.IconColor = Color.Black;
            icnComment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icnComment.IconSize = 28;
            icnComment.Location = new Point(535, 168);
            icnComment.Name = "icnComment";
            icnComment.Size = new Size(31, 32);
            icnComment.TabIndex = 6;
            icnComment.UseVisualStyleBackColor = true;
            // 
            // icnLike
            // 
            icnLike.BackColor = Color.Transparent;
            icnLike.Cursor = Cursors.Hand;
            icnLike.FlatStyle = FlatStyle.Flat;
            icnLike.IconChar = FontAwesome.Sharp.IconChar.Heart;
            icnLike.IconColor = Color.Black;
            icnLike.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icnLike.IconSize = 28;
            icnLike.Location = new Point(429, 168);
            icnLike.Name = "icnLike";
            icnLike.Size = new Size(31, 32);
            icnLike.TabIndex = 5;
            icnLike.UseVisualStyleBackColor = false;
            // 
            // lblComment
            // 
            lblComment.Font = new Font("Segoe UI", 11F);
            lblComment.Location = new Point(569, 173);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(55, 22);
            lblComment.TabIndex = 4;
            lblComment.Text = "Yorum";
            // 
            // lblLike
            // 
            lblLike.Font = new Font("Segoe UI", 11F);
            lblLike.Location = new Point(466, 173);
            lblLike.Name = "lblLike";
            lblLike.Size = new Size(71, 22);
            lblLike.TabIndex = 3;
            lblLike.Text = "Beğeni";
            // 
            // lblContent
            // 
            lblContent.BackColor = Color.LightCyan;
            lblContent.Font = new Font("Segoe UI", 11F);
            lblContent.Location = new Point(12, 59);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(625, 101);
            lblContent.TabIndex = 2;
            lblContent.Text = "İçerik";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 11F);
            lblTitle.Location = new Point(12, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Başlık";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(12, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(126, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Kullanıcı Adı";
            lblName.Click += lblName_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.Location = new Point(887, 65);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(73, 19);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "UserName";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(903, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.Location = new Point(875, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 25);
            btnSearch.TabIndex = 7;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(985, 560);
            Controls.Add(btnSearch);
            Controls.Add(pictureBox2);
            Controls.Add(lblUserName);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePageForm";
            Text = "HomePageForm";
            Load += HomePageForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label lblUserName;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnMessage;
        private FontAwesome.Sharp.IconButton btnProfil;
        private FontAwesome.Sharp.IconButton btnPost;
        private FontAwesome.Sharp.IconButton btnPersons;
        private Panel panel1;
        private Label label2;
        private Label lblName;
        private Label lblComment;
        private Label lblLike;
        private Label lblContent;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton icnLike;
        private FontAwesome.Sharp.IconButton icnComment;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
    }
}