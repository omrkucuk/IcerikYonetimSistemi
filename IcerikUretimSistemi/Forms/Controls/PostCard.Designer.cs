namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class PostCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostCard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblDate = new Label();
            label1 = new Label();
            pictureProfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            lblCreator = new Guna.UI2.WinForms.Guna2TextBox();
            lblContent = new Guna.UI2.WinForms.Guna2TextBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLikeCount = new Label();
            lblCommentCount = new Label();
            iconComment = new Guna.UI2.WinForms.Guna2PictureBox();
            iconLike = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            ((System.ComponentModel.ISupportInitialize)pictureProfil).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconComment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconLike).BeginInit();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(127, 258);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 0;
            lblDate.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 258);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Oluşturulma Tarihi :";
            // 
            // pictureProfil
            // 
            pictureProfil.BackgroundImageLayout = ImageLayout.Stretch;
            pictureProfil.ErrorImage = Properties.Resources.user;
            pictureProfil.Image = Properties.Resources.user;
            pictureProfil.ImageRotate = 0F;
            pictureProfil.Location = new Point(31, 37);
            pictureProfil.Name = "pictureProfil";
            pictureProfil.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pictureProfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pictureProfil.Size = new Size(69, 69);
            pictureProfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProfil.TabIndex = 9;
            pictureProfil.TabStop = false;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 50;
            guna2ContainerControl1.Controls.Add(lblCreator);
            guna2ContainerControl1.Controls.Add(lblContent);
            guna2ContainerControl1.Controls.Add(guna2PictureBox1);
            guna2ContainerControl1.Controls.Add(lblTitle);
            guna2ContainerControl1.Controls.Add(lblLikeCount);
            guna2ContainerControl1.Controls.Add(lblCommentCount);
            guna2ContainerControl1.Controls.Add(iconComment);
            guna2ContainerControl1.Controls.Add(iconLike);
            guna2ContainerControl1.Controls.Add(guna2Shapes1);
            guna2ContainerControl1.Controls.Add(pictureProfil);
            guna2ContainerControl1.Controls.Add(lblDate);
            guna2ContainerControl1.Controls.Add(label1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges13;
            guna2ContainerControl1.Location = new Point(3, 3);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ContainerControl1.ShadowDecoration.Shadow = new Padding(50);
            guna2ContainerControl1.Size = new Size(629, 296);
            guna2ContainerControl1.TabIndex = 10;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            guna2ContainerControl1.Click += guna2ContainerControl1_Click;
            // 
            // lblCreator
            // 
            lblCreator.BackColor = Color.Transparent;
            lblCreator.BorderColor = Color.Transparent;
            lblCreator.BorderThickness = 0;
            lblCreator.CustomizableEdges = customizableEdges2;
            lblCreator.DefaultText = "kullanıcı";
            lblCreator.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            lblCreator.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            lblCreator.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            lblCreator.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            lblCreator.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            lblCreator.Font = new Font("Segoe UI", 9F);
            lblCreator.ForeColor = Color.Black;
            lblCreator.HoverState.BorderColor = Color.White;
            lblCreator.Location = new Point(20, 112);
            lblCreator.Name = "lblCreator";
            lblCreator.PlaceholderForeColor = Color.Transparent;
            lblCreator.PlaceholderText = "";
            lblCreator.ReadOnly = true;
            lblCreator.SelectedText = "";
            lblCreator.ShadowDecoration.CustomizableEdges = customizableEdges3;
            lblCreator.Size = new Size(90, 36);
            lblCreator.TabIndex = 24;
            lblCreator.TextAlign = HorizontalAlignment.Center;
            // 
            // lblContent
            // 
            lblContent.BackColor = Color.White;
            lblContent.BorderRadius = 15;
            lblContent.CustomizableEdges = customizableEdges4;
            lblContent.DefaultText = "";
            lblContent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            lblContent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            lblContent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            lblContent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            lblContent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            lblContent.Font = new Font("Segoe UI", 9F);
            lblContent.ForeColor = Color.Black;
            lblContent.HoverState.BorderColor = Color.FromArgb(213, 218, 223);
            lblContent.Location = new Point(154, 92);
            lblContent.Multiline = true;
            lblContent.Name = "lblContent";
            lblContent.PlaceholderText = "";
            lblContent.ReadOnly = true;
            lblContent.SelectedText = "";
            lblContent.ShadowDecoration.CustomizableEdges = customizableEdges5;
            lblContent.Size = new Size(398, 116);
            lblContent.TabIndex = 21;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.Cursor = Cursors.Hand;
            guna2PictureBox1.CustomizableEdges = customizableEdges6;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(468, 214);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Size = new Size(35, 35);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 20;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Click += guna2PictureBox1_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(154, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 22);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "guna2HtmlLabel1";
            // 
            // lblLikeCount
            // 
            lblLikeCount.AutoSize = true;
            lblLikeCount.Location = new Point(194, 226);
            lblLikeCount.Name = "lblLikeCount";
            lblLikeCount.Size = new Size(38, 15);
            lblLikeCount.TabIndex = 18;
            lblLikeCount.Text = "label2";
            lblLikeCount.Click += label3_Click;
            // 
            // lblCommentCount
            // 
            lblCommentCount.AutoSize = true;
            lblCommentCount.Location = new Point(298, 226);
            lblCommentCount.Name = "lblCommentCount";
            lblCommentCount.Size = new Size(38, 15);
            lblCommentCount.TabIndex = 18;
            lblCommentCount.Text = "label2";
            lblCommentCount.Click += lblCommentCount_Click;
            // 
            // iconComment
            // 
            iconComment.Cursor = Cursors.Hand;
            iconComment.CustomizableEdges = customizableEdges8;
            iconComment.Image = (Image)resources.GetObject("iconComment.Image");
            iconComment.ImageRotate = 0F;
            iconComment.Location = new Point(262, 214);
            iconComment.Name = "iconComment";
            iconComment.ShadowDecoration.CustomizableEdges = customizableEdges9;
            iconComment.Size = new Size(30, 30);
            iconComment.SizeMode = PictureBoxSizeMode.StretchImage;
            iconComment.TabIndex = 17;
            iconComment.TabStop = false;
            iconComment.Click += iconComment_Click;
            // 
            // iconLike
            // 
            iconLike.Cursor = Cursors.Hand;
            iconLike.CustomizableEdges = customizableEdges10;
            iconLike.ErrorImage = Properties.Resources.heart_thin_icon;
            iconLike.Image = Properties.Resources.heart_thin_icon;
            iconLike.ImageRotate = 0F;
            iconLike.Location = new Point(158, 214);
            iconLike.Name = "iconLike";
            iconLike.ShadowDecoration.CustomizableEdges = customizableEdges11;
            iconLike.Size = new Size(30, 30);
            iconLike.SizeMode = PictureBoxSizeMode.StretchImage;
            iconLike.TabIndex = 16;
            iconLike.TabStop = false;
            iconLike.Click += guna2PictureBox1_Click;
            // 
            // guna2Shapes1
            // 
            guna2Shapes1.BorderThickness = 0;
            guna2Shapes1.LineThickness = 3;
            guna2Shapes1.Location = new Point(154, 76);
            guna2Shapes1.Name = "guna2Shapes1";
            guna2Shapes1.PolygonSkip = 1;
            guna2Shapes1.Rotate = 0F;
            guna2Shapes1.RoundedEdges = customizableEdges12;
            guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            guna2Shapes1.Size = new Size(398, 10);
            guna2Shapes1.TabIndex = 11;
            guna2Shapes1.Text = "guna2Shapes1";
            guna2Shapes1.Zoom = 100;
            // 
            // PostCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(guna2ContainerControl1);
            Name = "PostCard";
            Size = new Size(649, 302);
            Load += PostCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureProfil).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconComment).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconLike).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblDate;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureProfil;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2PictureBox iconLike;
        private Label lblLikeCount;
        private Label lblCommentCount;
        private Guna.UI2.WinForms.Guna2PictureBox iconComment;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox lblContent;
        private Guna.UI2.WinForms.Guna2TextBox lblCreator;
    }
}
