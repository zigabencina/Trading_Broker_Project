namespace Trading_Broker_Project
{
    partial class First_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First_page));
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.PictureBox();
            this.usr = new System.Windows.Forms.Label();
            this.Passwrd = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.frogor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.Location = new System.Drawing.Point(490, 406);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(122, 43);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register.Location = new System.Drawing.Point(662, 406);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(124, 43);
            this.register.TabIndex = 2;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(545, 115);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(186, 144);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user.TabIndex = 4;
            this.user.TabStop = false;
            // 
            // usr
            // 
            this.usr.AutoSize = true;
            this.usr.BackColor = System.Drawing.Color.White;
            this.usr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usr.Location = new System.Drawing.Point(486, 264);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(93, 19);
            this.usr.TabIndex = 5;
            this.usr.Text = "Username:";
            this.usr.Click += new System.EventHandler(this.usr_Click);
            // 
            // Passwrd
            // 
            this.Passwrd.AutoSize = true;
            this.Passwrd.BackColor = System.Drawing.Color.White;
            this.Passwrd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Passwrd.Location = new System.Drawing.Point(486, 319);
            this.Passwrd.Name = "Passwrd";
            this.Passwrd.Size = new System.Drawing.Size(92, 19);
            this.Passwrd.TabIndex = 6;
            this.Passwrd.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(490, 287);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(296, 20);
            this.username.TabIndex = 7;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(490, 342);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(296, 20);
            this.password.TabIndex = 8;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // frogor
            // 
            this.frogor.AutoSize = true;
            this.frogor.BackColor = System.Drawing.Color.White;
            this.frogor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frogor.Location = new System.Drawing.Point(487, 462);
            this.frogor.Name = "frogor";
            this.frogor.Size = new System.Drawing.Size(93, 16);
            this.frogor.TabIndex = 9;
            this.frogor.Text = "Forgot password?";
            this.frogor.Click += new System.EventHandler(this.frogor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(435, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 409);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // First_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 633);
            this.Controls.Add(this.frogor);
            this.Controls.Add(this.user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Passwrd);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "First_page";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button login;
        public System.Windows.Forms.Button register;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.Label usr;
        private System.Windows.Forms.Label Passwrd;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label frogor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

