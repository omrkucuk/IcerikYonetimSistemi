namespace IcerikUretimSistemi.UI.Forms
{
    partial class Admin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnDate = new Guna.UI2.WinForms.Guna2Button();
            dataGrid = new DataGridView();
            dataGridComment = new DataGridView();
            iconBack = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBack).BeginInit();
            SuspendLayout();
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(76, 33);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(674, 36);
            guna2TextBox1.TabIndex = 1;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // dateTime
            // 
            dateTime.Checked = true;
            dateTime.CustomizableEdges = customizableEdges3;
            dateTime.Font = new Font("Segoe UI", 9F);
            dateTime.Format = DateTimePickerFormat.Long;
            dateTime.Location = new Point(756, 33);
            dateTime.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTime.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTime.Name = "dateTime";
            dateTime.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dateTime.Size = new Size(200, 36);
            dateTime.TabIndex = 2;
            dateTime.Value = new DateTime(2025, 3, 5, 12, 47, 5, 854);
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // btnDate
            // 
            btnDate.CustomizableEdges = customizableEdges5;
            btnDate.DisabledState.BorderColor = Color.DarkGray;
            btnDate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDate.Font = new Font("Segoe UI", 9F);
            btnDate.ForeColor = Color.White;
            btnDate.Location = new Point(962, 33);
            btnDate.Name = "btnDate";
            btnDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDate.Size = new Size(149, 36);
            btnDate.TabIndex = 3;
            btnDate.Text = "Tarihe Göre Getir";
            btnDate.Click += btnDate_Click;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.BackgroundColor = Color.AliceBlue;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(76, 115);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1035, 301);
            dataGrid.TabIndex = 4;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // dataGridComment
            // 
            dataGridComment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridComment.BackgroundColor = Color.AliceBlue;
            dataGridComment.BorderStyle = BorderStyle.None;
            dataGridComment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridComment.Location = new Point(76, 422);
            dataGridComment.Name = "dataGridComment";
            dataGridComment.Size = new Size(1035, 284);
            dataGridComment.TabIndex = 5;
            dataGridComment.CellContentClick += dataGridComment_CellContentClick;
            // 
            // iconBack
            // 
            iconBack.BackColor = Color.Transparent;
            iconBack.Cursor = Cursors.Hand;
            iconBack.CustomizableEdges = customizableEdges7;
            iconBack.Image = (Image)resources.GetObject("iconBack.Image");
            iconBack.ImageRotate = 0F;
            iconBack.Location = new Point(12, 33);
            iconBack.Name = "iconBack";
            iconBack.ShadowDecoration.CustomizableEdges = customizableEdges8;
            iconBack.Size = new Size(40, 40);
            iconBack.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBack.TabIndex = 18;
            iconBack.TabStop = false;
            iconBack.Click += iconBack_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1184, 761);
            Controls.Add(iconBack);
            Controls.Add(dataGridComment);
            Controls.Add(dataGrid);
            Controls.Add(btnDate);
            Controls.Add(dateTime);
            Controls.Add(guna2TextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComment).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBack).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTime;
        private Guna.UI2.WinForms.Guna2Button btnDate;
        private DataGridView dataGrid;
        private DataGridView dataGridComment;
        private Guna.UI2.WinForms.Guna2PictureBox iconBack;
    }
}