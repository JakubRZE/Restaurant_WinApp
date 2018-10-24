namespace RestaurantApp
{
    partial class DefaultControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SignInLink = new System.Windows.Forms.LinkLabel();
            this.newAccountLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(13, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(635, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stay up-to-date with new offers!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(18, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "and";
            // 
            // SignInLink
            // 
            this.SignInLink.ActiveLinkColor = System.Drawing.Color.Goldenrod;
            this.SignInLink.AutoSize = true;
            this.SignInLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInLink.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignInLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.SignInLink.LinkColor = System.Drawing.Color.Gold;
            this.SignInLink.Location = new System.Drawing.Point(0, 0);
            this.SignInLink.Name = "SignInLink";
            this.SignInLink.Size = new System.Drawing.Size(414, 136);
            this.SignInLink.TabIndex = 7;
            this.SignInLink.TabStop = true;
            this.SignInLink.Text = "Sign in";
            this.SignInLink.VisitedLinkColor = System.Drawing.Color.Gold;
            this.SignInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLink_LinkClicked);
            this.SignInLink.MouseEnter += new System.EventHandler(this.SignInLink_MouseEnter);
            this.SignInLink.MouseLeave += new System.EventHandler(this.SignInLink_MouseLeave);
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.ActiveLinkColor = System.Drawing.Color.Goldenrod;
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAccountLabel.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newAccountLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.newAccountLabel.LinkColor = System.Drawing.Color.Gold;
            this.newAccountLabel.Location = new System.Drawing.Point(13, 165);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(558, 68);
            this.newAccountLabel.TabIndex = 8;
            this.newAccountLabel.TabStop = true;
            this.newAccountLabel.Text = "Create new account";
            this.newAccountLabel.VisitedLinkColor = System.Drawing.Color.Gold;
            this.newAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newAccountLabel_LinkClicked);
            this.newAccountLabel.MouseEnter += new System.EventHandler(this.newAccountLabel_MouseEnter);
            this.newAccountLabel.MouseLeave += new System.EventHandler(this.newAccountLabel_MouseLeave);
            // 
            // DefaultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newAccountLabel);
            this.Controls.Add(this.SignInLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "DefaultControl";
            this.Size = new System.Drawing.Size(654, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel SignInLink;
        private System.Windows.Forms.LinkLabel newAccountLabel;
    }
}
