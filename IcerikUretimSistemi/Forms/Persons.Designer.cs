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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persons));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanelUsers = new FlowLayoutPanel();
            iconBack = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconBack).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelUsers
            // 
            flowLayoutPanelUsers.AutoScroll = true;
            flowLayoutPanelUsers.Location = new Point(174, 24);
            flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            flowLayoutPanelUsers.Size = new Size(909, 670);
            flowLayoutPanelUsers.TabIndex = 0;
            flowLayoutPanelUsers.Paint += flowLayoutPanelUsers_Paint;
            // 
            // iconBack
            // 
            iconBack.BackColor = Color.Transparent;
            iconBack.Cursor = Cursors.Hand;
            iconBack.CustomizableEdges = customizableEdges1;
            iconBack.Image = (Image)resources.GetObject("iconBack.Image");
            iconBack.ImageRotate = 0F;
            iconBack.Location = new Point(50, 24);
            iconBack.Name = "iconBack";
            iconBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            iconBack.Size = new Size(40, 40);
            iconBack.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBack.TabIndex = 18;
            iconBack.TabStop = false;
            iconBack.Click += iconBack_Click;
            // 
            // Persons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1034, 711);
            Controls.Add(iconBack);
            Controls.Add(flowLayoutPanelUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Persons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Persons";
            Load += Persons_Load;
            ((System.ComponentModel.ISupportInitialize)iconBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelUsers;
        private Guna.UI2.WinForms.Guna2PictureBox iconBack;
    }
}