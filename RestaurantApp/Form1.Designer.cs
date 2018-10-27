namespace RestaurantApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.contactBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.nutBtn = new System.Windows.Forms.Button();
            this.restaurBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingspictureBox = new System.Windows.Forms.PictureBox();
            this.ExitpictureBox = new System.Windows.Forms.PictureBox();
            this.defaultControl1 = new RestaurantApp.DefaultControl();
            this.menuControl1 = new RestaurantApp.MenuControl();
            this.loginControl1 = new RestaurantApp.LoginControl();
            this.restaurantControl1 = new RestaurantApp.RestaurantControl();
            this.nutritionControl1 = new RestaurantApp.NutritionControl();
            this.contactControl1 = new RestaurantApp.ContactControl();
            this.accountControl1 = new RestaurantApp.AccountControl();
            this.welcomeControl1 = new RestaurantApp.WelcomeControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingspictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.contactBtn);
            this.panel1.Controls.Add(this.accountBtn);
            this.panel1.Controls.Add(this.nutBtn);
            this.panel1.Controls.Add(this.restaurBtn);
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 462);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.SidePanel.Location = new System.Drawing.Point(0, 59);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 45);
            this.SidePanel.TabIndex = 3;
            // 
            // contactBtn
            // 
            this.contactBtn.FlatAppearance.BorderSize = 0;
            this.contactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contactBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contactBtn.Image = ((System.Drawing.Image)(resources.GetObject("contactBtn.Image")));
            this.contactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactBtn.Location = new System.Drawing.Point(12, 302);
            this.contactBtn.Name = "contactBtn";
            this.contactBtn.Size = new System.Drawing.Size(163, 42);
            this.contactBtn.TabIndex = 8;
            this.contactBtn.Text = "   Contact";
            this.contactBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contactBtn.UseVisualStyleBackColor = true;
            this.contactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accountBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accountBtn.Image = ((System.Drawing.Image)(resources.GetObject("accountBtn.Image")));
            this.accountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.Location = new System.Drawing.Point(12, 254);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(163, 42);
            this.accountBtn.TabIndex = 7;
            this.accountBtn.Text = "   My acount";
            this.accountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // nutBtn
            // 
            this.nutBtn.FlatAppearance.BorderSize = 0;
            this.nutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nutBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nutBtn.Image = ((System.Drawing.Image)(resources.GetObject("nutBtn.Image")));
            this.nutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nutBtn.Location = new System.Drawing.Point(12, 206);
            this.nutBtn.Name = "nutBtn";
            this.nutBtn.Size = new System.Drawing.Size(163, 42);
            this.nutBtn.TabIndex = 6;
            this.nutBtn.Text = "   Nutrition facts";
            this.nutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nutBtn.UseVisualStyleBackColor = true;
            this.nutBtn.Click += new System.EventHandler(this.nutBtn_Click);
            // 
            // restaurBtn
            // 
            this.restaurBtn.FlatAppearance.BorderSize = 0;
            this.restaurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restaurBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restaurBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.restaurBtn.Image = ((System.Drawing.Image)(resources.GetObject("restaurBtn.Image")));
            this.restaurBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restaurBtn.Location = new System.Drawing.Point(12, 158);
            this.restaurBtn.Name = "restaurBtn";
            this.restaurBtn.Size = new System.Drawing.Size(163, 42);
            this.restaurBtn.TabIndex = 5;
            this.restaurBtn.Text = "   Restaurants";
            this.restaurBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.restaurBtn.UseVisualStyleBackColor = true;
            this.restaurBtn.Click += new System.EventHandler(this.restaurBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Location = new System.Drawing.Point(12, 110);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(163, 42);
            this.menuBtn.TabIndex = 4;
            this.menuBtn.Text = "   Menu";
            this.menuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(12, 62);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(163, 42);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "   Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 14);
            this.panel2.TabIndex = 1;
            // 
            // SettingspictureBox
            // 
            this.SettingspictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SettingspictureBox.Image")));
            this.SettingspictureBox.Location = new System.Drawing.Point(763, 20);
            this.SettingspictureBox.Name = "SettingspictureBox";
            this.SettingspictureBox.Size = new System.Drawing.Size(24, 24);
            this.SettingspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SettingspictureBox.TabIndex = 3;
            this.SettingspictureBox.TabStop = false;
            this.SettingspictureBox.Tag = "";
            this.SettingspictureBox.Click += new System.EventHandler(this.SettingspictureBox_Click);
            this.SettingspictureBox.MouseHover += new System.EventHandler(this.SettingspictureBox_MouseHover);
            // 
            // ExitpictureBox
            // 
            this.ExitpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitpictureBox.Image")));
            this.ExitpictureBox.Location = new System.Drawing.Point(793, 20);
            this.ExitpictureBox.Name = "ExitpictureBox";
            this.ExitpictureBox.Size = new System.Drawing.Size(24, 24);
            this.ExitpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitpictureBox.TabIndex = 4;
            this.ExitpictureBox.TabStop = false;
            this.ExitpictureBox.Click += new System.EventHandler(this.ExitpictureBox_Click);
            this.ExitpictureBox.MouseHover += new System.EventHandler(this.ExitpictureBox_MouseHover);
            // 
            // defaultControl1
            // 
            this.defaultControl1.button = null;
            this.defaultControl1.control = null;
            this.defaultControl1.Location = new System.Drawing.Point(175, 50);
            this.defaultControl1.Name = "defaultControl1";
            this.defaultControl1.panel = null;
            this.defaultControl1.Size = new System.Drawing.Size(654, 412);
            this.defaultControl1.TabIndex = 5;
            // 
            // menuControl1
            // 
            this.menuControl1.Location = new System.Drawing.Point(175, 50);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(654, 412);
            this.menuControl1.TabIndex = 6;
            // 
            // loginControl1
            // 
            this.loginControl1.button = null;
            this.loginControl1.control = null;
            this.loginControl1.Location = new System.Drawing.Point(175, 50);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.panel = null;
            this.loginControl1.Size = new System.Drawing.Size(654, 412);
            this.loginControl1.TabIndex = 7;
            // 
            // restaurantControl1
            // 
            this.restaurantControl1.Location = new System.Drawing.Point(175, 50);
            this.restaurantControl1.Name = "restaurantControl1";
            this.restaurantControl1.Size = new System.Drawing.Size(654, 412);
            this.restaurantControl1.TabIndex = 8;
            // 
            // nutritionControl1
            // 
            this.nutritionControl1.Location = new System.Drawing.Point(175, 50);
            this.nutritionControl1.Name = "nutritionControl1";
            this.nutritionControl1.Size = new System.Drawing.Size(654, 412);
            this.nutritionControl1.TabIndex = 9;
            // 
            // contactControl1
            // 
            this.contactControl1.Location = new System.Drawing.Point(175, 50);
            this.contactControl1.Name = "contactControl1";
            this.contactControl1.Size = new System.Drawing.Size(654, 412);
            this.contactControl1.TabIndex = 10;
            // 
            // accountControl1
            // 
            this.accountControl1.Location = new System.Drawing.Point(175, 50);
            this.accountControl1.Name = "accountControl1";
            this.accountControl1.Size = new System.Drawing.Size(654, 412);
            this.accountControl1.TabIndex = 11;
            // 
            // welcomeControl1
            // 
            this.welcomeControl1.Location = new System.Drawing.Point(175, 50);
            this.welcomeControl1.Name = "welcomeControl1";
            this.welcomeControl1.Size = new System.Drawing.Size(654, 412);
            this.welcomeControl1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.welcomeControl1);
            this.Controls.Add(this.accountControl1);
            this.Controls.Add(this.contactControl1);
            this.Controls.Add(this.nutritionControl1);
            this.Controls.Add(this.restaurantControl1);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.defaultControl1);
            this.Controls.Add(this.ExitpictureBox);
            this.Controls.Add(this.SettingspictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingspictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button contactBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button nutBtn;
        private System.Windows.Forms.Button restaurBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox SettingspictureBox;
        private System.Windows.Forms.PictureBox ExitpictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DefaultControl defaultControl1;
        private MenuControl menuControl1;
        private LoginControl loginControl1;
        private RestaurantControl restaurantControl1;
        private NutritionControl nutritionControl1;
        private ContactControl contactControl1;
        private AccountControl accountControl1;
        private WelcomeControl welcomeControl1;
    }
}

