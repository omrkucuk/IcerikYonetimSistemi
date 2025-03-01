namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class PostCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCreator = new Label();
            lblTitle = new Label();
            lblContent = new Label();
            lblDate = new Label();
            btnLike = new Button();
            btnComment = new Button();
            SuspendLayout();
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Location = new Point(51, 36);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(38, 15);
            lblCreator.TabIndex = 0;
            lblCreator.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(130, 70);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(130, 108);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(38, 15);
            lblContent.TabIndex = 0;
            lblContent.Text = "label1";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(130, 150);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 0;
            lblDate.Text = "label1";
            // 
            // btnLike
            // 
            btnLike.Location = new Point(65, 188);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(75, 23);
            btnLike.TabIndex = 1;
            btnLike.Text = "button1";
            btnLike.UseVisualStyleBackColor = true;
            // 
            // btnComment
            // 
            btnComment.Location = new Point(208, 188);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(75, 23);
            btnComment.TabIndex = 1;
            btnComment.Text = "button1";
            btnComment.UseVisualStyleBackColor = true;
            // 
            // PostCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnComment);
            Controls.Add(btnLike);
            Controls.Add(lblDate);
            Controls.Add(lblContent);
            Controls.Add(lblTitle);
            Controls.Add(lblCreator);
            Name = "PostCard";
            Size = new Size(440, 233);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreator;
        private Label lblTitle;
        private Label lblContent;
        private Label lblDate;
        private Button btnLike;
        private Button btnComment;
    }
}
