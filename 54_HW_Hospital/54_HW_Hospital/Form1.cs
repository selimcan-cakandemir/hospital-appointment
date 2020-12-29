using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_HW_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //EVENTS
        private void Form1_Load(object sender, EventArgs e)
        {
            gbDoktor.Visible = false;
            gbRandevu.Visible = false;
            flw.Visible = false;
            lvChart.Visible = false;            
        }
        private void btnBransEkle_Click(object sender, EventArgs e)
        {            
            BransEkle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoktorEkle();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TarihSec();
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            lvChart.Visible = true;
            Button btn = (Button)sender;
            btn.Enabled = false;
            btn.BackColor = Color.Red;
            MessageBox.Show("Randevu oluşturuldu");
            Randevu randevu = new Randevu();
            randevu = RandevuOlustur(randevu);
            ListViewItem lvi = ListViewItemDoldur(randevu);
            lvChart.Items.Add(lvi);
        }
        //METHODS
        public void BransEkle()
        {
            if (txtBransAdi.Text == "")
            {
                MessageBox.Show("Lütfen branş ismi ekleyeniz");
            }
            else
            {
                cbxDoktor.Items.Clear();
                cbxBrans1.Items.Clear();
                cbxBrans2.Items.Clear();
                Brans brans = new Brans();
                brans.BransName = txtBransAdi.Text;
                Brans.BransList.Add(brans);
                cbxBrans1.Items.Add(brans.BransName);               
                cbxBrans2.Items.Add(brans.BransName);
                cbxBrans2.Text = "";
                cbxDoktor.Text = "";
                txtBransAdi.Text = "";
                gbDoktor.Visible = true;
                
            }
            
        }
        public void DoktorEkle()
        {
            if(txtDoktorAdi.Text == "" && cbxBrans1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen doktor ismi ekleyeniz ve branş seçiniz");
            }
            else if(txtDoktorAdi.Text == "")
            {
                MessageBox.Show("Lütfen doktor ismi ekleyeniz");
            }
            else if(cbxBrans1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen branş seçiniz");
            }
            else
            {
                Doktor doktor = new Doktor();
                doktor.DoktorName = txtDoktorAdi.Text;
                Doktor.DoktorList.Add(doktor);
                txtDoktorAdi.Text = "";
                gbRandevu.Visible = true;
                cbxDoktor.Items.Add(doktor.DoktorName);
                cbxBrans1.Text = "";
            }
            
        }
        public void TarihSec()
        {
            
            if (txtTcKimlikNo.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || cbxBrans2.SelectedIndex == -1 || cbxDoktor.SelectedIndex == -1 || dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Randevu bilgilerinin hepsini doldurunuz ve bugünden önce bir tarih seçmediğinize emin olunuz");
            }
            else
            {               
                ButtonEkle();
            }
        }
        public void ButtonEkle()
        {
            flw.Controls.Clear();
            decimal saat = 10.00m;
            flw.Visible = true;
            for (int i = 1; i <= 8; i++)
            {
                Button btn = new Button();
                saat += 1;
                btn.Text = saat.ToString();
                flw.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
            
        }
        public Randevu RandevuOlustur(Randevu r)
        {
            r.TcKimlikNo = txtTcKimlikNo.Text;
            r.Ad = txtAd.Text;
            r.Soyad = txtSoyad.Text;
            r.Brans = cbxBrans2.SelectedItem.ToString();
            r.Doktor = cbxDoktor.SelectedItem.ToString();
            r.Tarih = dateTimePicker1.Value;
            return r;
        }
        public ListViewItem ListViewItemDoldur (Randevu r)
        {
            string[] bilgiler = { r.Ad, r.Soyad, r.Brans, r.Doktor, r.Tarih.ToShortDateString() };
            ListViewItem lvi = new ListViewItem(bilgiler);
            return lvi;
        }
    }
}







