namespace IcerikUretimSistemi.UI.Forms
{
    partial class CommentForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            btnComment = new Guna.UI2.WinForms.Guna2Button();
            iconBack = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconBack).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(39, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(621, 368);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // txtComment
            // 
            txtComment.CustomizableEdges = customizableEdges1;
            txtComment.DefaultText = "";
            txtComment.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtComment.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtComment.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtComment.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtComment.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtComment.Font = new Font("Segoe UI", 9F);
            txtComment.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtComment.Location = new Point(39, 420);
            txtComment.Name = "txtComment";
            txtComment.PlaceholderText = "";
            txtComment.SelectedText = "";
            txtComment.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtComment.Size = new Size(404, 36);
            txtComment.TabIndex = 1;
            // 
            // btnComment
            // 
            btnComment.CustomizableEdges = customizableEdges3;
            btnComment.DisabledState.BorderColor = Color.DarkGray;
            btnComment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnComment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnComment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnComment.Font = new Font("Segoe UI", 9F);
            btnComment.ForeColor = Color.White;
            btnComment.Location = new Point(449, 420);
            btnComment.Name = "btnComment";
            btnComment.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnComment.Size = new Size(157, 36);
            btnComment.TabIndex = 2;
            btnComment.Text = "Gönder";
            btnComment.Click += btnComment_Click;
            // 
            // iconBack
            // 
            iconBack.BackColor = Color.Transparent;
            iconBack.Cursor = Cursors.Hand;
            iconBack.CustomizableEdges = customizableEdges5;
            iconBack.Image = (Image)resources.GetObject("iconBack.Image");
            iconBack.ImageRotate = 0F;
            iconBack.Location = new Point(560, 12);
            iconBack.Name = "iconBack";
            iconBack.ShadowDecoration.CustomizableEdges = customizableEdges6;
            iconBack.Size = new Size(40, 40);
            iconBack.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBack.TabIndex = 19;
            iconBack.TabStop = false;
            iconBack.Click += iconBack_Click;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(612, 486);
            Controls.Add(iconBack);
            Controls.Add(btnComment);
            Controls.Add(txtComment);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            MaximizeBox = false;
            Name = "CommentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CommentForm";
            Load += CommentForm_Load;
            ((System.ComponentModel.ISupportInitialize)iconBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtComment;
        private Guna.UI2.WinForms.Guna2Button btnComment;
        private Guna.UI2.WinForms.Guna2PictureBox iconBack;
    }
}