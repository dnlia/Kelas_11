namespace Calculator_Sederhana
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
            this.textAngka1 = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textAngka2 = new System.Windows.Forms.TextBox();
            this.textHasil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // textAngka1
            // 
            this.textAngka1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAngka1.Location = new System.Drawing.Point(12, 97);
            this.textAngka1.Name = "textAngka1";
            this.textAngka1.Size = new System.Drawing.Size(415, 34);
            this.textAngka1.TabIndex = 1;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(10, 321);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(417, 46);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Angka 2";
            // 
            // textAngka2
            // 
            this.textAngka2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAngka2.Location = new System.Drawing.Point(12, 178);
            this.textAngka2.Name = "textAngka2";
            this.textAngka2.Size = new System.Drawing.Size(415, 34);
            this.textAngka2.TabIndex = 1;
            // 
            // textHasil
            // 
            this.textHasil.AutoSize = true;
            this.textHasil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHasil.Location = new System.Drawing.Point(12, 232);
            this.textHasil.Name = "textHasil";
            this.textHasil.Size = new System.Drawing.Size(76, 28);
            this.textHasil.TabIndex = 0;
            this.textHasil.Text = "Hasil : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aksi";
            // 
            // btnKurang
            // 
            this.btnKurang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurang.Location = new System.Drawing.Point(10, 373);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(417, 46);
            this.btnKurang.TabIndex = 2;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnKali
            // 
            this.btnKali.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKali.Location = new System.Drawing.Point(10, 427);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(417, 46);
            this.btnKali.TabIndex = 2;
            this.btnKali.Text = "Kali";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagi.Location = new System.Drawing.Point(10, 479);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(417, 46);
            this.btnBagi.TabIndex = 2;
            this.btnBagi.Text = "Bagi";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Calculator Sederhana";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 538);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.textAngka2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAngka1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAngka1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAngka2;
        private System.Windows.Forms.Label textHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Label label4;
    }
}

