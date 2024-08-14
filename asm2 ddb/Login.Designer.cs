namespace asm2_ddb
{
    partial class fLogin
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btgcreate = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(375, 270);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btgcreate
            // 
            this.btgcreate.Location = new System.Drawing.Point(283, 270);
            this.btgcreate.Name = "btgcreate";
            this.btgcreate.Size = new System.Drawing.Size(75, 23);
            this.btgcreate.TabIndex = 12;
            this.btgcreate.Text = "Create";
            this.btgcreate.UseVisualStyleBackColor = true;
            this.btgcreate.Click += new System.EventHandler(this.btgcreate_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(190, 270);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(190, 235);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(260, 20);
            this.txtpassword.TabIndex = 9;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(190, 178);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(260, 20);
            this.txtusername.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(310, 57);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(123, 22);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Kayne Shop";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::asm2_ddb.Properties.Resources.Icons8_Windows_8_Security_Password_2;
            this.pictureBox3.Location = new System.Drawing.Point(115, 235);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::asm2_ddb.Properties.Resources.user_icon_150670;
            this.pictureBox2.Location = new System.Drawing.Point(115, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::asm2_ddb.Properties.Resources.hình_cute;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 367);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btgcreate);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.Label1);
            this.Name = "fLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.Button btgcreate;
        internal System.Windows.Forms.Button btnlogin;
        internal System.Windows.Forms.TextBox txtpassword;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

