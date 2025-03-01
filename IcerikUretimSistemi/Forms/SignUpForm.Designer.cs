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
            btnSignUp.Location = new Point(226, 244);
            btnSignUp.Margin = new Padding(3, 2, 3, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(109, 43);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Kayıt Ol";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // x
            // 
            x.Location = new Point(108, 88);
            x.Margin = new Padding(3, 2, 3, 2);
            x.Name = "x";
            x.Size = new Size(227, 23);
            x.TabIndex = 1;
            // 
            // txtKayitUserName
            // 
            txtKayitUserName.Location = new Point(108, 144);
            txtKayitUserName.Margin = new Padding(3, 2, 3, 2);
            txtKayitUserName.Name = "txtKayitUserName";
            txtKayitUserName.Size = new Size(227, 23);
            txtKayitUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(35, 47);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(140, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Hesabın yok mu? Kaydol.";
            lblUserName.Click += lblUserName_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(61, 172);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(30, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 51);
            label1.Name = "label1";
            label1.Size = new Size(402, 41);
            label1.TabIndex = 6;
            label1.Text = "Contentify'e Hoşgeldiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(388, 101);
            label2.Name = "label2";
            label2.Size = new Size(287, 28);
            label2.TabIndex = 7;
            label2.Text = "\"İçeriğin gücünü keşfedin\"";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(223, 244);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 43);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtGirisKullanıcıAdi
            // 
            txtGirisKullanıcıAdi.Location = new Point(105, 85);
            txtGirisKullanıcıAdi.Margin = new Padding(3, 2, 3, 2);
            txtGirisKullanıcıAdi.Name = "txtGirisKullanıcıAdi";
            txtGirisKullanıcıAdi.Size = new Size(227, 23);
            txtGirisKullanıcıAdi.TabIndex = 9;
            // 
            // txtGirisSifre
            // 
            txtGirisSifre.Location = new Point(105, 164);
            txtGirisSifre.Margin = new Padding(3, 2, 3, 2);
            txtGirisSifre.Name = "txtGirisSifre";
            txtGirisSifre.Size = new Size(227, 23);
            txtGirisSifre.TabIndex = 10;
            txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
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
            groupBox1.Location = new Point(590, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 382);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 38);
            label7.Name = "label7";
            label7.Size = new Size(252, 15);
            label7.TabIndex = 14;
            label7.Text = "Giriş yapın, içeriklerinizi düzenlemeye başlayın.";
            // 
            // ıconPictureBox2
            // 
            ıconPictureBox2.BackColor = SystemColors.Control;
            ıconPictureBox2.ForeColor = SystemColors.ControlText;
            ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            ıconPictureBox2.IconColor = SystemColors.ControlText;
            ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox2.IconSize = 27;
            ıconPictureBox2.Location = new Point(26, 164);
            ıconPictureBox2.Name = "ıconPictureBox2";
            ıconPictureBox2.Size = new Size(29, 27);
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
            groupBox2.Location = new Point(60, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 382);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // ıconPictureBox3
            // 
            ıconPictureBox3.BackColor = SystemColors.Control;
            ıconPictureBox3.ForeColor = SystemColors.ControlText;
            ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            ıconPictureBox3.IconColor = SystemColors.ControlText;
            ıconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox3.IconSize = 27;
            ıconPictureBox3.Location = new Point(37, 200);
            ıconPictureBox3.Name = "ıconPictureBox3";
            ıconPictureBox3.Size = new Size(29, 27);
            ıconPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            ıconPictureBox3.TabIndex = 13;
            ıconPictureBox3.TabStop = false;
            // 
            // txtKayitSifre
            // 
            txtKayitSifre.Location = new Point(108, 204);
            txtKayitSifre.Name = "txtKayitSifre";
            txtKayitSifre.Size = new Size(227, 23);
            txtKayitSifre.TabIndex = 7;
            txtKayitSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 147);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 6;
            label6.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 207);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 91);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "E-posta";
            label4.Click += label4_Click;
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = Color.Transparent;
            ıconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            ıconPictureBox1.ForeColor = SystemColors.ControlText;
            ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconPictureBox1.IconColor = SystemColors.ControlText;
            ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox1.IconSize = 135;
            ıconPictureBox1.Location = new Point(31, 24);
            ıconPictureBox1.Name = "ıconPictureBox1";
            ıconPictureBox1.Size = new Size(204, 135);
            ıconPictureBox1.TabIndex = 15;
            ıconPictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1014, 581);
            Controls.Add(ıconPictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
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