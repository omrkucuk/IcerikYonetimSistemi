namespace IcerikUretimSistemi.UI.Forms
{
    partial class Persons
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
            flowLayoutPanelUsers = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelUsers
            // 
            flowLayoutPanelUsers.AutoScroll = true;
            flowLayoutPanelUsers.Location = new Point(104, 12);
            flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            flowLayoutPanelUsers.Size = new Size(909, 670);
            flowLayoutPanelUsers.TabIndex = 0;
            // 
            // Persons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1034, 711);
            Controls.Add(flowLayoutPanelUsers);
            Name = "Persons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Persons";
            Load += Persons_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelUsers;
    }
}