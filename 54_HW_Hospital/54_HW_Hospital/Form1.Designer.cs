
namespace _54_HW_Hospital
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBransEkle = new System.Windows.Forms.Button();
            this.txtBransAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDoktor = new System.Windows.Forms.GroupBox();
            this.cbxBrans1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRandevu = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxDoktor = new System.Windows.Forms.ComboBox();
            this.cbxBrans2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flw = new System.Windows.Forms.FlowLayoutPanel();
            this.lvChart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.gbDoktor.SuspendLayout();
            this.gbRandevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBransEkle);
            this.groupBox1.Controls.Add(this.txtBransAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branş";
            // 
            // btnBransEkle
            // 
            this.btnBransEkle.Location = new System.Drawing.Point(53, 89);
            this.btnBransEkle.Name = "btnBransEkle";
            this.btnBransEkle.Size = new System.Drawing.Size(179, 23);
            this.btnBransEkle.TabIndex = 2;
            this.btnBransEkle.Text = "BRANŞ EKLE";
            this.btnBransEkle.UseVisualStyleBackColor = true;
            this.btnBransEkle.Click += new System.EventHandler(this.btnBransEkle_Click);
            // 
            // txtBransAdi
            // 
            this.txtBransAdi.Location = new System.Drawing.Point(53, 62);
            this.txtBransAdi.Name = "txtBransAdi";
            this.txtBransAdi.Size = new System.Drawing.Size(179, 20);
            this.txtBransAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Adı";
            // 
            // gbDoktor
            // 
            this.gbDoktor.Controls.Add(this.cbxBrans1);
            this.gbDoktor.Controls.Add(this.button1);
            this.gbDoktor.Controls.Add(this.txtDoktorAdi);
            this.gbDoktor.Controls.Add(this.label2);
            this.gbDoktor.Location = new System.Drawing.Point(388, 13);
            this.gbDoktor.Name = "gbDoktor";
            this.gbDoktor.Size = new System.Drawing.Size(317, 173);
            this.gbDoktor.TabIndex = 1;
            this.gbDoktor.TabStop = false;
            this.gbDoktor.Text = "Doktor Ekle";
            // 
            // cbxBrans1
            // 
            this.cbxBrans1.FormattingEnabled = true;
            this.cbxBrans1.Location = new System.Drawing.Point(29, 77);
            this.cbxBrans1.Name = "cbxBrans1";
            this.cbxBrans1.Size = new System.Drawing.Size(179, 21);
            this.cbxBrans1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "DOKTOR EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(29, 50);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(179, 20);
            this.txtDoktorAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doktor Adı";
            // 
            // gbRandevu
            // 
            this.gbRandevu.Controls.Add(this.dateTimePicker1);
            this.gbRandevu.Controls.Add(this.cbxDoktor);
            this.gbRandevu.Controls.Add(this.cbxBrans2);
            this.gbRandevu.Controls.Add(this.label8);
            this.gbRandevu.Controls.Add(this.label7);
            this.gbRandevu.Controls.Add(this.txtSoyad);
            this.gbRandevu.Controls.Add(this.label6);
            this.gbRandevu.Controls.Add(this.label5);
            this.gbRandevu.Controls.Add(this.txtAd);
            this.gbRandevu.Controls.Add(this.label4);
            this.gbRandevu.Controls.Add(this.txtTcKimlikNo);
            this.gbRandevu.Controls.Add(this.label3);
            this.gbRandevu.Location = new System.Drawing.Point(24, 206);
            this.gbRandevu.Name = "gbRandevu";
            this.gbRandevu.Size = new System.Drawing.Size(358, 216);
            this.gbRandevu.TabIndex = 2;
            this.gbRandevu.TabStop = false;
            this.gbRandevu.Text = "Randevu Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbxDoktor
            // 
            this.cbxDoktor.FormattingEnabled = true;
            this.cbxDoktor.Location = new System.Drawing.Point(102, 143);
            this.cbxDoktor.Name = "cbxDoktor";
            this.cbxDoktor.Size = new System.Drawing.Size(179, 21);
            this.cbxDoktor.TabIndex = 3;
            // 
            // cbxBrans2
            // 
            this.cbxBrans2.FormattingEnabled = true;
            this.cbxBrans2.Location = new System.Drawing.Point(102, 116);
            this.cbxBrans2.Name = "cbxBrans2";
            this.cbxBrans2.Size = new System.Drawing.Size(179, 21);
            this.cbxBrans2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tarih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doktorunu seç";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(102, 86);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(179, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Branş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(102, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(179, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(102, 34);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(179, 20);
            this.txtTcKimlikNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tc Kimlik No";
            // 
            // flw
            // 
            this.flw.Location = new System.Drawing.Point(388, 215);
            this.flw.Name = "flw";
            this.flw.Size = new System.Drawing.Size(317, 207);
            this.flw.TabIndex = 3;
            // 
            // lvChart
            // 
            this.lvChart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvChart.GridLines = true;
            this.lvChart.HideSelection = false;
            this.lvChart.Location = new System.Drawing.Point(24, 442);
            this.lvChart.Name = "lvChart";
            this.lvChart.Size = new System.Drawing.Size(681, 188);
            this.lvChart.TabIndex = 4;
            this.lvChart.UseCompatibleStateImageBehavior = false;
            this.lvChart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hasta Adı";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta Soyadı";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Branş";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doktor";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Randevu Tarihi";
            this.columnHeader5.Width = 113;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 655);
            this.Controls.Add(this.lvChart);
            this.Controls.Add(this.flw);
            this.Controls.Add(this.gbRandevu);
            this.Controls.Add(this.gbDoktor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDoktor.ResumeLayout(false);
            this.gbDoktor.PerformLayout();
            this.gbRandevu.ResumeLayout(false);
            this.gbRandevu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBransEkle;
        private System.Windows.Forms.TextBox txtBransAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDoktor;
        private System.Windows.Forms.ComboBox cbxBrans1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbRandevu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxDoktor;
        private System.Windows.Forms.ComboBox cbxBrans2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flw;
        private System.Windows.Forms.ListView lvChart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

