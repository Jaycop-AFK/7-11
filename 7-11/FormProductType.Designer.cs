namespace _7_11
{
    partial class FormProductType
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._7_11DataSet = new _7_11._7_11DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_typeTableAdapter = new _7_11._7_11DataSetTableAdapters.product_typeTableAdapter();
            this.producttIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producttNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(76, 18);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(100, 20);
            this.t_id.TabIndex = 2;
            this.t_id.TextChanged += new System.EventHandler(this.t_id_TextChanged);
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(263, 18);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(100, 20);
            this.t_name.TabIndex = 3;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(662, 14);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 4;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(662, 43);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(75, 23);
            this.b_edit.TabIndex = 5;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(662, 72);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 6;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producttIDDataGridViewTextBoxColumn,
            this.producttNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.producttypeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 338);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _7_11DataSet
            // 
            this._7_11DataSet.DataSetName = "_7_11DataSet";
            this._7_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this._7_11DataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataMember = "product_type";
            this.producttypeBindingSource.DataSource = this.dataSetBindingSource;
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // producttIDDataGridViewTextBoxColumn
            // 
            this.producttIDDataGridViewTextBoxColumn.DataPropertyName = "product_tID";
            this.producttIDDataGridViewTextBoxColumn.HeaderText = "product_tID";
            this.producttIDDataGridViewTextBoxColumn.Name = "producttIDDataGridViewTextBoxColumn";
            // 
            // producttNameDataGridViewTextBoxColumn
            // 
            this.producttNameDataGridViewTextBoxColumn.DataPropertyName = "product_tName";
            this.producttNameDataGridViewTextBoxColumn.HeaderText = "product_tName";
            this.producttNameDataGridViewTextBoxColumn.Name = "producttNameDataGridViewTextBoxColumn";
            // 
            // FormProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductType";
            this.Text = "FormProductType";
            this.Load += new System.EventHandler(this.FormProductType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private _7_11DataSet _7_11DataSet;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private _7_11DataSetTableAdapters.product_typeTableAdapter product_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttNameDataGridViewTextBoxColumn;
    }
}