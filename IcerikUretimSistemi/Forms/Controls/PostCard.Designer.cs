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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostCard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblCreator = new Label();
            lblDate = new Label();
            label1 = new Label();
            pictureProfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLikeCount = new Label();
            lblCommentCount = new Label();
            iconComment = new Guna.UI2.WinForms.Guna2PictureBox();
            iconLike = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            lblContent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            ((System.ComponentModel.ISupportInitialize)pictureProfil).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconComment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconLike).BeginInit();
            guna2ContainerControl2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCreator.Location = new Point(31, 139);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(41, 17);
            lblCreator.TabIndex = 0;
            lblCreator.Text = "label1";
            lblCreator.Click += lblCreator_Click;
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
            guna2ContainerControl1.Controls.Add(guna2PictureBox1);
            guna2ContainerControl1.Controls.Add(lblTitle);
            guna2ContainerControl1.Controls.Add(lblLikeCount);
            guna2ContainerControl1.Controls.Add(lblCommentCount);
            guna2ContainerControl1.Controls.Add(iconComment);
            guna2ContainerControl1.Controls.Add(iconLike);
            guna2ContainerControl1.Controls.Add(guna2ContainerControl2);
            guna2ContainerControl1.Controls.Add(guna2Shapes1);
            guna2ContainerControl1.Controls.Add(pictureProfil);
            guna2ContainerControl1.Controls.Add(lblDate);
            guna2ContainerControl1.Controls.Add(lblCreator);
            guna2ContainerControl1.Controls.Add(label1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges11;
            guna2ContainerControl1.Location = new Point(3, 3);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2ContainerControl1.Size = new Size(629, 296);
            guna2ContainerControl1.TabIndex = 10;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            guna2ContainerControl1.Click += guna2ContainerControl1_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(417, 209);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
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
            iconComment.CustomizableEdges = customizableEdges4;
            iconComment.Image = (Image)resources.GetObject("iconComment.Image");
            iconComment.ImageRotate = 0F;
            iconComment.Location = new Point(262, 214);
            iconComment.Name = "iconComment";
            iconComment.ShadowDecoration.CustomizableEdges = customizableEdges5;
            iconComment.Size = new Size(30, 30);
            iconComment.SizeMode = PictureBoxSizeMode.StretchImage;
            iconComment.TabIndex = 17;
            iconComment.TabStop = false;
            iconComment.Click += iconComment_Click;
            // 
            // iconLike
            // 
            iconLike.Cursor = Cursors.Hand;
            iconLike.CustomizableEdges = customizableEdges6;
            iconLike.Image = (Image)resources.GetObject("iconLike.Image");
            iconLike.ImageRotate = 0F;
            iconLike.Location = new Point(158, 214);
            iconLike.Name = "iconLike";
            iconLike.ShadowDecoration.CustomizableEdges = customizableEdges7;
            iconLike.Size = new Size(30, 30);
            iconLike.SizeMode = PictureBoxSizeMode.StretchImage;
            iconLike.TabIndex = 16;
            iconLike.TabStop = false;
            iconLike.Click += guna2PictureBox1_Click;
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.BorderRadius = 50;
            guna2ContainerControl2.Controls.Add(lblContent);
            guna2ContainerControl2.CustomizableEdges = customizableEdges8;
            guna2ContainerControl2.FillColor = Color.WhiteSmoke;
            guna2ContainerControl2.Location = new Point(127, 92);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ContainerControl2.Size = new Size(405, 116);
            guna2ContainerControl2.TabIndex = 12;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // lblContent
            // 
            lblContent.BackColor = Color.Transparent;
            lblContent.Location = new Point(28, 47);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(97, 17);
            lblContent.TabIndex = 20;
            lblContent.Text = "guna2HtmlLabel1";
            // 
            // guna2Shapes1
            // 
            guna2Shapes1.BorderThickness = 0;
            guna2Shapes1.LineThickness = 3;
            guna2Shapes1.Location = new Point(106, 76);
            guna2Shapes1.Name = "guna2Shapes1";
            guna2Shapes1.PolygonSkip = 1;
            guna2Shapes1.Rotate = 0F;
            guna2Shapes1.RoundedEdges = customizableEdges10;
            guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            guna2Shapes1.Size = new Size(446, 10);
            guna2Shapes1.TabIndex = 11;
            guna2Shapes1.Text = "guna2Shapes1";
            guna2Shapes1.Zoom = 80;
            // 
            // PostCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ContainerControl1);
            Name = "PostCard";
            Size = new Size(668, 300);
            Load += PostCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureProfil).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconComment).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconLike).EndInit();
            guna2ContainerControl2.ResumeLayout(false);
            guna2ContainerControl2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCreator;
        private Label lblDate;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureProfil;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Guna.UI2.WinForms.Guna2PictureBox iconLike;
        private Label lblLikeCount;
        private Label lblCommentCount;
        private Guna.UI2.WinForms.Guna2PictureBox iconComment;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContent;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
