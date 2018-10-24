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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.pswLabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pswtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.noAccountlinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginBox.SuspendLayout();
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
            this.loginBox.Location = new System.Drawing.Point(93, 32);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(444, 278);
            this.loginBox.TabIndex = 0;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Log in";
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
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(189, 78);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(226, 34);
            this.nametextBox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pswtextBox
            // 
            this.pswtextBox.Location = new System.Drawing.Point(189, 147);
            this.pswtextBox.Name = "pswtextBox";
            this.pswtextBox.PasswordChar = '*';
            this.pswtextBox.Size = new System.Drawing.Size(226, 34);
            this.pswtextBox.TabIndex = 3;
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
            // 
            // noAccountlinkLabel
            // 
            this.noAccountlinkLabel.ActiveLinkColor = System.Drawing.Color.Gold;
            this.noAccountlinkLabel.AutoSize = true;
            this.noAccountlinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noAccountlinkLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noAccountlinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.noAccountlinkLabel.LinkColor = System.Drawing.Color.Olive;
            this.noAccountlinkLabel.Location = new System.Drawing.Point(190, 327);
            this.noAccountlinkLabel.Name = "noAccountlinkLabel";
            this.noAccountlinkLabel.Size = new System.Drawing.Size(218, 18);
            this.noAccountlinkLabel.TabIndex = 2;
            this.noAccountlinkLabel.TabStop = true;
            this.noAccountlinkLabel.Text = "Dont have account? Register";
            this.noAccountlinkLabel.MouseEnter += new System.EventHandler(this.noAccountlinkLabel_MouseEnter);
            this.noAccountlinkLabel.MouseLeave += new System.EventHandler(this.noAccountlinkLabel_MouseLeave);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noAccountlinkLabel);
            this.Controls.Add(this.loginBox);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(654, 412);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
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
    }
}
