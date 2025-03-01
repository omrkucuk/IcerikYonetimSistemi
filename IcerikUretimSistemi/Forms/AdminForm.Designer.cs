namespace IcerikUretimSistemi.UI.Forms
{
    partial class AdminForm
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
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblPost = new Label();
            lblFollower = new Label();
            lblBlock = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            ıconButton3 = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            lblName = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Location = new Point(650, 40);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 32);
            dateTimePicker1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(29, 40);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 93);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(107, 103);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 3;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // lblPost
            // 
            lblPost.BackColor = Color.AliceBlue;
            lblPost.BorderStyle = BorderStyle.FixedSingle;
            lblPost.Font = new Font("Segoe UI", 11F);
            lblPost.Location = new Point(112, 185);
            lblPost.Name = "lblPost";
            lblPost.Size = new Size(172, 95);
            lblPost.TabIndex = 4;
            lblPost.Text = "Gönderiler";
            lblPost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFollower
            // 
            lblFollower.BorderStyle = BorderStyle.FixedSingle;
            lblFollower.Font = new Font("Segoe UI", 11F);
            lblFollower.Location = new Point(468, 185);
            lblFollower.Name = "lblFollower";
            lblFollower.Size = new Size(172, 95);
            lblFollower.TabIndex = 5;
            lblFollower.Text = "Takipçiler";
            lblFollower.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlock
            // 
            lblBlock.BorderStyle = BorderStyle.FixedSingle;
            lblBlock.Font = new Font("Segoe UI", 11F);
            lblBlock.Location = new Point(824, 185);
            lblBlock.Name = "lblBlock";
            lblBlock.Size = new Size(172, 95);
            lblBlock.TabIndex = 6;
            lblBlock.Text = "Engellenenler";
            lblBlock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(29, 317);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 447);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ıconButton3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblName);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(471, 109);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // ıconButton3
            // 
            ıconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton3.IconColor = Color.Black;
            ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton3.Location = new Point(321, 33);
            ıconButton3.Margin = new Padding(3, 4, 3, 4);
            ıconButton3.Name = "ıconButton3";
            ıconButton3.Size = new Size(104, 38);
            ıconButton3.TabIndex = 2;
            ıconButton3.Text = "Takip Et";
            ıconButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 80);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(79, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(158, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Kullanıcı Adı";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(572, 317);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 447);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(ıconButton1);
            panel4.Controls.Add(ıconButton2);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(4, 4);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(458, 261);
            panel4.TabIndex = 10;
            // 
            // ıconButton1
            // 
            ıconButton1.Cursor = Cursors.Hand;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Comment;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 28;
            ıconButton1.Location = new Point(329, 208);
            ıconButton1.Margin = new Padding(3, 4, 3, 4);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(33, 36);
            ıconButton1.TabIndex = 6;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // ıconButton2
            // 
            ıconButton2.BackColor = Color.Transparent;
            ıconButton2.Cursor = Cursors.Hand;
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Heart;
            ıconButton2.IconColor = Color.Black;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.IconSize = 25;
            ıconButton2.Location = new Point(214, 208);
            ıconButton2.Margin = new Padding(3, 4, 3, 4);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(33, 36);
            ıconButton2.TabIndex = 5;
            ıconButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(361, 215);
            label2.Name = "label2";
            label2.Size = new Size(79, 29);
            label2.TabIndex = 4;
            label2.Text = "Yorum";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(247, 215);
            label3.Name = "label3";
            label3.Size = new Size(81, 29);
            label3.TabIndex = 3;
            label3.Text = "Beğeni";
            // 
            // label4
            // 
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(14, 79);
            label4.Name = "label4";
            label4.Size = new Size(426, 111);
            label4.TabIndex = 2;
            label4.Text = "İçerik";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(14, 44);
            label5.Name = "label5";
            label5.Size = new Size(426, 40);
            label5.TabIndex = 1;
            label5.Text = "Başlık";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(14, 8);
            label6.Name = "label6";
            label6.Size = new Size(426, 31);
            label6.TabIndex = 0;
            label6.Text = "Kullanıcı Adı";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1082, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblBlock);
            Controls.Add(lblFollower);
            Controls.Add(lblPost);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblPost;
        private Label lblFollower;
        private Label lblBlock;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label lblName;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconButton ıconButton3;
    }
}