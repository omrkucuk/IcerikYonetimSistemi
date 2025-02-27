namespace IcerikUretimSistemi.UI.Forms
{
    partial class LoginForm
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
            lblPassword = new Label();
            lblUserName = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(52, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(52, 68);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 20);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Kullanıcı Adı";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(52, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(52, 100);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(213, 27);
            txtUserName.TabIndex = 6;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(81, 223);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Giriş Yap";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(301, 344);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnSignUp);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label lblUserName;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnSignUp;
    }
}