namespace IcerikUretimSistemi.UI.Forms
{
    partial class SignUpForm
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
            btnSignUp = new Button();
            x = new TextBox();
            txtKayitUserName = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            txtGirisKullanıcıAdi = new TextBox();
            txtGirisSifre = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            groupBox2 = new GroupBox();
            ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            txtKayitSifre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Ivory;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.FromArgb(64, 64, 64);
            btnSignUp.Location = new Point(105, 390);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(245, 43);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Kayıt Ol";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // x
            // 
            x.BackColor = SystemColors.InactiveCaption;
            x.BorderStyle = BorderStyle.None;
            x.Location = new Point(141, 127);
            x.Multiline = true;
            x.Name = "x";
            x.Size = new Size(270, 34);
            x.TabIndex = 1;
            // 
            // txtKayitUserName
            // 
            txtKayitUserName.BackColor = SystemColors.InactiveCaption;
            txtKayitUserName.BorderStyle = BorderStyle.None;
            txtKayitUserName.Location = new Point(141, 198);
            txtKayitUserName.Multiline = true;
            txtKayitUserName.Name = "txtKayitUserName";
            txtKayitUserName.Size = new Size(270, 34);
            txtKayitUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11F);
            lblUserName.Location = new Point(15, 46);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(221, 25);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Hesabın yok mu? Kaydol.";
            lblUserName.Click += lblUserName_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(62, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(43, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(269, 188);
            label1.Name = "label1";
            label1.Size = new Size(608, 67);
            label1.TabIndex = 6;
            label1.Text = "Contentify'e Hoşgeldiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(381, 255);
            label2.Name = "label2";
            label2.Size = new Size(370, 41);
            label2.TabIndex = 7;
            label2.Text = "\"İçeriğin gücünü keşfedin\"";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Ivory;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.FromArgb(64, 64, 64);
            btnLogin.Location = new Point(105, 390);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(245, 43);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtGirisKullanıcıAdi
            // 
            txtGirisKullanıcıAdi.BackColor = SystemColors.InactiveCaption;
            txtGirisKullanıcıAdi.BorderStyle = BorderStyle.None;
            txtGirisKullanıcıAdi.Location = new Point(135, 118);
            txtGirisKullanıcıAdi.Multiline = true;
            txtGirisKullanıcıAdi.Name = "txtGirisKullanıcıAdi";
            txtGirisKullanıcıAdi.Size = new Size(270, 34);
            txtGirisKullanıcıAdi.TabIndex = 9;
            // 
            // txtGirisSifre
            // 
            txtGirisSifre.BackColor = SystemColors.InactiveCaption;
            txtGirisSifre.BorderStyle = BorderStyle.None;
            txtGirisSifre.Location = new Point(135, 198);
            txtGirisSifre.Multiline = true;
            txtGirisSifre.Name = "txtGirisSifre";
            txtGirisSifre.Size = new Size(270, 34);
            txtGirisSifre.TabIndex = 10;
            txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 13;
            label3.Text = "Kullanıcı Adı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ıconPictureBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGirisSifre);
            groupBox1.Controls.Add(txtGirisKullanıcıAdi);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(586, 317);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(445, 509);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Yap";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(8, 46);
            label7.Name = "label7";
            label7.Size = new Size(407, 25);
            label7.TabIndex = 14;
            label7.Text = "Giriş yapın, içeriklerinizi düzenlemeye başlayın.";
            // 
            // ıconPictureBox2
            // 
            ıconPictureBox2.BackColor = Color.AliceBlue;
            ıconPictureBox2.ForeColor = SystemColors.ControlText;
            ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            ıconPictureBox2.IconColor = SystemColors.ControlText;
            ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox2.IconSize = 33;
            ıconPictureBox2.Location = new Point(12, 196);
            ıconPictureBox2.Margin = new Padding(3, 4, 3, 4);
            ıconPictureBox2.Name = "ıconPictureBox2";
            ıconPictureBox2.Size = new Size(33, 36);
            ıconPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            ıconPictureBox2.TabIndex = 12;
            ıconPictureBox2.TabStop = false;
            ıconPictureBox2.Click += ıconPictureBox2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ıconPictureBox3);
            groupBox2.Controls.Add(txtKayitSifre);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lblUserName);
            groupBox2.Controls.Add(txtKayitUserName);
            groupBox2.Controls.Add(x);
            groupBox2.Controls.Add(btnSignUp);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.Location = new Point(46, 317);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(445, 509);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kayıt Ol";
            // 
            // ıconPictureBox3
            // 
            ıconPictureBox3.BackColor = Color.AliceBlue;
            ıconPictureBox3.ForeColor = SystemColors.ControlText;
            ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            ıconPictureBox3.IconColor = SystemColors.ControlText;
            ıconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox3.IconSize = 33;
            ıconPictureBox3.Location = new Point(18, 284);
            ıconPictureBox3.Margin = new Padding(3, 4, 3, 4);
            ıconPictureBox3.Name = "ıconPictureBox3";
            ıconPictureBox3.Size = new Size(33, 36);
            ıconPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            ıconPictureBox3.TabIndex = 13;
            ıconPictureBox3.TabStop = false;
            // 
            // txtKayitSifre
            // 
            txtKayitSifre.BackColor = SystemColors.InactiveCaption;
            txtKayitSifre.BorderStyle = BorderStyle.None;
            txtKayitSifre.Location = new Point(141, 282);
            txtKayitSifre.Margin = new Padding(3, 4, 3, 4);
            txtKayitSifre.Multiline = true;
            txtKayitSifre.Name = "txtKayitSifre";
            txtKayitSifre.Size = new Size(270, 34);
            txtKayitSifre.TabIndex = 7;
            txtKayitSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(15, 206);
            label6.Name = "label6";
            label6.Size = new Size(103, 23);
            label6.TabIndex = 6;
            label6.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(57, 291);
            label5.Name = "label5";
            label5.Size = new Size(43, 23);
            label5.TabIndex = 5;
            label5.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(18, 128);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 4;
            label4.Text = "E-posta";
            label4.Click += label4_Click;
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = Color.AliceBlue;
            ıconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            ıconPictureBox1.ForeColor = SystemColors.ControlText;
            ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconPictureBox1.IconColor = SystemColors.ControlText;
            ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox1.IconSize = 192;
            ıconPictureBox1.Location = new Point(439, 13);
            ıconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            ıconPictureBox1.Name = "ıconPictureBox1";
            ıconPictureBox1.Size = new Size(252, 192);
            ıconPictureBox1.TabIndex = 15;
            ıconPictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 853);
            Controls.Add(label1);
            Controls.Add(ıconPictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "SignUpForm";
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox x;
        private TextBox txtKayitUserName;
        private Label lblUserName;
        private Label lblPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox txtGirisKullanıcıAdi;
        private TextBox txtGirisSifre;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtKayitSifre;
        private Label label6;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private Label label7;
    }
}