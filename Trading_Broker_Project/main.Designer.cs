namespace Trading_Broker_Project
{
    partial class main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.graph_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.PictureBox();
            this.accbal = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 609);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account overview";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(24, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1221, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(24, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1221, 504);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // graph_btn
            // 
            this.graph_btn.Location = new System.Drawing.Point(36, 154);
            this.graph_btn.Name = "graph_btn";
            this.graph_btn.Size = new System.Drawing.Size(82, 43);
            this.graph_btn.TabIndex = 4;
            this.graph_btn.Text = "Graph";
            this.graph_btn.UseVisualStyleBackColor = true;
            this.graph_btn.Click += new System.EventHandler(this.graph_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account balance:";
            // 
            // k
            // 
            this.k.BackColor = System.Drawing.Color.White;
            this.k.Location = new System.Drawing.Point(36, 116);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(294, 32);
            this.k.TabIndex = 6;
            this.k.TabStop = false;
            // 
            // accbal
            // 
            this.accbal.AutoSize = true;
            this.accbal.BackColor = System.Drawing.Color.White;
            this.accbal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accbal.Location = new System.Drawing.Point(187, 122);
            this.accbal.Name = "accbal";
            this.accbal.Size = new System.Drawing.Size(18, 19);
            this.accbal.TabIndex = 7;
            this.accbal.Text = "0";
            this.accbal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accbal.Click += new System.EventHandler(this.accbal_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(123, 154);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(82, 43);
            this.logout.TabIndex = 8;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(1055, 154);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(175, 43);
            this.op.TabIndex = 9;
            this.op.Text = "( in development ) Orders and positions";
            this.op.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 633);
            this.Controls.Add(this.op);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.accbal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.k);
            this.Controls.Add(this.graph_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button graph_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox k;
        private System.Windows.Forms.Label accbal;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button op;
    }
}