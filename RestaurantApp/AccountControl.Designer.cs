namespace RestaurantApp
{
    partial class AccountControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountControl));
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.changeMailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.changePswLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mailGroupBox = new System.Windows.Forms.GroupBox();
            this.exitMailPictureBox = new System.Windows.Forms.PictureBox();
            this.changeEmialBtn = new System.Windows.Forms.Button();
            this.repNewEmialtextBox = new System.Windows.Forms.TextBox();
            this.newEmailtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pswGroupBox = new System.Windows.Forms.GroupBox();
            this.exitPswPictureBox = new System.Windows.Forms.PictureBox();
            this.confNewPswtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changePswBtn = new System.Windows.Forms.Button();
            this.newPswtextBox = new System.Windows.Forms.TextBox();
            this.oldPswtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.userMailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.mailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitMailPictureBox)).BeginInit();
            this.pswGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPswPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(57, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are logged as:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.userLabel.Location = new System.Drawing.Point(56, 63);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(242, 52);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "user Name";
            // 
            // changeMailLinkLabel
            // 
            this.changeMailLinkLabel.ActiveLinkColor = System.Drawing.Color.DarkGoldenrod;
            this.changeMailLinkLabel.AutoSize = true;
            this.changeMailLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeMailLinkLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeMailLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.changeMailLinkLabel.LinkColor = System.Drawing.Color.Goldenrod;
            this.changeMailLinkLabel.Location = new System.Drawing.Point(23, 42);
            this.changeMailLinkLabel.Name = "changeMailLinkLabel";
            this.changeMailLinkLabel.Size = new System.Drawing.Size(317, 30);
            this.changeMailLinkLabel.TabIndex = 2;
            this.changeMailLinkLabel.TabStop = true;
            this.changeMailLinkLabel.Text = "Change your adress e-mail";
            this.changeMailLinkLabel.VisitedLinkColor = System.Drawing.Color.Goldenrod;
            this.changeMailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeMailLinkLabel_LinkClicked);
            // 
            // changePswLinkLabel
            // 
            this.changePswLinkLabel.ActiveLinkColor = System.Drawing.Color.DarkGoldenrod;
            this.changePswLinkLabel.AutoSize = true;
            this.changePswLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePswLinkLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changePswLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.changePswLinkLabel.LinkColor = System.Drawing.Color.Goldenrod;
            this.changePswLinkLabel.Location = new System.Drawing.Point(23, 93);
            this.changePswLinkLabel.Name = "changePswLinkLabel";
            this.changePswLinkLabel.Size = new System.Drawing.Size(274, 30);
            this.changePswLinkLabel.TabIndex = 3;
            this.changePswLinkLabel.TabStop = true;
            this.changePswLinkLabel.Text = "Change your password";
            this.changePswLinkLabel.VisitedLinkColor = System.Drawing.Color.Goldenrod;
            this.changePswLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePswLinkLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeMailLinkLabel);
            this.groupBox1.Controls.Add(this.changePswLinkLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(75, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage your account";
            // 
            // mailGroupBox
            // 
            this.mailGroupBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.mailGroupBox.Controls.Add(this.exitMailPictureBox);
            this.mailGroupBox.Controls.Add(this.changeEmialBtn);
            this.mailGroupBox.Controls.Add(this.repNewEmialtextBox);
            this.mailGroupBox.Controls.Add(this.newEmailtextBox);
            this.mailGroupBox.Controls.Add(this.label3);
            this.mailGroupBox.Controls.Add(this.label2);
            this.mailGroupBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mailGroupBox.Location = new System.Drawing.Point(103, 48);
            this.mailGroupBox.Name = "mailGroupBox";
            this.mailGroupBox.Size = new System.Drawing.Size(456, 313);
            this.mailGroupBox.TabIndex = 0;
            this.mailGroupBox.TabStop = false;
            this.mailGroupBox.Text = "Email changing";
            this.mailGroupBox.Visible = false;
            // 
            // exitMailPictureBox
            // 
            this.exitMailPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitMailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitMailPictureBox.Image")));
            this.exitMailPictureBox.Location = new System.Drawing.Point(426, 0);
            this.exitMailPictureBox.Name = "exitMailPictureBox";
            this.exitMailPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitMailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitMailPictureBox.TabIndex = 5;
            this.exitMailPictureBox.TabStop = false;
            this.exitMailPictureBox.Click += new System.EventHandler(this.exitMailPictureBox_Click);
            // 
            // changeEmialBtn
            // 
            this.changeEmialBtn.ForeColor = System.Drawing.Color.Olive;
            this.changeEmialBtn.Location = new System.Drawing.Point(145, 247);
            this.changeEmialBtn.Name = "changeEmialBtn";
            this.changeEmialBtn.Size = new System.Drawing.Size(152, 42);
            this.changeEmialBtn.TabIndex = 4;
            this.changeEmialBtn.Text = "Change!";
            this.changeEmialBtn.UseVisualStyleBackColor = true;
            this.changeEmialBtn.Click += new System.EventHandler(this.changeEmialBtn_Click);
            // 
            // repNewEmialtextBox
            // 
            this.repNewEmialtextBox.Location = new System.Drawing.Point(31, 171);
            this.repNewEmialtextBox.Name = "repNewEmialtextBox";
            this.repNewEmialtextBox.Size = new System.Drawing.Size(393, 30);
            this.repNewEmialtextBox.TabIndex = 3;
            // 
            // newEmailtextBox
            // 
            this.newEmailtextBox.Location = new System.Drawing.Point(31, 94);
            this.newEmailtextBox.Name = "newEmailtextBox";
            this.newEmailtextBox.Size = new System.Drawing.Size(393, 30);
            this.newEmailtextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Repeat new email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "New email";
            // 
            // pswGroupBox
            // 
            this.pswGroupBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.pswGroupBox.Controls.Add(this.exitPswPictureBox);
            this.pswGroupBox.Controls.Add(this.confNewPswtextBox);
            this.pswGroupBox.Controls.Add(this.label6);
            this.pswGroupBox.Controls.Add(this.changePswBtn);
            this.pswGroupBox.Controls.Add(this.newPswtextBox);
            this.pswGroupBox.Controls.Add(this.oldPswtextBox);
            this.pswGroupBox.Controls.Add(this.label4);
            this.pswGroupBox.Controls.Add(this.label5);
            this.pswGroupBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pswGroupBox.Location = new System.Drawing.Point(81, 57);
            this.pswGroupBox.Name = "pswGroupBox";
            this.pswGroupBox.Size = new System.Drawing.Size(456, 313);
            this.pswGroupBox.TabIndex = 5;
            this.pswGroupBox.TabStop = false;
            this.pswGroupBox.Text = "Password changing";
            this.pswGroupBox.Visible = false;
            // 
            // exitPswPictureBox
            // 
            this.exitPswPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPswPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPswPictureBox.Image")));
            this.exitPswPictureBox.Location = new System.Drawing.Point(426, 0);
            this.exitPswPictureBox.Name = "exitPswPictureBox";
            this.exitPswPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitPswPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitPswPictureBox.TabIndex = 7;
            this.exitPswPictureBox.TabStop = false;
            this.exitPswPictureBox.Click += new System.EventHandler(this.exitPswPictureBox_Click);
            // 
            // confNewPswtextBox
            // 
            this.confNewPswtextBox.Location = new System.Drawing.Point(226, 168);
            this.confNewPswtextBox.MaxLength = 15;
            this.confNewPswtextBox.Name = "confNewPswtextBox";
            this.confNewPswtextBox.PasswordChar = '*';
            this.confNewPswtextBox.Size = new System.Drawing.Size(198, 30);
            this.confNewPswtextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(26, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 54);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirm new \r\npassword";
            // 
            // changePswBtn
            // 
            this.changePswBtn.ForeColor = System.Drawing.Color.Olive;
            this.changePswBtn.Location = new System.Drawing.Point(145, 247);
            this.changePswBtn.Name = "changePswBtn";
            this.changePswBtn.Size = new System.Drawing.Size(152, 42);
            this.changePswBtn.TabIndex = 4;
            this.changePswBtn.Text = "Change!";
            this.changePswBtn.UseVisualStyleBackColor = true;
            this.changePswBtn.Click += new System.EventHandler(this.changePswBtn_Click);
            // 
            // newPswtextBox
            // 
            this.newPswtextBox.Location = new System.Drawing.Point(226, 116);
            this.newPswtextBox.MaxLength = 15;
            this.newPswtextBox.Name = "newPswtextBox";
            this.newPswtextBox.PasswordChar = '*';
            this.newPswtextBox.Size = new System.Drawing.Size(198, 30);
            this.newPswtextBox.TabIndex = 3;
            // 
            // oldPswtextBox
            // 
            this.oldPswtextBox.Location = new System.Drawing.Point(226, 64);
            this.oldPswtextBox.MaxLength = 15;
            this.oldPswtextBox.Name = "oldPswtextBox";
            this.oldPswtextBox.PasswordChar = '*';
            this.oldPswtextBox.Size = new System.Drawing.Size(198, 30);
            this.oldPswtextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "New password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(26, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Old password";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(60, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // userMailLabel
            // 
            this.userMailLabel.AutoSize = true;
            this.userMailLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userMailLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.userMailLabel.Location = new System.Drawing.Point(148, 141);
            this.userMailLabel.Name = "userMailLabel";
            this.userMailLabel.Size = new System.Drawing.Size(56, 27);
            this.userMailLabel.TabIndex = 7;
            this.userMailLabel.Text = "mail";
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pswGroupBox);
            this.Controls.Add(this.mailGroupBox);
            this.Controls.Add(this.userMailLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label1);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(654, 412);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mailGroupBox.ResumeLayout(false);
            this.mailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitMailPictureBox)).EndInit();
            this.pswGroupBox.ResumeLayout(false);
            this.pswGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPswPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.LinkLabel changeMailLinkLabel;
        private System.Windows.Forms.LinkLabel changePswLinkLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox mailGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeEmialBtn;
        private System.Windows.Forms.TextBox repNewEmialtextBox;
        private System.Windows.Forms.TextBox newEmailtextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox pswGroupBox;
        private System.Windows.Forms.TextBox confNewPswtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changePswBtn;
        private System.Windows.Forms.TextBox newPswtextBox;
        private System.Windows.Forms.TextBox oldPswtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox exitPswPictureBox;
        private System.Windows.Forms.PictureBox exitMailPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userMailLabel;
    }
}
