namespace asm2_ddb
{
    partial class fBuy
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
            this.txtnameproduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnamecustumer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbuy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnameproduct
            // 
            this.txtnameproduct.Location = new System.Drawing.Point(168, 92);
            this.txtnameproduct.Name = "txtnameproduct";
            this.txtnameproduct.ReadOnly = true;
            this.txtnameproduct.Size = new System.Drawing.Size(114, 20);
            this.txtnameproduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kayne User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(168, 151);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(114, 20);
            this.txtquantity.TabIndex = 10;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name Customer";
            // 
            // txtnamecustumer
            // 
            this.txtnamecustumer.Location = new System.Drawing.Point(405, 92);
            this.txtnamecustumer.Name = "txtnamecustumer";
            this.txtnamecustumer.Size = new System.Drawing.Size(144, 20);
            this.txtnamecustumer.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address ";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(405, 154);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(144, 20);
            this.txtaddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price (USD)";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(645, 157);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(113, 20);
            this.txtprice.TabIndex = 18;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phone Number";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(645, 92);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(113, 20);
            this.txtphone.TabIndex = 16;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Order Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 182);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(590, 241);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(75, 23);
            this.btnbuy.TabIndex = 24;
            this.btnbuy.Text = "Buy";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Description";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(405, 200);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.ReadOnly = true;
            this.txtdescription.Size = new System.Drawing.Size(144, 20);
            this.txtdescription.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::asm2_ddb.Properties.Resources._6e07ff8bb6fb04b0e21d3fe50dec88c3;
            this.pictureBox1.Location = new System.Drawing.Point(514, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(564, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "ProductID";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(645, 200);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.ReadOnly = true;
            this.txtproductid.Size = new System.Drawing.Size(114, 20);
            this.txtproductid.TabIndex = 28;
            // 
            // fBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(925, 482);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnamecustumer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnameproduct);
            this.Name = "fBuy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.fBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnameproduct;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnamecustumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtproductid;
    }
}