namespace Trading_Broker_Project
{
    partial class Evaluation
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usr = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(185, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(917, 498);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // usr
            // 
            this.usr.AutoSize = true;
            this.usr.BackColor = System.Drawing.Color.Gray;
            this.usr.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usr.Location = new System.Drawing.Point(206, 91);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(163, 34);
            this.usr.TabIndex = 24;
            this.usr.Text = "Evaluation";
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.BackColor = System.Drawing.Color.White;
            this.question.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question.Location = new System.Drawing.Point(295, 174);
            this.question.Name = "question";
            this.question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question.Size = new System.Drawing.Size(61, 34);
            this.question.TabIndex = 25;
            this.question.Text = "vpr";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.question.Click += new System.EventHandler(this.label1_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(398, 385);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(187, 48);
            this.three.TabIndex = 26;
            this.three.Text = "button1";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button3_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(693, 311);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(187, 48);
            this.two.TabIndex = 26;
            this.two.Text = "button1";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button2_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(693, 385);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(187, 48);
            this.four.TabIndex = 27;
            this.four.Text = "button2";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button4_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(398, 311);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(187, 48);
            this.one.TabIndex = 26;
            this.one.Text = "ena";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(201, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 65);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1271, 633);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.four);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.three);
            this.Controls.Add(this.question);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Evaluation";
            this.Text = "Evalutaion";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label usr;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}