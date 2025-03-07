namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class OpenMessage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            guna2ContainerControl1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.Transparent;
            guna2TextBox1.BorderRadius = 15;
            guna2TextBox1.BorderThickness = 0;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "Başarılı Bir Şekilde Giriş Yaptınız";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.Enabled = false;
            guna2TextBox1.FillColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            guna2TextBox1.ForeColor = Color.White;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(63, 60);
            guna2TextBox1.Margin = new Padding(4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.ReadOnly = true;
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(293, 62);
            guna2TextBox1.TabIndex = 0;
            guna2TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 35;
            guna2ContainerControl1.Controls.Add(guna2TextBox1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges3;
            guna2ContainerControl1.Dock = DockStyle.Fill;
            guna2ContainerControl1.Location = new Point(0, 0);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ContainerControl1.Size = new Size(412, 190);
            guna2ContainerControl1.TabIndex = 1;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // OpenMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ContainerControl1);
            Name = "OpenMessage";
            Size = new Size(412, 190);
            guna2ContainerControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
    }
}
