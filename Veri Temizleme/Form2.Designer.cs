namespace Veri_Temizleme
{
    partial class Form2
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.cbIller = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_EksikVeriBul = new System.Windows.Forms.Button();
            this.btnEksikVerileriDoldur = new System.Windows.Forms.Button();
            this.labelToplam = new System.Windows.Forms.Label();
            this.labelOrtalama = new System.Windows.Forms.Label();
            this.btnEnYakınaGore = new System.Windows.Forms.Button();
            this.textboxKDegeri = new System.Windows.Forms.TextBox();
            this.btnOrneklemOrtalamasınaGoreDoldur = new System.Windows.Forms.Button();
            this.btnDemetleme = new System.Windows.Forms.Button();
            this.textboxBolmeGenisligi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.Location = new System.Drawing.Point(12, 12);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaAc.TabIndex = 0;
            this.btnDosyaAc.Text = "Dosya Aç";
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // cbIller
            // 
            this.cbIller.FormattingEnabled = true;
            this.cbIller.Location = new System.Drawing.Point(93, 14);
            this.cbIller.Name = "cbIller";
            this.cbIller.Size = new System.Drawing.Size(186, 21);
            this.cbIller.TabIndex = 1;
            this.cbIller.SelectedIndexChanged += new System.EventHandler(this.cbIller_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1030, 598);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btn_EksikVeriBul
            // 
            this.btn_EksikVeriBul.Location = new System.Drawing.Point(285, 14);
            this.btn_EksikVeriBul.Name = "btn_EksikVeriBul";
            this.btn_EksikVeriBul.Size = new System.Drawing.Size(156, 23);
            this.btn_EksikVeriBul.TabIndex = 3;
            this.btn_EksikVeriBul.Text = "Eksik verileri bul";
            this.btn_EksikVeriBul.UseVisualStyleBackColor = true;
            this.btn_EksikVeriBul.Click += new System.EventHandler(this.btn_EksikVeriBul_Click);
            // 
            // btnEksikVerileriDoldur
            // 
            this.btnEksikVerileriDoldur.Location = new System.Drawing.Point(285, 43);
            this.btnEksikVerileriDoldur.Name = "btnEksikVerileriDoldur";
            this.btnEksikVerileriDoldur.Size = new System.Drawing.Size(156, 23);
            this.btnEksikVerileriDoldur.TabIndex = 4;
            this.btnEksikVerileriDoldur.Text = "Nitelik ortalamasına göre";
            this.btnEksikVerileriDoldur.UseVisualStyleBackColor = true;
            this.btnEksikVerileriDoldur.Click += new System.EventHandler(this.btnEksikVerileriDoldur_Click);
            // 
            // labelToplam
            // 
            this.labelToplam.AutoSize = true;
            this.labelToplam.Location = new System.Drawing.Point(13, 42);
            this.labelToplam.Name = "labelToplam";
            this.labelToplam.Size = new System.Drawing.Size(48, 13);
            this.labelToplam.TabIndex = 5;
            this.labelToplam.Text = "Toplam: ";
            // 
            // labelOrtalama
            // 
            this.labelOrtalama.AutoSize = true;
            this.labelOrtalama.Location = new System.Drawing.Point(13, 55);
            this.labelOrtalama.Name = "labelOrtalama";
            this.labelOrtalama.Size = new System.Drawing.Size(55, 13);
            this.labelOrtalama.TabIndex = 6;
            this.labelOrtalama.Text = "Ortalama: ";
            // 
            // btnEnYakınaGore
            // 
            this.btnEnYakınaGore.Location = new System.Drawing.Point(447, 14);
            this.btnEnYakınaGore.Name = "btnEnYakınaGore";
            this.btnEnYakınaGore.Size = new System.Drawing.Size(134, 23);
            this.btnEnYakınaGore.TabIndex = 7;
            this.btnEnYakınaGore.Text = "Oklid Uzaklığa Göre";
            this.btnEnYakınaGore.UseVisualStyleBackColor = true;
            this.btnEnYakınaGore.Click += new System.EventHandler(this.btnEnYakınaGore_Click);
            // 
            // textboxKDegeri
            // 
            this.textboxKDegeri.Location = new System.Drawing.Point(587, 16);
            this.textboxKDegeri.Name = "textboxKDegeri";
            this.textboxKDegeri.Size = new System.Drawing.Size(100, 20);
            this.textboxKDegeri.TabIndex = 8;
            // 
            // btnOrneklemOrtalamasınaGoreDoldur
            // 
            this.btnOrneklemOrtalamasınaGoreDoldur.Location = new System.Drawing.Point(285, 72);
            this.btnOrneklemOrtalamasınaGoreDoldur.Name = "btnOrneklemOrtalamasınaGoreDoldur";
            this.btnOrneklemOrtalamasınaGoreDoldur.Size = new System.Drawing.Size(156, 23);
            this.btnOrneklemOrtalamasınaGoreDoldur.TabIndex = 10;
            this.btnOrneklemOrtalamasınaGoreDoldur.Text = "Örneklem ortalamasına göre";
            this.btnOrneklemOrtalamasınaGoreDoldur.UseVisualStyleBackColor = true;
            this.btnOrneklemOrtalamasınaGoreDoldur.Click += new System.EventHandler(this.btnOrneklemOrtalamasınaGoreDoldur_Click);
            // 
            // btnDemetleme
            // 
            this.btnDemetleme.Location = new System.Drawing.Point(447, 43);
            this.btnDemetleme.Name = "btnDemetleme";
            this.btnDemetleme.Size = new System.Drawing.Size(134, 23);
            this.btnDemetleme.TabIndex = 11;
            this.btnDemetleme.Text = "Demetleme";
            this.btnDemetleme.UseVisualStyleBackColor = true;
            this.btnDemetleme.Click += new System.EventHandler(this.btnDemetleme_Click);
            // 
            // textboxBolmeGenisligi
            // 
            this.textboxBolmeGenisligi.Location = new System.Drawing.Point(587, 45);
            this.textboxBolmeGenisligi.Name = "textboxBolmeGenisligi";
            this.textboxBolmeGenisligi.Size = new System.Drawing.Size(100, 20);
            this.textboxBolmeGenisligi.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1048, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 602);
            this.listBox1.TabIndex = 13;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1154, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 602);
            this.listBox2.TabIndex = 14;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(878, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Değer değişimlerinin hangi listbox\'a yazılacağını seçin(varsayılan soldaki listbo" +
    "x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(878, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "İki farklı işlemi karşılaştırmak için iki işlemi farklı listbox\'lara yazdırın";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 708);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textboxBolmeGenisligi);
            this.Controls.Add(this.btnDemetleme);
            this.Controls.Add(this.btnOrneklemOrtalamasınaGoreDoldur);
            this.Controls.Add(this.textboxKDegeri);
            this.Controls.Add(this.btnEnYakınaGore);
            this.Controls.Add(this.labelOrtalama);
            this.Controls.Add(this.labelToplam);
            this.Controls.Add(this.btnEksikVerileriDoldur);
            this.Controls.Add(this.btn_EksikVeriBul);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbIller);
            this.Controls.Add(this.btnDosyaAc);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.ComboBox cbIller;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_EksikVeriBul;
        private System.Windows.Forms.Button btnEksikVerileriDoldur;
        private System.Windows.Forms.Label labelToplam;
        private System.Windows.Forms.Label labelOrtalama;
        private System.Windows.Forms.Button btnEnYakınaGore;
        private System.Windows.Forms.TextBox textboxKDegeri;
        private System.Windows.Forms.Button btnOrneklemOrtalamasınaGoreDoldur;
        private System.Windows.Forms.Button btnDemetleme;
        private System.Windows.Forms.TextBox textboxBolmeGenisligi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}