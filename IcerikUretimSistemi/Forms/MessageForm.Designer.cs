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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 25;
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.Location = new Point(39, 32);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(287, 609);
            guna2ContainerControl1.TabIndex = 0;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.BorderRadius = 25;
            guna2ContainerControl2.CustomizableEdges = customizableEdges3;
            guna2ContainerControl2.Location = new Point(348, 32);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ContainerControl2.Size = new Size(669, 609);
            guna2ContainerControl2.TabIndex = 1;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 711);
            Controls.Add(guna2ContainerControl2);
            Controls.Add(guna2ContainerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageForm";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
    }
}