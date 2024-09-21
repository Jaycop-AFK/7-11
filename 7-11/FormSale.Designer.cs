namespace _7_11
{
    partial class FormSale
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
            this.bOk = new System.Windows.Forms.Button();
            this.la_recive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.la_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_Clear = new System.Windows.Forms.Button();
            this.b_Sale = new System.Windows.Forms.Button();
            this.b_Dot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.la_amount = new System.Windows.Forms.Label();
            this.la_counter = new System.Windows.Forms.Label();
            this.la_product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nu_count = new System.Windows.Forms.NumericUpDown();
            this.la = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.la_code_product = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.la_change = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_amout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_count)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(459, 150);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(48, 25);
            this.bOk.TabIndex = 58;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // la_recive
            // 
            this.la_recive.AutoSize = true;
            this.la_recive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_recive.Location = new System.Drawing.Point(439, 422);
            this.la_recive.Name = "la_recive";
            this.la_recive.Size = new System.Drawing.Size(35, 24);
            this.la_recive.TabIndex = 57;
            this.la_recive.Text = ".....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "รับเงิน";
            // 
            // la_total
            // 
            this.la_total.AutoSize = true;
            this.la_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_total.Location = new System.Drawing.Point(439, 398);
            this.la_total.Name = "la_total";
            this.la_total.Size = new System.Drawing.Size(35, 24);
            this.la_total.TabIndex = 55;
            this.la_total.Text = ".....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "รวม";
            // 
            // b_Clear
            // 
            this.b_Clear.Location = new System.Drawing.Point(713, 328);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(55, 52);
            this.b_Clear.TabIndex = 53;
            this.b_Clear.Text = "C";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // b_Sale
            // 
            this.b_Sale.BackColor = System.Drawing.Color.LightGreen;
            this.b_Sale.Location = new System.Drawing.Point(591, 384);
            this.b_Sale.Name = "b_Sale";
            this.b_Sale.Size = new System.Drawing.Size(177, 52);
            this.b_Sale.TabIndex = 52;
            this.b_Sale.Text = "Sale";
            this.b_Sale.UseVisualStyleBackColor = false;
            this.b_Sale.Click += new System.EventHandler(this.b_Sale_Click);
            // 
            // b_Dot
            // 
            this.b_Dot.Location = new System.Drawing.Point(652, 328);
            this.b_Dot.Name = "b_Dot";
            this.b_Dot.Size = new System.Drawing.Size(55, 52);
            this.b_Dot.TabIndex = 51;
            this.b_Dot.Text = ".";
            this.b_Dot.UseVisualStyleBackColor = true;
            this.b_Dot.Click += new System.EventHandler(this.b_Dot_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(591, 328);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(55, 52);
            this.b0.TabIndex = 50;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(713, 270);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(55, 52);
            this.b3.TabIndex = 49;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(652, 270);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(55, 52);
            this.b2.TabIndex = 48;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(591, 270);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(55, 52);
            this.b1.TabIndex = 47;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(713, 212);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(55, 52);
            this.b4.TabIndex = 46;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(652, 212);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(55, 52);
            this.b5.TabIndex = 45;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(591, 212);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(55, 52);
            this.b6.TabIndex = 44;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(713, 154);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(55, 52);
            this.b9.TabIndex = 43;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(652, 154);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(55, 52);
            this.b8.TabIndex = 42;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(591, 154);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(55, 52);
            this.b7.TabIndex = 41;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.product_name,
            this.product_amout,
            this.product_price,
            this.total});
            this.productDataGridView.Location = new System.Drawing.Point(17, 178);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(544, 215);
            this.productDataGridView.TabIndex = 40;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // la_amount
            // 
            this.la_amount.AutoSize = true;
            this.la_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_amount.Location = new System.Drawing.Point(411, 154);
            this.la_amount.Name = "la_amount";
            this.la_amount.Size = new System.Drawing.Size(42, 25);
            this.la_amount.TabIndex = 39;
            this.la_amount.Text = ".....";
            // 
            // la_counter
            // 
            this.la_counter.AutoSize = true;
            this.la_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_counter.Location = new System.Drawing.Point(332, 150);
            this.la_counter.Name = "la_counter";
            this.la_counter.Size = new System.Drawing.Size(78, 29);
            this.la_counter.TabIndex = 38;
            this.la_counter.Text = "จำนวน";
            // 
            // la_product
            // 
            this.la_product.AutoSize = true;
            this.la_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_product.Location = new System.Drawing.Point(135, 150);
            this.la_product.Name = "la_product";
            this.la_product.Size = new System.Drawing.Size(48, 25);
            this.la_product.TabIndex = 37;
            this.la_product.Text = "......";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "รายการสินค้า";
            // 
            // nu_count
            // 
            this.nu_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_count.Location = new System.Drawing.Point(416, 99);
            this.nu_count.Name = "nu_count";
            this.nu_count.Size = new System.Drawing.Size(41, 31);
            this.nu_count.TabIndex = 35;
            this.nu_count.ValueChanged += new System.EventHandler(this.nu_count_ValueChanged);
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(332, 103);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(78, 29);
            this.la.TabIndex = 34;
            this.la.Text = "จำนวน";
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(125, 101);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(100, 31);
            this.tID.TabIndex = 33;
            this.tID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tID_KeyUp);
            // 
            // la_code_product
            // 
            this.la_code_product.AutoSize = true;
            this.la_code_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_code_product.Location = new System.Drawing.Point(12, 101);
            this.la_code_product.Name = "la_code_product";
            this.la_code_product.Size = new System.Drawing.Size(106, 29);
            this.la_code_product.TabIndex = 32;
            this.la_code_product.Text = "รหัสสินค้า";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 81);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(106, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Image = global::_7_11.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(3, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "เงินทอน";
            // 
            // la_change
            // 
            this.la_change.AutoSize = true;
            this.la_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_change.Location = new System.Drawing.Point(439, 446);
            this.la_change.Name = "la_change";
            this.la_change.Size = new System.Drawing.Size(35, 24);
            this.la_change.TabIndex = 60;
            this.la_change.Text = ".....";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_id";
            this.Column1.HeaderText = "รหัส";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "รายการสินค้า";
            this.product_name.Name = "product_name";
            this.product_name.Width = 170;
            // 
            // product_amout
            // 
            this.product_amout.DataPropertyName = "product_amout";
            this.product_amout.HeaderText = "จำนวน";
            this.product_amout.Name = "product_amout";
            // 
            // product_price
            // 
            this.product_price.DataPropertyName = "product_price";
            this.product_price.HeaderText = "ราคา";
            this.product_price.Name = "product_price";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "รวม";
            this.total.Name = "total";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.la_change);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.la_recive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.la_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b_Sale);
            this.Controls.Add(this.b_Dot);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.la_amount);
            this.Controls.Add(this.la_counter);
            this.Controls.Add(this.la_product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nu_count);
            this.Controls.Add(this.la);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.la_code_product);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSale";
            this.Text = "FormSale";
            this.Load += new System.EventHandler(this.FormSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_count)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label la_recive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label la_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Button b_Sale;
        private System.Windows.Forms.Button b_Dot;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label la_amount;
        private System.Windows.Forms.Label la_counter;
        private System.Windows.Forms.Label la_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nu_count;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label la_code_product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label la_change;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_amout;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}