namespace EmailSystem.Client
{
    partial class MainEmailForm
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
            this.sendEmailBtn = new System.Windows.Forms.Button();
            this.contentTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.recipientCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sendEmailBtn
            // 
            this.sendEmailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendEmailBtn.AutoEllipsis = true;
            this.sendEmailBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendEmailBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendEmailBtn.Location = new System.Drawing.Point(614, 466);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Size = new System.Drawing.Size(173, 51);
            this.sendEmailBtn.TabIndex = 0;
            this.sendEmailBtn.Text = "Отправить";
            this.sendEmailBtn.UseVisualStyleBackColor = true;
            this.sendEmailBtn.Click += new System.EventHandler(this.sendEmailBtn_Click);
            // 
            // contentTB
            // 
            this.contentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contentTB.Location = new System.Drawing.Point(12, 103);
            this.contentTB.Multiline = true;
            this.contentTB.Name = "contentTB";
            this.contentTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTB.Size = new System.Drawing.Size(775, 357);
            this.contentTB.TabIndex = 1;
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(536, 39);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(228, 27);
            this.nameTB.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(461, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Название:";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Location = new System.Drawing.Point(12, 42);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(93, 20);
            this.recipientLabel.TabIndex = 4;
            this.recipientLabel.Text = "Получатель:";
            // 
            // recipientCB
            // 
            this.recipientCB.FormattingEnabled = true;
            this.recipientCB.Location = new System.Drawing.Point(111, 42);
            this.recipientCB.Name = "recipientCB";
            this.recipientCB.Size = new System.Drawing.Size(228, 28);
            this.recipientCB.TabIndex = 5;
            // 
            // MainEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 529);
            this.Controls.Add(this.recipientCB);
            this.Controls.Add(this.recipientLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.contentTB);
            this.Controls.Add(this.sendEmailBtn);
            this.Name = "MainEmailForm";
            this.Text = "MainEmailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendEmailBtn;
        private System.Windows.Forms.TextBox contentTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.ComboBox recipientCB;
    }
}