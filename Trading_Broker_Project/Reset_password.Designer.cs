﻿namespace Trading_Broker_Project
{
    partial class Reset_password
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.newpassconf = new System.Windows.Forms.TextBox();
            this.conformation = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reset account password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(435, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 409);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "New password:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(455, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(362, 37);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repeat new password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(462, 263);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(216, 20);
            this.newpass.TabIndex = 11;
            this.newpass.TextChanged += new System.EventHandler(this.newpass_TextChanged);
            // 
            // newpassconf
            // 
            this.newpassconf.Location = new System.Drawing.Point(462, 322);
            this.newpassconf.Name = "newpassconf";
            this.newpassconf.Size = new System.Drawing.Size(216, 20);
            this.newpassconf.TabIndex = 12;
            this.newpassconf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // conformation
            // 
            this.conformation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conformation.Location = new System.Drawing.Point(462, 357);
            this.conformation.Name = "conformation";
            this.conformation.Size = new System.Drawing.Size(75, 23);
            this.conformation.TabIndex = 13;
            this.conformation.Text = "Confirm";
            this.conformation.UseVisualStyleBackColor = true;
            this.conformation.Click += new System.EventHandler(this.conformation_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(462, 212);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(216, 20);
            this.username.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username:";
            // 
            // Reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1271, 633);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conformation);
            this.Controls.Add(this.newpassconf);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reset_password";
            this.Text = "Reset account password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox newpassconf;
        private System.Windows.Forms.Button conformation;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
    }
}