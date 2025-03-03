namespace IcerikUretimSistemi.UI.Forms
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            flowLayoutPersons = new FlowLayoutPanel();
            iconBack = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBack).BeginInit();
            SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 25;
            guna2ContainerControl1.Controls.Add(flowLayoutPersons);
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.FillColor = Color.FromArgb(192, 192, 255);
            guna2ContainerControl1.Location = new Point(12, 68);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(300, 665);
            guna2ContainerControl1.TabIndex = 0;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // flowLayoutPersons
            // 
            flowLayoutPersons.AutoScroll = true;
            flowLayoutPersons.BackColor = Color.Transparent;
            flowLayoutPersons.Location = new Point(3, 14);
            flowLayoutPersons.Name = "flowLayoutPersons";
            flowLayoutPersons.Size = new Size(316, 656);
            flowLayoutPersons.TabIndex = 0;
            // 
            // iconBack
            // 
            iconBack.BackColor = Color.Transparent;
            iconBack.Cursor = Cursors.Hand;
            iconBack.CustomizableEdges = customizableEdges3;
            iconBack.Image = (Image)resources.GetObject("iconBack.Image");
            iconBack.ImageRotate = 0F;
            iconBack.Location = new Point(15, 12);
            iconBack.Name = "iconBack";
            iconBack.ShadowDecoration.CustomizableEdges = customizableEdges4;
            iconBack.Size = new Size(40, 40);
            iconBack.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBack.TabIndex = 19;
            iconBack.TabStop = false;
            iconBack.Click += iconBack_Click;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 750);
            Controls.Add(iconBack);
            Controls.Add(guna2ContainerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageForm";
            Load += MessageForm_Load;
            guna2ContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private FlowLayoutPanel flowLayoutPersons;
        private Guna.UI2.WinForms.Guna2PictureBox iconBack;
    }
}