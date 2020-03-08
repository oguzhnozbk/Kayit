namespace Kayit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.label_tc = new System.Windows.Forms.Label();
            this.label_ad = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label_soyad = new System.Windows.Forms.Label();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_kaydiSil = new System.Windows.Forms.Button();
            this.comboBox_veri = new System.Windows.Forms.ComboBox();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.dataGridView_tumkayitlar = new System.Windows.Forms.DataGridView();
            this.label_data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tumkayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(15, 25);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(116, 20);
            this.textBox_tc.TabIndex = 0;
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Location = new System.Drawing.Point(12, 9);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(110, 13);
            this.label_tc.TabIndex = 1;
            this.label_tc.Text = "T.C. Kimlik Numarası :";
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(12, 48);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(31, 13);
            this.label_ad.TabIndex = 2;
            this.label_ad.Text = "İsim :";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(15, 64);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(116, 20);
            this.textBox_ad.TabIndex = 3;
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(12, 87);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(48, 13);
            this.label_soyad.TabIndex = 4;
            this.label_soyad.Text = "Soyisim :";
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(15, 104);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(116, 20);
            this.textBox_soyad.TabIndex = 5;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(15, 131);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(116, 23);
            this.button_kaydet.TabIndex = 6;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_kaydiSil
            // 
            this.button_kaydiSil.Location = new System.Drawing.Point(506, 52);
            this.button_kaydiSil.Name = "button_kaydiSil";
            this.button_kaydiSil.Size = new System.Drawing.Size(116, 23);
            this.button_kaydiSil.TabIndex = 7;
            this.button_kaydiSil.Text = "Kaydı Sil";
            this.button_kaydiSil.UseVisualStyleBackColor = true;
            this.button_kaydiSil.Click += new System.EventHandler(this.button_kaydiSil_Click);
            // 
            // comboBox_veri
            // 
            this.comboBox_veri.FormattingEnabled = true;
            this.comboBox_veri.Location = new System.Drawing.Point(162, 25);
            this.comboBox_veri.Name = "comboBox_veri";
            this.comboBox_veri.Size = new System.Drawing.Size(460, 21);
            this.comboBox_veri.TabIndex = 8;
            this.comboBox_veri.SelectedIndexChanged += new System.EventHandler(this.comboBox_veri_SelectedIndexChanged);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(15, 161);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(116, 23);
            this.button_guncelle.TabIndex = 9;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // dataGridView_tumkayitlar
            // 
            this.dataGridView_tumkayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tumkayitlar.Location = new System.Drawing.Point(162, 81);
            this.dataGridView_tumkayitlar.Name = "dataGridView_tumkayitlar";
            this.dataGridView_tumkayitlar.Size = new System.Drawing.Size(460, 298);
            this.dataGridView_tumkayitlar.TabIndex = 10;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(159, 387);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(0, 13);
            this.label_data.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 409);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.dataGridView_tumkayitlar);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.comboBox_veri);
            this.Controls.Add(this.button_kaydiSil);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.label_tc);
            this.Controls.Add(this.textBox_tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tumkayitlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_kaydiSil;
        private System.Windows.Forms.ComboBox comboBox_veri;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.DataGridView dataGridView_tumkayitlar;
        private System.Windows.Forms.Label label_data;
    }
}

