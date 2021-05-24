using System;
using System.Collections;
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
    public partial class Kutu : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=GRAFIK2\\SQLEXPRESS;Initial Catalog=PM_MaliyetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        KutuMaliyet kutu = new KutuMaliyet();
        MukavvaBilgileri mukavvaBilgileri = new MukavvaBilgileri();
        public Kutu()
        {
            try
            {
                InitializeComponent();
                KutuMukavvaTurCbx();
                KutuMukavvaAdetCbx();
                KagitModeliCbx();
                BaskiTuruCbx();
            }
            catch (Exception)
            {

                throw;
            }
            

           
        }

        //-------------------------------------------ComboboxlarınDoldurulması--------------------------------------------------
        public void KutuMukavvaTurCbx()
        {
            string BaseQuery = "SELECT  mukavvaTuru FROM  [PM_MaliyetDB].[dbo].[Mukavva]";

            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {
                kutuMukavvaTuruCbx.Items.Add(rdr["mukavvaTuru"]);
            }
            baglanti.Close();


        }

        public void KutuMukavvaAdetCbx()
        {
            string BaseQuery = "SELECT BireKacAd FROM[PM_MaliyetDB].[dbo].[BireKac]";
            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {

                kutuMukavvaAdetiCbx.Items.Add(rdr["BireKacAd"]);
            }
            baglanti.Close();

        }

        public void KagitModeliCbx()
        {
            string BaseQuery = "SELECT [kagitTur] FROM [PM_MaliyetDB].[dbo].[KagitModeli]";

            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {

                kutuKagitModelCbx.Items.Add(rdr["kagitTur"]);
            }
            baglanti.Close();
        }

        public void BaskiTuruCbx()
        {
            string BaseQuery = "SELECT [baskiAd] FROM [PM_MaliyetDB].[dbo].[BaskiTuru]";

            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {

               kutuBaskıTuruCbx.Items.Add(rdr["baskiAd"]);
            }
            baglanti.Close();

        }    
        
 

        public double MukavvaBirimFiyati(String mukkavvaTuru,String mukavvaAdeti)
        {
           

            kutu.KutuMukavvaFiyati = Convert.ToDouble(kutuMukavvaFiyatitxt.Text);
           

            int gelenMukavvaAdeti = mukavvaBilgileri.MukavvaAdetBilgisi(mukkavvaTuru);
     
            int gekenBirKac = mukavvaBilgileri.BireKacDegerler(mukavvaAdeti);
        

            kutu.KutuMukavvaBirimFiyati = kutu.KutuMukavvaFiyati/ gelenMukavvaAdeti / gekenBirKac;

            return kutu.KutuMukavvaBirimFiyati;
        }


        //----------------------------------------BirimFiyatlarArayüz-----------------------------------------------------------
        private void kutuMukavvaBirimFiyatıtxt_DoubleClick(object sender, EventArgs e)
        {
            kutu.KutuMukavvaTuru = kutuMukavvaTuruCbx.SelectedItem.ToString();
            kutu.KutuMukavvaAdet = kutuMukavvaAdetiCbx.SelectedItem.ToString();
         

            kutu.KutuMukavvaBirimFiyati = MukavvaBirimFiyati(kutu.KutuMukavvaTuru, kutu.KutuMukavvaAdet);
            kutuMukavvaBirimFiyatıtxt.Text = kutu.KutuMukavvaBirimFiyati.ToString();
        }

        

        //--------------------------------------------KutuFiyatlarınıAl----------------------------------------------------------------

        public double BirimFİyatHesapla()
        {
            
                
                var List = new ArrayList();
                kutu.KutuKagitModeliBirimFiyati = Convert.ToDouble(kagitModelBirimFiyatiTxt.Text);
                List.Add(kutu.KutuKagitModeliBirimFiyati);
                kutu.KutuBicakVeKesimFiyati = Convert.ToDouble(kutuBicakveKesimBirimFiyatiTxt.Text);
                List.Add(kutuBicakveKesimBirimFiyatiTxt.Text);
                kutu.KutuRenkMaliyetiFiyati = Convert.ToDouble(kutuRenkTxt.Text);
                List.Add(kutu.KutuRenkMaliyetiFiyati);
                kutu.KutuBaskiTuruBirimFiyati = Convert.ToDouble(baskiTürüBirimFiyatiTxt.Text);
                List.Add(kutu.KutuBaskiTuruBirimFiyati);
                kutu.KutuMetalAksesuarFiyati = Convert.ToDouble(kutuMetalAksesuarTxt.Text);
                List.Add(kutu.KutuMetalAksesuarFiyati);
                kutu.KutuKilitFiyati = Convert.ToDouble(kutuKilitTxt.Text);
                List.Add(kutu.KutuKilitFiyati);
                kutu.KutuLastikFiyati = Convert.ToDouble(kutuLastikTxt.Text);
                List.Add(kutu.KutuLastikFiyati);
                kutu.KutuKagitBaskiFiyati = Convert.ToDouble(kutuKagitBaskiTxt.Text);
                List.Add(kutu.KutuKagitBaskiFiyati);
                kutu.KutuDikisFiyati = Convert.ToDouble(kutuDikisTxt.Text);
                List.Add(kutu.KutuDikisFiyati);
                kutu.KutuFlokFiyati = Convert.ToDouble(kutuFlokTxt.Text);
                List.Add(kutu.KutuFlokFiyati);
                kutu.KutuMiknatisFiyati = Convert.ToDouble(kutuMiknatisTxt.Text);
                List.Add(kutu.KutuMiknatisFiyati);
                kutu.KutuMukavvaBirimFiyati = Convert.ToDouble(kutuMukavvaBirimFiyatıtxt.Text);
                List.Add(kutu.KutuMukavvaBirimFiyati);
                kutu.KutuMDFKasaFiyati = Convert.ToDouble(kutuMDFkasaTxt.Text);
                List.Add(kutu.KutuMDFKasaFiyati);
                kutu.KutuTutkallamaFiyati = Convert.ToDouble(kutuTutkallamaTxt.Text);
                List.Add(kutu.KutuTutkallamaFiyati);
                kutu.KutuSungerFiyati = Convert.ToDouble(kutuSungerTxt.Text);
                List.Add(kutu.KutuSungerFiyati);
                kutu.KutuEvaFiyati = Convert.ToDouble(kutuEvaTxt.Text);
                List.Add(kutu.KutuEvaFiyati);
                kutu.KutuIstifvePaketlemeFiyati = Convert.ToDouble(kutuIstifvePaketTxt.Text);
                List.Add(kutu.KutuIstifvePaketlemeFiyati);


                double Toplam = 0;
                foreach (var item in List)
                {
                    Toplam = Toplam + Convert.ToDouble(item);
                }
                Toplam = Math.Round(Toplam, 4);

                return Toplam;
          
       
        }

        private void kututoplaBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                kututoplamlbl.Text = BirimFİyatHesapla().ToString();
            }
            catch (Exception)
            {

                string[] TextBoxlar = { kagitModelBirimFiyatiTxt.Text, kutuBicakveKesimTxt.Text, kutuRenkTxt.Text, 
                    baskiTürüBirimFiyatiTxt.Text, kutuMetalAksesuarTxt.Text, kutuKilitTxt.Text, kutuLastikTxt.Text, 
                    kutuKagitBaskiTxt.Text,kutuDikisTxt.Text,kutuFlokTxt.Text,kutuMiknatisTxt.Text,kutuMukavvaBirimFiyatıtxt.Text,
                    kutuMDFkasaTxt.Text,kutuTutkallamaTxt.Text,kutuSungerTxt.Text,kutuEvaTxt.Text,kutuIstifvePaketTxt.Text };
                foreach (string item in TextBoxlar)
                {
                    if (item =="" )
                    {

                        MessageBox.Show(" Boş geçilemez");

                        return;

                    }
                }
                

                throw;
            }
            
        }

        private double KarHesaplama()
        {
            Double Toplam = (Convert.ToDouble(kututoplamlbl.Text) * Convert.ToInt32(kutuurunAdeditxt.Text));
            kutu.KutuKarToplami = Toplam + ((Toplam * Convert.ToDouble(kutuKarTxt.Text) / 100));
            return kutu.KutuKarToplami ;
        }

       

        private void kutuSonToplamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                    kutu.KutuUrunAdi = kutuurunAditxt.Text;
                    kutu.KutuUrunAdedi = kutuurunAdeditxt.Text;
                    kutu.KutuKarToplam = KarHesaplama().ToString();
                 
                    string[] bilgiler = { kutu.KutuUrunAdi, kutu.KutuUrunAdedi, kutu.KutuKarToplam };
                    kutuSonuclistView.Items.Add(new ListViewItem(bilgiler));
                
            }
            catch (Exception)
            {
                if (kutuKarTxt.Text == "")
                {

                    MessageBox.Show(" Boş geçilemez");

                    return;

                }

                throw;
            }
            

           

        }
        KurCek kur = new KurCek();
        private void Kutu_Load(object sender, EventArgs e)
        {
            kutuSonuclistView.Columns.Add("Ürün Adi",90);
            kutuSonuclistView.Columns.Add("Ürün Adedi",90);
            kutuSonuclistView.Columns.Add("Kutu Maliyeti",90);
            //kutuSonuclistView.Columns.Add("Kağıt Modeli",90);
            //kutuSonuclistView.Columns.Add("Baskı Türü", 90);
            kutuBirimDolarKurTxt.Text = kur.GetRate("USD").ToString();

        }

        private void yeniHesapBtn_Click(object sender, EventArgs e)
        {
            kutuurunAditxt.Clear();
            kutuurunAdeditxt.Clear();
            kutuKagitModelCbx.Text= "";
            kagitModelBirimFiyatiTxt.Clear();
            kutuBicakveKesimTxt.Clear();
            kutuRenkTxt.Clear();
            kutuBaskıTuruCbx.Text = "";
            baskiTürüBirimFiyatiTxt.Clear();
            kutuBaskiTuruBirimFiyatiLbl.Text =" ";
            kutuMetalAksesuarTxt.Clear();
            kutuKilitTxt.Clear();
            kutuLastikTxt.Clear();
            kutuKagitBaskiTxt.Clear();
            kutuDikisTxt.Clear();
            kutuFlokTxt.Clear();
            kutuMetalAksesuarTxt.Clear();
            kutuMukavvaTuruCbx.Text = "";
            kutuMukavvaAdetiCbx.Text = "";
            kutuMukavvaFiyatitxt.Clear();
            kutuMukavvaBirimFiyatıtxt.Clear();
            kutuMDFkasaTxt.Clear();
            kutuTutkallamaTxt.Clear();
            kutuSungerTxt.Clear();
            kutuEvaTxt.Clear();
            kutuIstifvePaketTxt.Clear();
            kututoplamlbl.Text = "";
            kutuDolarDovizTxt.Clear();
            kutuBirimDolarKurTxt.Clear();
            kutuTlDovizTxt.Clear();
            kutuKarTxt.Clear();
            kutuMiknatisTxt.Clear();
            kutuSonuclistView.Items.Clear();
            kutuKacAlirTxt.Clear();
            kutuurunBoyTxt.Clear();
            kutuurunEntxt.Clear();
            kutuurunYukseklikTxt.Clear();
            kutuBicakveKesimBirimFiyatiTxt.Clear();

        }

       
       

        private void kutuKacAlirTxt_DoubleClick(object sender, EventArgs e)
        {
            kutu.KutuUrunEn = Convert.ToInt32(kutuurunEntxt.Text);
            kutu.KutuUrunBoy = Convert.ToInt32(kutuurunBoyTxt.Text);
            kutu.KutuUrunYukseklik = Convert.ToInt32(kutuurunYukseklikTxt.Text);

            kutu.KutuUrunEn = kutu.KutuUrunEn + (2 * kutu.KutuUrunYukseklik) + 1;
            kutu.KutuUrunBoy = kutu.KutuUrunBoy + (2 * kutu.KutuUrunYukseklik) + 1;

            int uzunKenar = 100, kisaKenar = 70;
            double kaçTane1, kaçtane2;
            double sonuc1 = 0, sonuc2 = 0;
            double kenar1 = kutu.KutuUrunEn;
            double kenar2 = kutu.KutuUrunBoy;


            kaçTane1 = Math.Floor(uzunKenar / kenar1);
            kaçtane2 = Math.Floor(kisaKenar / kenar2);

            sonuc1 = kaçTane1 * kaçtane2;



            kaçTane1 = Math.Floor(uzunKenar / kenar2);
            kaçtane2 = Math.Floor(kisaKenar / kenar1);

            sonuc2 = kaçTane1 * kaçtane2;

            if (sonuc1 > sonuc2)
            {
                kutuKacAlirTxt.Text = sonuc1.ToString();
            }
            else
            {
                kutuKacAlirTxt.Text = sonuc2.ToString();
            }
        }

        private void kutuBicakveKesimBirimFiyatiTxt_DoubleClick(object sender, EventArgs e)
        {
            kutuBicakveKesimBirimFiyatiTxt.Text = (Convert.ToDouble(kutuBicakveKesimTxt.Text)/Convert.ToInt32(kutuurunAdeditxt.Text)).ToString();
        }

        private void kutuKurHesaplaBtn_Click(object sender, EventArgs e)
        {
            kutuTlDovizTxt.Text = Math.Round(Convert.ToDouble(kutuBirimDolarKurTxt.Text) * Convert.ToDouble(kutuDolarDovizTxt.Text), 4).ToString();
        }
    }


}
