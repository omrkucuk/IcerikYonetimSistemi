namespace IcerikUretimSistemi.UI.Forms
{
    partial class Profiller
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
            listBoxUsers = new ListBox();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(114, 32);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(509, 334);
            listBoxUsers.TabIndex = 0;
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged_1;
            // 
            // Profiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxUsers);
            Name = "Profiller";
            Text = "Profiller";
            Load += Profiller_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
    }
}