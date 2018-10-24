namespace RestaurantApp
{
    partial class LoginControl
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
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pswtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.pswLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noAccountlinkLabel = new System.Windows.Forms.LinkLabel();
            this.registergroupBox = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regSubButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.haveAccountlinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginBox.SuspendLayout();
            this.registergroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Controls.Add(this.button1);
            this.loginBox.Controls.Add(this.pswtextBox);
            this.loginBox.Controls.Add(this.nametextBox);
            this.loginBox.Controls.Add(this.pswLabel);
            this.loginBox.Controls.Add(this.userNameLabel);
            this.loginBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBox.ForeColor = System.Drawing.Color.Olive;
            this.loginBox.Location = new System.Drawing.Point(93, 17);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(444, 278);
            this.loginBox.TabIndex = 0;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Log in";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(122, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pswtextBox
            // 
            this.pswtextBox.Location = new System.Drawing.Point(189, 147);
            this.pswtextBox.Name = "pswtextBox";
            this.pswtextBox.PasswordChar = '*';
            this.pswtextBox.Size = new System.Drawing.Size(226, 34);
            this.pswtextBox.TabIndex = 3;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(189, 78);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(226, 34);
            this.nametextBox.TabIndex = 2;
            // 
            // pswLabel
            // 
            this.pswLabel.AutoSize = true;
            this.pswLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pswLabel.Location = new System.Drawing.Point(36, 150);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(115, 27);
            this.pswLabel.TabIndex = 1;
            this.pswLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameLabel.Location = new System.Drawing.Point(36, 81);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(125, 27);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // noAccountlinkLabel
            // 
            this.noAccountlinkLabel.ActiveLinkColor = System.Drawing.Color.Gold;
            this.noAccountlinkLabel.AutoSize = true;
            this.noAccountlinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noAccountlinkLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noAccountlinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.noAccountlinkLabel.LinkColor = System.Drawing.Color.Olive;
            this.noAccountlinkLabel.Location = new System.Drawing.Point(192, 315);
            this.noAccountlinkLabel.Name = "noAccountlinkLabel";
            this.noAccountlinkLabel.Size = new System.Drawing.Size(218, 18);
            this.noAccountlinkLabel.TabIndex = 2;
            this.noAccountlinkLabel.TabStop = true;
            this.noAccountlinkLabel.Text = "Dont have account? Register";
            this.noAccountlinkLabel.VisitedLinkColor = System.Drawing.Color.Olive;
            this.noAccountlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.noAccountlinkLabel_LinkClicked);
            this.noAccountlinkLabel.MouseEnter += new System.EventHandler(this.noAccountlinkLabel_MouseEnter);
            this.noAccountlinkLabel.MouseLeave += new System.EventHandler(this.noAccountlinkLabel_MouseLeave);
            // 
            // registergroupBox
            // 
            this.registergroupBox.Controls.Add(this.textBox4);
            this.registergroupBox.Controls.Add(this.label4);
            this.registergroupBox.Controls.Add(this.regSubButton);
            this.registergroupBox.Controls.Add(this.textBox3);
            this.registergroupBox.Controls.Add(this.textBox2);
            this.registergroupBox.Controls.Add(this.textBox1);
            this.registergroupBox.Controls.Add(this.label3);
            this.registergroupBox.Controls.Add(this.label2);
            this.registergroupBox.Controls.Add(this.label1);
            this.registergroupBox.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registergroupBox.ForeColor = System.Drawing.Color.Olive;
            this.registergroupBox.Location = new System.Drawing.Point(354, 17);
            this.registergroupBox.Name = "registergroupBox";
            this.registergroupBox.Size = new System.Drawing.Size(461, 313);
            this.registergroupBox.TabIndex = 3;
            this.registergroupBox.TabStop = false;
            this.registergroupBox.Text = "Register";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(206, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 37);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(41, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // regSubButton
            // 
            this.regSubButton.ForeColor = System.Drawing.Color.Gold;
            this.regSubButton.Location = new System.Drawing.Point(157, 265);
            this.regSubButton.Name = "regSubButton";
            this.regSubButton.Size = new System.Drawing.Size(141, 36);
            this.regSubButton.TabIndex = 6;
            this.regSubButton.Text = "Submit";
            this.regSubButton.UseVisualStyleBackColor = true;
            this.regSubButton.Click += new System.EventHandler(this.regSubButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 37);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 37);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 37);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(41, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(41, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // haveAccountlinkLabel
            // 
            this.haveAccountlinkLabel.ActiveLinkColor = System.Drawing.Color.Gold;
            this.haveAccountlinkLabel.AutoSize = true;
            this.haveAccountlinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.haveAccountlinkLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haveAccountlinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.haveAccountlinkLabel.LinkColor = System.Drawing.Color.Olive;
            this.haveAccountlinkLabel.Location = new System.Drawing.Point(220, 347);
            this.haveAccountlinkLabel.Name = "haveAccountlinkLabel";
            this.haveAccountlinkLabel.Size = new System.Drawing.Size(195, 17);
            this.haveAccountlinkLabel.TabIndex = 5;
            this.haveAccountlinkLabel.TabStop = true;
            this.haveAccountlinkLabel.Text = "Do you have account? Log in";
            this.haveAccountlinkLabel.VisitedLinkColor = System.Drawing.Color.Olive;
            this.haveAccountlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.haveAccountlinkLabel_LinkClicked);
            this.haveAccountlinkLabel.MouseEnter += new System.EventHandler(this.haveAccountlinkLabel_MouseEnter);
            this.haveAccountlinkLabel.MouseLeave += new System.EventHandler(this.haveAccountlinkLabel_MouseLeave);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.haveAccountlinkLabel);
            this.Controls.Add(this.registergroupBox);
            this.Controls.Add(this.noAccountlinkLabel);
            this.Controls.Add(this.loginBox);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(654, 412);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.registergroupBox.ResumeLayout(false);
            this.registergroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pswtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel noAccountlinkLabel;
        private System.Windows.Forms.GroupBox registergroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regSubButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.LinkLabel haveAccountlinkLabel;
    }
}
