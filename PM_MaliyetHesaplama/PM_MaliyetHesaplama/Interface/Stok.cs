using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_MaliyetHesaplama
{
    public partial class Stok : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=GRAFIK2\\SQLEXPRESS;Initial Catalog=PM_MaliyetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Stok()
        {
            InitializeComponent();
        }

        
        private void Stok_Load(object sender, EventArgs e)
        {
            stokBaklistView.Columns.Add("Ürün Kodu", 180);
            stokBaklistView.Columns.Add("Ürün Adi", 180);
            stokBaklistView.Columns.Add("Ürün Açıklamasi", 180);
            stokBaklistView.Columns.Add("Ürün Stok Miktarı", 180);
            stokBaklistView.Columns.Add("Birimi", 180);
           
        }

        private void stokAraBtn_Click(object sender, EventArgs e)
        {
            string stokUrunKodu = stokBakUrunKoduTxt.Text;
            string stokUrunAdi = stokBakUrunAdiTxt.Text;
            string stokUrunAciklama;
            double stokUrunMiktari;
            string birim;
           

            string BaseQuery = "SELECT [urunKodu] ,[urunAdi],[urunAciklamasi],[urunStokMiktari],[birim]  FROM [PM_MaliyetDB].[dbo].[Stok] WHERE [urunKodu] = '" + stokUrunKodu + "' or [urunAdi] ='" + stokUrunAdi + "' ";
          
            SqlCommand cmd = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                stokUrunKodu = Convert.ToString((dr["urunKodu"]));
                stokUrunAdi = Convert.ToString((dr["urunAdi"]));
                stokUrunAciklama = Convert.ToString((dr["urunAciklamasi"]));
                stokUrunMiktari = Convert.ToDouble((dr["urunStokMiktari"]));
                birim = Convert.ToString(dr["birim"]);
               

                String[]stokSorgu = {stokUrunKodu, stokUrunAdi,stokUrunAciklama, stokUrunMiktari.ToString(), birim };
                stokBaklistView.Items.Add(new ListViewItem(stokSorgu));


            }



            baglanti.Close();



        }

        private void stokEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string stokUrunKodu = stokEkleUrunKoduTxt.Text;
                string stokUrunAdi = stokEkleUrunAdiTxt.Text;
                string stokUrunAciklama=StokEkleUrunAciklamaTxt.Text;
                double stokUrunMiktari= Convert.ToDouble(stokEkleStokMiktariTxt.Text);
                string birim=stokEkleStokBirimTxt.Text;

                string BaseQuery = "Insert into [PM_MaliyetDB].[dbo].[Stok]  Values(@urunKodu,@urunAdi,@urunAciklamasi,@urunStokMiktari,@birim )";
                SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
                baglanti.Open();
                //MessageBox.Show("Bağlandı");
                Query.Parameters.AddWithValue("@urunKodu", stokUrunKodu);
                Query.Parameters.AddWithValue("@urunAdi", stokUrunAdi);
                Query.Parameters.AddWithValue("@urunAciklamasi", stokUrunAciklama);
                Query.Parameters.AddWithValue("@urunStokMiktari", stokUrunMiktari);
                Query.Parameters.AddWithValue("@birim", birim);
         

                Query.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarı ile Eklendi");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void StokGuncelleBtn_Click(object sender, EventArgs e)
        {
            string stokUrunKodu = stokGüncelleUrunKoduTxt.Text;
            string stokUrunAdi = stokGuncelleUrunAdiTxt.Text;

            double stokUrunMiktari = Convert.ToDouble(StokGuncelleUrunMiktariTxt.Text);
            baglanti.Open();
            string kayit = "update  [PM_MaliyetDB].[dbo].[Stok] set urunStokMiktari=@stokUrunMiktari  where [urunKodu] = '" + stokUrunKodu + "' or [urunAdi] ='" + stokUrunAdi + "'";
           
            SqlCommand komut = new SqlCommand(kayit, baglanti);
           
            komut.Parameters.AddWithValue("@stokUrunMiktari", stokUrunMiktari);
          
            komut.ExecuteNonQuery();
           
            baglanti.Close();
            MessageBox.Show("Bilgiler Güncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stokBaklistView.Items.Clear();
            stokBakUrunKoduTxt.Clear();
            stokEkleStokBirimTxt.Clear();
        }
    }
}
