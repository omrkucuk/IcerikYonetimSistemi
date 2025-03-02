namespace IcerikUretimSistemi.UI.Forms.Controls
{
    partial class MessageControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            pctPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).BeginInit();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.BorderRadius = 10;
            txtMessage.CustomizableEdges = customizableEdges1;
            txtMessage.DefaultText = "";
            txtMessage.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMessage.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMessage.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMessage.ForeColor = Color.Black;
            txtMessage.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Location = new Point(115, 14);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "";
            txtMessage.SelectedText = "";
            txtMessage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMessage.Size = new Size(324, 36);
            txtMessage.TabIndex = 0;
            txtMessage.TextOffset = new Point(10, 0);
            txtMessage.WordWrap = false;
            // 
            // pctPhoto
            // 
            pctPhoto.ImageRotate = 0F;
            pctPhoto.Location = new Point(20, 2);
            pctPhoto.Name = "pctPhoto";
            pctPhoto.ShadowDecoration.CustomizableEdges = customizableEdges3;
            pctPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pctPhoto.Size = new Size(60, 60);
            pctPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPhoto.TabIndex = 1;
            pctPhoto.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Location = new Point(451, 23);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(97, 17);
            lblDate.TabIndex = 2;
            lblDate.Text = "guna2HtmlLabel1";
            // 
            // MessageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lblDate);
            Controls.Add(pctPhoto);
            Controls.Add(txtMessage);
            Name = "MessageControl";
            Size = new Size(555, 65);
            Load += MessageControl_Load;
            ((System.ComponentModel.ISupportInitialize)pctPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctPhoto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
    }
}
