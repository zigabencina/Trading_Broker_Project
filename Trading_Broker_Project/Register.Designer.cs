namespace Trading_Broker_Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.user = new System.Windows.Forms.PictureBox();
            this.surenamebox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.surename = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.usr = new System.Windows.Forms.Label();
            this.iban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(545, 113);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(186, 144);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user.TabIndex = 6;
            this.user.TabStop = false;
            // 
            // surenamebox
            // 
            this.surenamebox.Location = new System.Drawing.Point(682, 290);
            this.surenamebox.Name = "surenamebox";
            this.surenamebox.Size = new System.Drawing.Size(132, 20);
            this.surenamebox.TabIndex = 12;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(472, 291);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(132, 20);
            this.namebox.TabIndex = 11;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // surename
            // 
            this.surename.AutoSize = true;
            this.surename.BackColor = System.Drawing.Color.White;
            this.surename.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surename.Location = new System.Drawing.Point(678, 268);
            this.surename.Name = "surename";
            this.surename.Size = new System.Drawing.Size(93, 19);
            this.surename.TabIndex = 10;
            this.surename.Text = "Surename:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(468, 268);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 19);
            this.name.TabIndex = 9;
            this.name.Text = "Name:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(682, 354);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 20);
            this.password.TabIndex = 16;
           
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(472, 355);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(132, 20);
            this.username.TabIndex = 15;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pass.Location = new System.Drawing.Point(679, 332);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(92, 19);
            this.pass.TabIndex = 14;
            this.pass.Text = "Password:";
            // 
            // usr
            // 
            this.usr.AutoSize = true;
            this.usr.BackColor = System.Drawing.Color.White;
            this.usr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usr.Location = new System.Drawing.Point(468, 332);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(93, 19);
            this.usr.TabIndex = 13;
            this.usr.Text = "Username:";
            this.usr.Click += new System.EventHandler(this.label2_Click);
            // 
            // iban
            // 
            this.iban.Location = new System.Drawing.Point(472, 423);
            this.iban.Name = "iban";
            this.iban.Size = new System.Drawing.Size(132, 20);
            this.iban.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(468, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "IBAN:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(683, 422);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(131, 20);
            this.country.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(679, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Country:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_button.Location = new System.Drawing.Point(576, 484);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(124, 43);
            this.register_button.TabIndex = 21;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(435, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(409, 440);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 633);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.surenamebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.surename);
            this.Controls.Add(this.name);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Register";
            this.Text = "Register";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.TextBox surenamebox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label surename;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label usr;
        private System.Windows.Forms.TextBox iban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button register_button;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}