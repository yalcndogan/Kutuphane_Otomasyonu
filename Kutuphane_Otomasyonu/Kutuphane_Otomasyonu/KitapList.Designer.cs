
namespace Kutuphane_Otomasyonu
{
    partial class KitapList
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
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 206);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSil.Location = new System.Drawing.Point(623, 29);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(358, 31);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(259, 20);
            this.txtBarkodAra.TabIndex = 7;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Barkod No Ara:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboTur);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.txtRafNo);
            this.groupBox1.Controls.Add(this.txtYayinevi);
            this.groupBox1.Controls.Add(this.txtSayfa);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 264);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Formu";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.Location = new System.Drawing.Point(174, 228);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(58, 23);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.Location = new System.Drawing.Point(111, 228);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(58, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stok Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Raf No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yayınevi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yazar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Barkod No:";
            // 
            // comboTur
            // 
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "Hikaye ",
            "Roman",
            "Öykü",
            "Dergi",
            "Ansiklopedi"});
            this.comboTur.Location = new System.Drawing.Point(111, 149);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(121, 21);
            this.comboTur.TabIndex = 7;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(111, 202);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(121, 20);
            this.txtStok.TabIndex = 6;
            this.txtStok.Text = "0";
            this.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(111, 176);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(121, 20);
            this.txtRafNo.TabIndex = 5;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(111, 97);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(121, 20);
            this.txtYayinevi.TabIndex = 4;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(111, 123);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(121, 20);
            this.txtSayfa.TabIndex = 3;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(111, 71);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(121, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(111, 45);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(111, 19);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(121, 20);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // KitapList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Otomasyonu.Properties.Resources.bgrep;
            this.ClientSize = new System.Drawing.Size(712, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBarkodAra);
            this.MaximizeBox = false;
            this.Name = "KitapList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listeleme Sayfası";
            this.Load += new System.EventHandler(this.KitapList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkod;
    }
}