using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Kayit
{
    public partial class Form1 : Form
    {
        void VeriEkle(string key, string tc, string ad, string soyad)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=FIZIKSELPC\\SQLEXPRESS; Initial Catalog=kayit; Integrated Security=true");
            string komut =
            "open symmetric key [SimetrikDenemeAnahtari] decryption by certificate [SifrelemeSertifikasi]   " +
            "declare @KeyGuid as uniqueidentifier   " +
            "set @KeyGuid = key_guid('" + key + "')  " +
            "insert into kayit_islemi ( tc , ad , soyad )   " +
            "values ( " +
            "encryptbykey(@KeyGuid,N'" + tc + "'),   " +
            "encryptbykey(@KeyGuid,N'" + ad + "'),   " +
            "encryptbykey(@KeyGuid,N'" + soyad + "'))  " +
            "close symmetric key [SimetrikDenemeAnahtari]  ";
            SqlCommand sorgu = new SqlCommand(komut, baglanti);
            try
            {
                baglanti.Open();
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                comboBox_veri.Items.Add(tc);
            }
            catch
            {
                MessageBox.Show("Ekleme işlemi Yapılamadı. Lütfen bilgileri kontrol edip tekrar deneyiniz.");
            }
        }
        void KayitGetir()
        {
            SqlConnection baglanti;
            SqlDataAdapter dAdapter;
            try
            {
                dataGridView_tumkayitlar.DataSource = null;
                baglanti = new SqlConnection("Data Source=FIZIKSELPC\\SQLEXPRESS; Initial Catalog=kayit; Integrated Security=true");
                baglanti.Open();
                string komut = "select * from dbo.kayit_islemi";
                dAdapter = new SqlDataAdapter(komut, baglanti);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, "Kayıtlar");
                if (dSet.Tables[0].Rows.Count == 0)
                {
                    label_data.Text = "Kayit Bulunamadı.";
                    return;
                }
                else
                {
                    label_data.Text = dSet.Tables[0].Rows.Count + " adet kayıt getirildi.";
                    dataGridView_tumkayitlar.DataSource = dSet.Tables["Kayıtlar"];
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata : " + ex);

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=FIZIKSELPC\\SQLEXPRESS; Initial Catalog=kayit; Integrated Security=true");
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from kayit_islemi", baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "kayit_islemi");
            int toplamkayit = ds.Tables["kayit_islemi"].Rows.Count;
            baglanti.Close();

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from kayit_islemi";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox_veri.Items.Add(dr["tc"]);
            }
            baglanti.Close();
            KayitGetir();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            //VeriEkle("SimetrikDenemeAnahtari", textBox_tc.Text, textBox_ad.Text, textBox_soyad.Text);
            string tc = textBox_tc.Text;
            string ad = textBox_ad.Text;
            string soyad = textBox_soyad.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=FIZIKSELPC\\SQLEXPRESS; Initial Catalog=kayit; Integrated Security=true");
            string komut = "insert into kayit_islemi (tc,ad,soyad) values ('" + tc + "','" + ad + "','" + soyad + "')";
            SqlCommand sorgu = new SqlCommand(komut, baglanti);
            try
            {
                baglanti.Open();
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                comboBox_veri.Items.Add(tc);
            }
            catch
            {
                MessageBox.Show("Ekleme işlemi Yapılamadı. Lütfen bilgileri kontrol edip tekrar deneyiniz.");
            }
            KayitGetir();
        }

        private void button_kaydiSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=FIZIKSELPC\\SQLEXPRESS; Initial Catalog=kayit; Integrated Security=true");
            string komut = "delete from kayit_islemi where  tc = '" + comboBox_veri.Text + "'";
            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                comboBox_veri.Items.RemoveAt(comboBox_veri.SelectedIndex);
                MessageBox.Show("Kayıt silinmiştir.");
                comboBox_veri.Text = null;
                textBox_ad.Text = null;
                textBox_soyad.Text = null;
                textBox_tc.Text = null;

            }
            catch
            {
                MessageBox.Show("Kayıt silinemedi.");
            }
            KayitGetir();

        }

        private void comboBox_veri_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=FIZIKSELPC\\SQLEXPRESS; Initial Catalog=kayit; Integrated Security=true");
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from kayit_islemi", baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "kayit_islemi");
            int toplamkayit = ds.Tables["kayit_islemi"].Rows.Count;
            baglanti.Close();
            DataRow kayit = ds.Tables["kayit_islemi"].Rows[comboBox_veri.SelectedIndex];
            textBox_tc.Text = kayit.ItemArray.GetValue(1).ToString();
            textBox_ad.Text = kayit.ItemArray.GetValue(2).ToString();
            textBox_soyad.Text = kayit.ItemArray.GetValue(3).ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=FIZIKSELPC\\SQLEXPRESS; Initial Catalog=kayit; Integrated Security=true");
            string komut = "update kayit_islemi set ad ='" + textBox_ad.Text + "' , soyad ='" + textBox_soyad.Text + "' where  tc = '" + comboBox_veri.Text + "'";
            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt güncellenmiştir.");

            }
            catch
            {
                MessageBox.Show("Kayıt güncellenemedi.");
            }
            KayitGetir();
        }
    }
}
