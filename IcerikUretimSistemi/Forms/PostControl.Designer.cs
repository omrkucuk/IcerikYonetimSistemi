namespace IcerikUretimSistemi.UI.Forms
{
    partial class PostControl
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
            lblTitle = new Label();
            lblContent = new Label();
            btnLike = new Button();
            btnComment = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(101, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(101, 73);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(38, 15);
            lblContent.TabIndex = 1;
            lblContent.Text = "label1";
            // 
            // btnLike
            // 
            btnLike.Location = new Point(34, 153);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(75, 23);
            btnLike.TabIndex = 2;
            btnLike.Text = "button1";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // btnComment
            // 
            btnComment.Location = new Point(153, 153);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(75, 23);
            btnComment.TabIndex = 3;
            btnComment.Text = "button1";
            btnComment.UseVisualStyleBackColor = true;
            btnComment.Click += btnComment_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(btnComment);
            groupBox1.Controls.Add(lblContent);
            groupBox1.Controls.Add(btnLike);
            groupBox1.Location = new Point(87, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 216);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // PostControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "PostControl";
            Size = new Size(437, 295);
            Load += PostControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblContent;
        private Button btnLike;
        private Button btnComment;
        private GroupBox groupBox1;
    }
}
