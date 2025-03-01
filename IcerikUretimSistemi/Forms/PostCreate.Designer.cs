namespace IcerikUretimSistemi.UI.Forms
{
    partial class PostCreate
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
            txtTitle = new TextBox();
            txtContent = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(240, 52);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(283, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(240, 162);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(283, 150);
            txtContent.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(240, 343);
            button1.Name = "button1";
            button1.Size = new Size(283, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PostCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 410);
            Controls.Add(button1);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Name = "PostCreate";
            Text = "PostCreate";
            Load += PostCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtContent;
        private Button button1;
    }
}