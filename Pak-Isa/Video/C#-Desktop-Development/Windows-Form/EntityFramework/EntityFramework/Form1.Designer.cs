namespace EntityFramework
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
            this.label1 = new System.Windows.Forms.Label();
            this.nma = new System.Windows.Forms.Label();
            this.umr = new System.Windows.Forms.Label();
            this.almt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaBox = new System.Windows.Forms.TextBox();
            this.umurBox = new System.Windows.Forms.TextBox();
            this.alamatBox = new System.Windows.Forms.TextBox();
            this.jurusanBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Siswa";
            // 
            // nma
            // 
            this.nma.AutoSize = true;
            this.nma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nma.Location = new System.Drawing.Point(667, 41);
            this.nma.Name = "nma";
            this.nma.Size = new System.Drawing.Size(64, 28);
            this.nma.TabIndex = 0;
            this.nma.Text = "Nama";
            // 
            // umr
            // 
            this.umr.AutoSize = true;
            this.umr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.umr.Location = new System.Drawing.Point(666, 94);
            this.umr.Name = "umr";
            this.umr.Size = new System.Drawing.Size(61, 28);
            this.umr.TabIndex = 0;
            this.umr.Text = "Umur";
            // 
            // almt
            // 
            this.almt.AutoSize = true;
            this.almt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almt.Location = new System.Drawing.Point(666, 147);
            this.almt.Name = "almt";
            this.almt.Size = new System.Drawing.Size(74, 28);
            this.almt.TabIndex = 0;
            this.almt.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jurusan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nama,
            this.Umur,
            this.Alamat,
            this.Jurusan,
            this.delete,
            this.Update});
            this.dataGridView1.Location = new System.Drawing.Point(29, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(612, 397);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // namaBox
            // 
            this.namaBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaBox.Location = new System.Drawing.Point(767, 44);
            this.namaBox.Name = "namaBox";
            this.namaBox.Size = new System.Drawing.Size(364, 34);
            this.namaBox.TabIndex = 2;
            // 
            // umurBox
            // 
            this.umurBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.umurBox.Location = new System.Drawing.Point(766, 94);
            this.umurBox.Name = "umurBox";
            this.umurBox.Size = new System.Drawing.Size(365, 34);
            this.umurBox.TabIndex = 2;
            // 
            // alamatBox
            // 
            this.alamatBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatBox.Location = new System.Drawing.Point(766, 147);
            this.alamatBox.Multiline = true;
            this.alamatBox.Name = "alamatBox";
            this.alamatBox.Size = new System.Drawing.Size(365, 178);
            this.alamatBox.TabIndex = 2;
            // 
            // jurusanBox
            // 
            this.jurusanBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurusanBox.FormattingEnabled = true;
            this.jurusanBox.Location = new System.Drawing.Point(767, 344);
            this.jurusanBox.Name = "jurusanBox";
            this.jurusanBox.Size = new System.Drawing.Size(364, 36);
            this.jurusanBox.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(861, 481);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 43);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1013, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(528, 29);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(113, 41);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pencarian";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(135, 29);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(385, 37);
            this.searchBox.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            this.Nama.Width = 150;
            // 
            // Umur
            // 
            this.Umur.DataPropertyName = "Umur";
            this.Umur.HeaderText = "Umur";
            this.Umur.MinimumWidth = 8;
            this.Umur.Name = "Umur";
            this.Umur.Width = 150;
            // 
            // Alamat
            // 
            this.Alamat.DataPropertyName = "Alamat";
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.MinimumWidth = 8;
            this.Alamat.Name = "Alamat";
            this.Alamat.Width = 150;
            // 
            // Jurusan
            // 
            this.Jurusan.DataPropertyName = "Jurusan";
            this.Jurusan.HeaderText = "Jurusan";
            this.Jurusan.MinimumWidth = 8;
            this.Jurusan.Name = "Jurusan";
            this.Jurusan.Width = 150;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.HeaderText = "Hapus";
            this.delete.MinimumWidth = 8;
            this.delete.Name = "delete";
            this.delete.Text = "Hapus";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 150;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 8;
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 552);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.jurusanBox);
            this.Controls.Add(this.alamatBox);
            this.Controls.Add(this.umurBox);
            this.Controls.Add(this.namaBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.almt);
            this.Controls.Add(this.umr);
            this.Controls.Add(this.nma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nma;
        private System.Windows.Forms.Label umr;
        private System.Windows.Forms.Label almt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox namaBox;
        private System.Windows.Forms.TextBox umurBox;
        private System.Windows.Forms.TextBox alamatBox;
        private System.Windows.Forms.ComboBox jurusanBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jurusan;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}

