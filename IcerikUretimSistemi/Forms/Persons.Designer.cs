namespace IcerikUretimSistemi.UI.Forms
{
    partial class Persons
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persons));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanelUsers = new FlowLayoutPanel();
            iconBack = new Guna.UI2.WinForms.Guna2PictureBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox6).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelUsers
            // 
            flowLayoutPanelUsers.AutoScroll = true;
            flowLayoutPanelUsers.Location = new Point(174, 84);
            flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            flowLayoutPanelUsers.Size = new Size(909, 610);
            flowLayoutPanelUsers.TabIndex = 0;
            flowLayoutPanelUsers.Paint += flowLayoutPanelUsers_Paint;
            // 
            // iconBack
            // 
            iconBack.BackColor = Color.Transparent;
            iconBack.Cursor = Cursors.Hand;
            iconBack.CustomizableEdges = customizableEdges7;
            iconBack.Image = (Image)resources.GetObject("iconBack.Image");
            iconBack.ImageRotate = 0F;
            iconBack.Location = new Point(50, 24);
            iconBack.Name = "iconBack";
            iconBack.ShadowDecoration.CustomizableEdges = customizableEdges8;
            iconBack.Size = new Size(40, 40);
            iconBack.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBack.TabIndex = 18;
            iconBack.TabStop = false;
            iconBack.Click += iconBack_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 12;
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(174, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(724, 36);
            txtSearch.TabIndex = 19;
            txtSearch.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2PictureBox6
            // 
            guna2PictureBox6.BackColor = Color.Transparent;
            guna2PictureBox6.CustomizableEdges = customizableEdges11;
            guna2PictureBox6.Image = (Image)resources.GetObject("guna2PictureBox6.Image");
            guna2PictureBox6.ImageRotate = 0F;
            guna2PictureBox6.Location = new Point(927, 24);
            guna2PictureBox6.Name = "guna2PictureBox6";
            guna2PictureBox6.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2PictureBox6.Size = new Size(30, 30);
            guna2PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox6.TabIndex = 22;
            guna2PictureBox6.TabStop = false;
            // 
            // Persons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1034, 711);
            Controls.Add(guna2PictureBox6);
            Controls.Add(txtSearch);
            Controls.Add(iconBack);
            Controls.Add(flowLayoutPanelUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Persons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Persons";
            Load += Persons_Load;
            ((System.ComponentModel.ISupportInitialize)iconBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelUsers;
        private Guna.UI2.WinForms.Guna2PictureBox iconBack;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
    }
}