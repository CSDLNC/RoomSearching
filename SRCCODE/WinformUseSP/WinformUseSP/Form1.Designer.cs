namespace WinformUseSP
{
    partial class Form1
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
            this.timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.demo02DataSet = new WinformUseSP.demo02DataSet();
            this.khachSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachSanTableAdapter = new WinformUseSP.demo02DataSetTableAdapters.KhachSanTableAdapter();
            this.sPSearchHotelInformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_SearchHotelInformTableAdapter = new WinformUseSP.demo02DataSetTableAdapters.SP_SearchHotelInformTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.demo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSearchHotelInformBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(486, 35);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 23);
            this.timkiem.TabIndex = 5;
            this.timkiem.Text = "Tìm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số sao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thành phố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá cả";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // demo02DataSet
            // 
            this.demo02DataSet.DataSetName = "demo02DataSet";
            this.demo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachSanBindingSource
            // 
            this.khachSanBindingSource.DataMember = "KhachSan";
            this.khachSanBindingSource.DataSource = this.demo02DataSet;
            // 
            // khachSanTableAdapter
            // 
            this.khachSanTableAdapter.ClearBeforeFill = true;
            // 
            // sPSearchHotelInformBindingSource
            // 
            this.sPSearchHotelInformBindingSource.DataMember = "SP_SearchHotelInform";
            this.sPSearchHotelInformBindingSource.DataSource = this.demo02DataSet;
            // 
            // sP_SearchHotelInformTableAdapter
            // 
            this.sP_SearchHotelInformTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKSDataGridViewTextBoxColumn,
            this.tenKSDataGridViewTextBoxColumn,
            this.soSaoDataGridViewTextBoxColumn,
            this.soNhaDataGridViewTextBoxColumn,
            this.duongDataGridViewTextBoxColumn,
            this.quanDataGridViewTextBoxColumn,
            this.thanhPhoDataGridViewTextBoxColumn,
            this.giaTBDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPSearchHotelInformBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 274);
            this.dataGridView1.TabIndex = 12;
            // 
            // maKSDataGridViewTextBoxColumn
            // 
            this.maKSDataGridViewTextBoxColumn.DataPropertyName = "maKS";
            this.maKSDataGridViewTextBoxColumn.HeaderText = "maKS";
            this.maKSDataGridViewTextBoxColumn.Name = "maKSDataGridViewTextBoxColumn";
            this.maKSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKSDataGridViewTextBoxColumn
            // 
            this.tenKSDataGridViewTextBoxColumn.DataPropertyName = "tenKS";
            this.tenKSDataGridViewTextBoxColumn.HeaderText = "tenKS";
            this.tenKSDataGridViewTextBoxColumn.Name = "tenKSDataGridViewTextBoxColumn";
            // 
            // soSaoDataGridViewTextBoxColumn
            // 
            this.soSaoDataGridViewTextBoxColumn.DataPropertyName = "soSao";
            this.soSaoDataGridViewTextBoxColumn.HeaderText = "soSao";
            this.soSaoDataGridViewTextBoxColumn.Name = "soSaoDataGridViewTextBoxColumn";
            // 
            // soNhaDataGridViewTextBoxColumn
            // 
            this.soNhaDataGridViewTextBoxColumn.DataPropertyName = "soNha";
            this.soNhaDataGridViewTextBoxColumn.HeaderText = "soNha";
            this.soNhaDataGridViewTextBoxColumn.Name = "soNhaDataGridViewTextBoxColumn";
            // 
            // duongDataGridViewTextBoxColumn
            // 
            this.duongDataGridViewTextBoxColumn.DataPropertyName = "duong";
            this.duongDataGridViewTextBoxColumn.HeaderText = "duong";
            this.duongDataGridViewTextBoxColumn.Name = "duongDataGridViewTextBoxColumn";
            // 
            // quanDataGridViewTextBoxColumn
            // 
            this.quanDataGridViewTextBoxColumn.DataPropertyName = "quan";
            this.quanDataGridViewTextBoxColumn.HeaderText = "quan";
            this.quanDataGridViewTextBoxColumn.Name = "quanDataGridViewTextBoxColumn";
            // 
            // thanhPhoDataGridViewTextBoxColumn
            // 
            this.thanhPhoDataGridViewTextBoxColumn.DataPropertyName = "thanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.HeaderText = "thanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.Name = "thanhPhoDataGridViewTextBoxColumn";
            // 
            // giaTBDataGridViewTextBoxColumn
            // 
            this.giaTBDataGridViewTextBoxColumn.DataPropertyName = "giaTB";
            this.giaTBDataGridViewTextBoxColumn.HeaderText = "giaTB";
            this.giaTBDataGridViewTextBoxColumn.Name = "giaTBDataGridViewTextBoxColumn";
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "moTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "moTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timkiem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSearchHotelInformBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private demo02DataSet demo02DataSet;
        private System.Windows.Forms.BindingSource khachSanBindingSource;
        private demo02DataSetTableAdapters.KhachSanTableAdapter khachSanTableAdapter;
        private System.Windows.Forms.BindingSource sPSearchHotelInformBindingSource;
        private demo02DataSetTableAdapters.SP_SearchHotelInformTableAdapter sP_SearchHotelInformTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
    }
}

