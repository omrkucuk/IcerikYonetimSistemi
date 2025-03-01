namespace IcerikUretimSistemi.UI.Forms
{
    partial class ProfilePage
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
            txtUserName = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtUserName.Location = new Point(48, 47);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(51, 21);
            txtUserName.TabIndex = 0;
            txtUserName.Text = "label1";
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 581);
            Controls.Add(txtUserName);
            Name = "ProfilePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfilePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUserName;
    }
}