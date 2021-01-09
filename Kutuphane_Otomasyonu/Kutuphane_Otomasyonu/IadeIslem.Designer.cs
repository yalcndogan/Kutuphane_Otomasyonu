
namespace Kutuphane_Otomasyonu
{
    partial class IadeIslem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBarkodSorgula = new System.Windows.Forms.TextBox();
            this.btnTesAl = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barkod No Ara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 275);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtBarkodSorgula
            // 
            this.txtBarkodSorgula.Location = new System.Drawing.Point(111, 14);
            this.txtBarkodSorgula.Name = "txtBarkodSorgula";
            this.txtBarkodSorgula.Size = new System.Drawing.Size(295, 20);
            this.txtBarkodSorgula.TabIndex = 6;
            this.txtBarkodSorgula.TextChanged += new System.EventHandler(this.txtBarkodSorgula_TextChanged);
            // 
            // btnTesAl
            // 
            this.btnTesAl.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTesAl.Location = new System.Drawing.Point(412, 12);
            this.btnTesAl.Name = "btnTesAl";
            this.btnTesAl.Size = new System.Drawing.Size(75, 23);
            this.btnTesAl.TabIndex = 7;
            this.btnTesAl.Text = "Teslim Al";
            this.btnTesAl.UseVisualStyleBackColor = false;
            this.btnTesAl.Click += new System.EventHandler(this.btnTesAl_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.Location = new System.Drawing.Point(493, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // IadeIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Otomasyonu.Properties.Resources.bgrep;
            this.ClientSize = new System.Drawing.Size(581, 327);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTesAl);
            this.Controls.Add(this.txtBarkodSorgula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "IadeIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İade İşlemleri";
            this.Load += new System.EventHandler(this.IadeIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkodSorgula;
        private System.Windows.Forms.Button btnTesAl;
        private System.Windows.Forms.Button btnIptal;
    }
}