namespace asm2_ddb
{
    partial class ManagementCustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamecustomer = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(473, 336);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Customer";
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(11, 274);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 4;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // txtnamecustomer
            // 
            this.txtnamecustomer.Location = new System.Drawing.Point(98, 76);
            this.txtnamecustomer.Name = "txtnamecustomer";
            this.txtnamecustomer.Size = new System.Drawing.Size(175, 20);
            this.txtnamecustomer.TabIndex = 8;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(98, 108);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(175, 20);
            this.txtphone.TabIndex = 9;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(98, 139);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(175, 20);
            this.txtaddress.TabIndex = 10;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(98, 274);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(179, 274);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Resert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcustomerid);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtnamecustomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btncreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(590, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 322);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Customer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CustomerID";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(98, 34);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.ReadOnly = true;
            this.txtcustomerid.Size = new System.Drawing.Size(175, 20);
            this.txtcustomerid.TabIndex = 15;
            // 
            // ManagementCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagementCustomer";
            this.Text = "ManagementCustomer";
            this.Load += new System.EventHandler(this.ManagementCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamecustomer;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}