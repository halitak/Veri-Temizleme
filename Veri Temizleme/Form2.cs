using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Temizleme
{
    public partial class Form2 : Form
    {
        VeriOku verioku;
        static string[,] yedekDataGrid;
        static bool[,] silinenData;
        static int satir, sutun;
        static bool secilenListBox=false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        public void dogrulukKarsilastir()
        {
            if (secilenListBox == false)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(cbIller.SelectedItem.ToString());
            }
            else
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(cbIller.SelectedItem.ToString());
            }
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (silinenData[i,j]==false)
                    {
                        if (secilenListBox==false)
                            listBox1.Items.Add(yedekDataGrid[i, j] + " -> " + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        else
                            listBox2.Items.Add(yedekDataGrid[i, j] + " -> " + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        silinenData[i, j] = true;
                    }
                }
            }
        }

        public void nitelikOrtalamasınaGoreDoldur()
        {
            double ortalama = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == "" || dataGridView1.Rows[j].Cells[i].Value == null)
                    {
                        ortalama = ortalamaHesaplaSutun(i);
                        dataGridView1.Rows[j].Cells[i].Value = Math.Round(ortalama, 1);
                    }
                }
            }
        }

        public void orneklemOrtalamasınaGoreDoldur()
        {
            double ortalama = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == "" || dataGridView1.Rows[j].Cells[i].Value == null)
                    {
                        ortalama = ortalamaHesaplaSatır(j);
                        dataGridView1.Rows[j].Cells[i].Value = Math.Round(ortalama, 1);
                    }
                }
            }
        }

        public void oklidUzaklıgaGoreDoldur(string a)
        {
            int k = Convert.ToInt32(a);
            double ortalama = 0;
            double[] uzaklıkDizi;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == "" || dataGridView1.Rows[j].Cells[i].Value == null)
                    {
                        uzaklıkDizi = uzaklıkHesapla(j, k);
                        uzaklıkDizi = diziSıralama(uzaklıkDizi);
                        for (int m = 1; m <= k; m++)
                        {
                            ortalama += uzaklıkDizi[m];
                        }
                        ortalama = ortalama / k;
                        dataGridView1.Rows[j].Cells[i].Value = Math.Round(ortalama, 1);
                    }
                }
            }

        }

        public double[] uzaklıkHesapla(int satir, int k)
        {
            double uzaklık = 0;
            double[] uzaklıkDizi = new double[dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (!(dataGridView1.Rows[i].Cells[j].Value == "" || dataGridView1.Rows[satir].Cells[j].Value == ""))
                        uzaklık += Math.Pow((Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) - Convert.ToDouble(dataGridView1.Rows[satir].Cells[j].Value)), 2);
                }
                uzaklıkDizi[i] = Math.Sqrt(uzaklık);
                uzaklık = 0;
            }

            return uzaklıkDizi;
        }

        public double[] diziSıralama(double[] dizi)
        {
            double tut = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[j] < dizi[i])
                    {
                        tut = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = tut;
                    }
                }
            }
            return dizi;
        }

        public double ortalamaHesaplaSatır(int satir)
        {
            double toplam = 0;
            int nullsayisi = 0;
            int bossayisi = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Rows[satir].Cells[i].Value != null)
                {
                    if (dataGridView1.Rows[satir].Cells[i].Value != "" && dataGridView1.Rows[satir].Cells[i].Value != null)
                        toplam += Convert.ToDouble(dataGridView1.Rows[satir].Cells[i].Value.ToString());
                    else
                        bossayisi++;
                }
                else
                    nullsayisi++;
            }
            double ortalama = toplam / (dataGridView1.ColumnCount - bossayisi);
            return ortalama;
        }

        public double ortalamaHesaplaSutun(int sutun)
        {
            double toplam = 0;
            int bossayisi = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[sutun].Value != "" && dataGridView1.Rows[i].Cells[sutun].Value != null)
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[sutun].Value.ToString());
                else
                    bossayisi++;
            }
            double ortalama = toplam / ((dataGridView1.RowCount - 1) - bossayisi);
            return ortalama;
        }

        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialaog = new OpenFileDialog();
            openFileDialaog.Title = "Dosya Aç";
            openFileDialaog.Filter = "Exel |*.xlsx";
            cbIller.Items.Clear();
            if (openFileDialaog.ShowDialog() == DialogResult.OK)
            {
                verioku = new VeriOku(openFileDialaog.FileName);
                List<string> iller = verioku.iller();
                for (int i = 0; i < iller.Count; i++)
                {
                    cbIller.Items.Add(iller[i]);
                }
            }

        }

        private void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (verioku != null)
            {
                int indis = cbIller.SelectedIndex;
                List<string[]> satirlar = verioku.ilVerileri(indis, 12, 44);
                gridDoldur(satirlar);
            }
        }

        public void gridDoldur(List<string[]> satirlar)
        {
            satir = satirlar.Count - 2;
            sutun = satirlar[0].Length;
            yedekDataGrid = new string[satir, sutun];
            silinenData=new bool[satir, sutun];
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int columnsCount = satirlar[0].Length;
            for (int i = 0; i < columnsCount; i++)
            {
                dataGridView1.Columns.Add("kolonlar", (i + 1) + ".");
            }
            for (int i = 0; i < satirlar.Count - 2; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < columnsCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = satirlar[i][j];
                    yedekDataGrid[i, j] = satirlar[i][j];
                    silinenData[i, j] = true;
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_EksikVeriBul_Click(object sender, EventArgs e)
        {
            int eksikVeriSayisi = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == "" || dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        eksikVeriSayisi++;
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Wheat;
                    }
                }
            }
            MessageBox.Show(eksikVeriSayisi + " adet veri eksik");
        }

        private void btnEksikVerileriDoldur_Click(object sender, EventArgs e)
        {
            nitelikOrtalamasınaGoreDoldur();
            dogrulukKarsilastir();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double toplam = 0;
            int bossayisi = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[e.ColumnIndex].Value != "" && dataGridView1.Rows[i].Cells[e.ColumnIndex].Value != null)
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[e.ColumnIndex].Value.ToString());
                else
                    bossayisi++;
            }
            double ortalama = toplam / ((dataGridView1.RowCount - 1) - bossayisi);
            labelToplam.Text = (e.ColumnIndex + 1) + ". sütün toplamı: " + toplam;
            labelOrtalama.Text = (e.ColumnIndex + 1) + ". sütün ortalaması: " + ortalama;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double toplam = 0;
            int bossayisi = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[i].Value != "" && dataGridView1.Rows[e.RowIndex].Cells[i].Value != null)
                    toplam += Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString());
                else
                    bossayisi++;
            }
            double ortalama = toplam / (dataGridView1.ColumnCount - bossayisi);
            labelToplam.Text = (e.RowIndex + 1) + ". satır toplamı: " + toplam;
            labelOrtalama.Text = (e.RowIndex + 1) + ". satır ortalaması: " + ortalama;
        }

        private void btnEnYakınaGore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxKDegeri.Text))
                oklidUzaklıgaGoreDoldur("3");
            else
                oklidUzaklıgaGoreDoldur(textboxKDegeri.Text);
            dogrulukKarsilastir();
        }
        

        private void btnOrneklemOrtalamasınaGoreDoldur_Click(object sender, EventArgs e)
        {
            orneklemOrtalamasınaGoreDoldur();
            dogrulukKarsilastir();
        }

        private void btnDemetleme_Click(object sender, EventArgs e)
        {
            int bolmeGenisligi;
            if (textboxBolmeGenisligi.Text == "")
                bolmeGenisligi = 3;
            else
                bolmeGenisligi = Convert.ToInt32(textboxBolmeGenisligi.Text);

            List<double[]> list = new List<double[]>();
            List<double[]> list1 = new List<double[]>();
            double[] dizi;

            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                dizi = new double[dataGridView1.RowCount - 1];
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dizi[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                }
                list.Add(dizi);
                list1.Add(dizi);
            }
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = diziSıralama(list[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j += bolmeGenisligi)
                {
                    double ort = 0;
                    for (int k = 0; k < bolmeGenisligi; k++)
                    {
                        if (j + k < list[i].Length)
                            ort += (list[i][j + k]);
                    }
                    ort = ort / bolmeGenisligi;
                    for (int k = 0; k < bolmeGenisligi; k++)
                    {
                        if (j + k < list[i].Length)
                            list1[i][j + k] = ort;
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value =Math.Round(list1[i][j],1);
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            secilenListBox = false;
            listBox1.BackColor = Color.Wheat;
            listBox2.BackColor = Color.White;
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            secilenListBox = true;
            listBox1.BackColor = Color.White;
            listBox2.BackColor = Color.Wheat;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                silinenData[e.RowIndex, e.ColumnIndex] = false;
            }
        }
    }
}