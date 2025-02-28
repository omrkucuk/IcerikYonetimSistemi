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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox3).BeginInit();
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
            // txtUserName
            // 
            txtUserName.Location = new Point(108, 88);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(227, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(108, 144);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
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
            label1.Location = new Point(241, 47);
            label1.Name = "label1";
            label1.Size = new Size(402, 41);
            label1.TabIndex = 6;
            label1.Text = "Contentify'e Hoşgeldiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(300, 97);
            label2.Name = "label2";
            label2.Size = new Size(287, 28);
            label2.TabIndex = 7;
            label2.Text = "\"İçeriğin gücünü keşfedin\"";
            // 
            // button1
            // 
            button1.Location = new Point(223, 244);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 43);
            button1.TabIndex = 8;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 85);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 164);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 23);
            textBox2.TabIndex = 10;
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
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Location = new Point(467, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 382);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ıconPictureBox3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lblUserName);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.Controls.Add(btnSignUp);
            groupBox2.Location = new Point(60, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 382);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = Color.Transparent;
            ıconPictureBox1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_02_28_at_12_33_16;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 207);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Şifre";
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
            // textBox3
            // 
            textBox3.Location = new Point(108, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 23);
            textBox3.TabIndex = 7;
            // 
            // ıconPictureBox2
            // 
            ıconPictureBox2.BackColor = SystemColors.Control;
            ıconPictureBox2.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_02_28_at_12_33_16;
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
            // ıconPictureBox3
            // 
            ıconPictureBox3.BackColor = SystemColors.Control;
            ıconPictureBox3.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_02_28_at_12_33_16;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 38);
            label7.Name = "label7";
            label7.Size = new Size(252, 15);
            label7.TabIndex = 14;
            label7.Text = "Giriş yapın, içeriklerinizi düzenlemeye başlayın.";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(847, 569);
            Controls.Add(ıconPictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private Label label7;
    }
}