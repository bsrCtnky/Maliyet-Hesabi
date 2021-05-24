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
    public partial class Canta : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=GRAFIK2\\SQLEXPRESS;Initial Catalog=PM_MaliyetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        CantaAttribute canta = new CantaAttribute();
        MukavvaBilgileri mukavvaBilgileri = new MukavvaBilgileri();
        public Canta()
        {
            InitializeComponent();
            KutuMukavvaTurCbx();
            KutuMukavvaAdetCbx();




        }

        //---------------------------------------------BOYUT GİRME KISMI--------------------------------------------------------------
        private void cantaKacAlirTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaUrunEn = Convert.ToInt32(cantaUrunEntxt.Text);
            canta.CantaUrunBoy = Convert.ToInt32(cantaUrunBoyTxt.Text);

            if (canta.CantaUrunEn == 28 && canta.CantaUrunBoy == 40)
            {
                cantaKacAlirTxt.Text = BireKacAlirYeni(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());
            }
            else
            {
                cantaKacAlirTxt.Text= BireKacAlir(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());

            }
            

        }
        private void cantaMukavva2KacAlırTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaUrunEn = Convert.ToInt32(cantaMukavva2EnTxt.Text);
            canta.CantaUrunBoy = Convert.ToInt32(cantaMukavva2BoyTxt.Text);

            if (canta.CantaUrunEn == 28 && canta.CantaUrunBoy == 40)
            {
                cantaMukavva2KacAlırTxt.Text = BireKacAlirYeni(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());
            }
            else
            {
                cantaMukavva2KacAlırTxt.Text = BireKacAlir(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());

            }
        }

        private void cantaMukavva3KacAlırTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaUrunEn = Convert.ToInt32(cantaMukavva3EnTxt.Text);
            canta.CantaUrunBoy = Convert.ToInt32(cantaMukavva3BoyTxt.Text);

            if (canta.CantaUrunEn == 28 && canta.CantaUrunBoy == 40)
            {
                cantaMukavva3KacAlırTxt.Text = BireKacAlirYeni(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());
            }
            else
            {
                cantaMukavva3KacAlırTxt.Text = BireKacAlir(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());

            }
        }

        private void cantaMukavva4KacAlırTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaUrunEn = Convert.ToInt32(cantaMukavva4EnTxt.Text);
            canta.CantaUrunBoy = Convert.ToInt32(cantaMukavva4BoyTxt.Text);

            if (canta.CantaUrunEn == 28 && canta.CantaUrunBoy == 40)
            {
                cantaMukavva4KacAlırTxt.Text = BireKacAlirYeni(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());
            }
            else
            {
                cantaMukavva4KacAlırTxt.Text = BireKacAlir(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());

            }
        }

        private void cantaMukavva5KacAlırTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaUrunEn = Convert.ToInt32(cantaMukavva5EnTxt.Text);
            canta.CantaUrunBoy = Convert.ToInt32(cantaMukavva5BoyTxt.Text);

            if (canta.CantaUrunEn == 28 && canta.CantaUrunBoy == 40)
            {
                cantaMukavva5KacAlırTxt.Text = BireKacAlirYeni(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());
            }
            else
            {
                cantaMukavva5KacAlırTxt.Text = BireKacAlir(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());

            }
        }

        private void cantaMukavva6KacAlırTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaUrunEn = Convert.ToInt32(cantaMukavva6EnTxt.Text);
            canta.CantaUrunBoy = Convert.ToInt32(cantaMukavva6BoyTxt.Text);

            if (canta.CantaUrunEn == 28 && canta.CantaUrunBoy == 40)
            {
                cantaMukavva6KacAlırTxt.Text = BireKacAlirYeni(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());
            }
            else
            {
                cantaMukavva6KacAlırTxt.Text = BireKacAlir(canta.CantaUrunEn.ToString(), canta.CantaUrunBoy.ToString());

            }
        }
        

        public string BireKacAlir(string en, string boy)
        {
            canta.CantaUrunEn = Convert.ToInt32(en);
            canta.CantaUrunBoy = Convert.ToInt32(boy);
            string kacAlir;

            canta.CantaUrunEn = canta.CantaUrunEn;
            canta.CantaUrunBoy = canta.CantaUrunBoy;

            int uzunKenar = 100, kisaKenar = 70;
            double kacTane1, kactane2;
            double sonuc1 = 0, sonuc2 = 0;
            double kenar1 = canta.CantaUrunEn;
            double kenar2 = canta.CantaUrunBoy;


            kacTane1 = Math.Floor(uzunKenar / kenar1);
            kactane2 = Math.Floor(kisaKenar / kenar2);


            sonuc1 = Math.Floor(kacTane1 * kactane2);




            kacTane1 = Math.Floor(uzunKenar / kenar2);
            kactane2 = Math.Floor(kisaKenar / kenar1);


            sonuc2 = Math.Floor(kacTane1 * kactane2);


            if (sonuc1 > sonuc2)
            {
                kacAlir = sonuc1.ToString();
                return kacAlir;

            }
            else
            {
                kacAlir = sonuc2.ToString();
                return kacAlir;
            }
        }

        public string BireKacAlirYeni(string en, string boy)
        {
            canta.CantaUrunEn = Convert.ToInt32(en);
            canta.CantaUrunBoy = Convert.ToInt32(boy);
            string kacAlir;

            int uzunKenar = 100, kisaKenar = 70;
            double kacTane1, kactane2;
           
            double kenar1 = canta.CantaUrunEn;
            double kenar2 = canta.CantaUrunBoy;
           


            kacTane1 = Math.Floor(uzunKenar / kenar2);

            kisaKenar=kisaKenar-Convert.ToInt32(kenar1);

            if (kisaKenar > kenar2)
            {
                kactane2 = Math.Floor(uzunKenar / kenar1);
                kacAlir = (kacTane1 + kactane2).ToString();
                return kacAlir;
            }
            else return BireKacAlir(en, boy);
            //else if()
            //{
            //    kactane2 = Math.Floor(uzunKenar / kenar2);
            //    cantaKacAlirTxt.Text = (kacTane1 + kactane2).ToString();
            //}



        }



        //---------------------------------------------MUKAVVA KISMI-------------------------------------------------------------------

        public void KutuMukavvaTurCbx()
        {
            string BaseQuery = "SELECT  mukavvaTuru FROM  [PM_MaliyetDB].[dbo].[Mukavva]";

            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {
                cantaMukavvaTuruCbx.Items.Add(rdr["mukavvaTuru"]);
                cantaMukavva2TuruCbx.Items.Add(rdr["mukavvaTuru"]);
                cantaMukavva3TuruCbx.Items.Add(rdr["mukavvaTuru"]);
                cantaMukavva4TuruCbx.Items.Add(rdr["mukavvaTuru"]);
                cantaMukavva5TuruCbx.Items.Add(rdr["mukavvaTuru"]);
                cantaMukavva6TuruCbx.Items.Add(rdr["mukavvaTuru"]);
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

                cantaMukavvaAdetiCbx.Items.Add(rdr["BireKacAd"]);
                cantaMukavva2AdetiCbx.Items.Add(rdr["BireKacAd"]);
                cantaMukavva3AdetiCbx.Items.Add(rdr["BireKacAd"]);
                cantaMukavva4AdetiCbx.Items.Add(rdr["BireKacAd"]);
                cantaMukavva5AdetiCbx.Items.Add(rdr["BireKacAd"]);
                cantaMukavva6AdetiCbx.Items.Add(rdr["BireKacAd"]);
            }
            baglanti.Close();

        }
        public double MukavvaBirimFiyati(String mukkavvaTuru, String mukavvaAdeti,string mukavvaFiyati)
        {


            canta.CantaMukavvaFiyati = Convert.ToDouble(mukavvaFiyati);


            int gelenMukavvaAdeti = mukavvaBilgileri.MukavvaAdetBilgisi(mukkavvaTuru);

            int gekenBirKac = mukavvaBilgileri.BireKacDegerler(mukavvaAdeti);


            canta.CantaMukavvaBirimFiyati = canta.CantaMukavvaFiyati / gelenMukavvaAdeti / gekenBirKac;

            return canta.CantaMukavvaBirimFiyati;
        }
        private void cantaMukavvaBirimFiyatıtxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaMukavvaTuru = cantaMukavvaTuruCbx.SelectedItem.ToString();
            canta.CantaMukavvaAdet = cantaMukavvaAdetiCbx.SelectedItem.ToString();
            string mukavvaFiyati = cantaMukavvaFiyatitxt.Text;


            canta.CantaMukavvaBirimFiyati = MukavvaBirimFiyati(canta.CantaMukavvaTuru, canta.CantaMukavvaAdet,mukavvaFiyati);
            cantaMukavvaBirimFiyatıtxt.Text = canta.CantaMukavvaBirimFiyati.ToString();
        }
        private void cantaMukavva2BirimFiyatıtxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaMukavvaTuru = cantaMukavva2TuruCbx.SelectedItem.ToString();
            canta.CantaMukavvaAdet = cantaMukavva2AdetiCbx.SelectedItem.ToString();
            string mukavvaFiyati = cantaMukavva2Fiyatitxt.Text;


            canta.CantaMukavvaBirimFiyati = MukavvaBirimFiyati(canta.CantaMukavvaTuru, canta.CantaMukavvaAdet, mukavvaFiyati);
            cantaMukavva2BirimFiyatıtxt.Text = canta.CantaMukavvaBirimFiyati.ToString();
        }

        private void cantaMukavva3BirimFiyatıtxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaMukavvaTuru = cantaMukavva3TuruCbx.SelectedItem.ToString();
            canta.CantaMukavvaAdet = cantaMukavva3AdetiCbx.SelectedItem.ToString();
            string mukavvaFiyati = cantaMukavva3Fiyatitxt.Text;


            canta.CantaMukavvaBirimFiyati = MukavvaBirimFiyati(canta.CantaMukavvaTuru, canta.CantaMukavvaAdet, mukavvaFiyati);
            cantaMukavva3BirimFiyatıtxt.Text = canta.CantaMukavvaBirimFiyati.ToString();
        }

        private void cantaMukavva4BirimFiyatıtxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaMukavvaTuru = cantaMukavva4TuruCbx.SelectedItem.ToString();
            canta.CantaMukavvaAdet = cantaMukavva4AdetiCbx.SelectedItem.ToString();
            string mukavvaFiyati = cantaMukavva4Fiyatitxt.Text;


            canta.CantaMukavvaBirimFiyati = MukavvaBirimFiyati(canta.CantaMukavvaTuru, canta.CantaMukavvaAdet, mukavvaFiyati);
            cantaMukavva4BirimFiyatıtxt.Text = canta.CantaMukavvaBirimFiyati.ToString();
        }

        private void cantaMukavva5BirimFiyatıtxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaMukavvaTuru = cantaMukavva5TuruCbx.SelectedItem.ToString();
            canta.CantaMukavvaAdet = cantaMukavva5AdetiCbx.SelectedItem.ToString();
            string mukavvaFiyati = cantaMukavva5Fiyatitxt.Text;


            canta.CantaMukavvaBirimFiyati = MukavvaBirimFiyati(canta.CantaMukavvaTuru, canta.CantaMukavvaAdet, mukavvaFiyati);
            cantaMukavva5BirimFiyatıtxt.Text = canta.CantaMukavvaBirimFiyati.ToString();
        }

        private void cantaMukavva6BirimFiyatıtxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaMukavvaTuru = cantaMukavva6TuruCbx.SelectedItem.ToString();
            canta.CantaMukavvaAdet = cantaMukavva6AdetiCbx.SelectedItem.ToString();
            string mukavvaFiyati = cantaMukavva6Fiyatitxt.Text;


            canta.CantaMukavvaBirimFiyati = MukavvaBirimFiyati(canta.CantaMukavvaTuru, canta.CantaMukavvaAdet, mukavvaFiyati);
            cantaMukavva6BirimFiyatıtxt.Text = canta.CantaMukavvaBirimFiyati.ToString();
        }

        //-----------------------------------------------------------------------------------------------------------------------------
        public double MetreBirimFiyati(double metreFiyati, double kullanilanCm)
        {
            double birimFiyat = 0;
            double standartBoy = 100;

            double kaçtane = Math.Floor(standartBoy / kullanilanCm);
            birimFiyat = metreFiyati / kaçtane;





            return Math.Round(birimFiyat, 2);

        }

        

        //-----------------------------------------------------------------------------------------------------------------------------

        private void cantaSungerBirimFiyatTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaSungerEn = Convert.ToDouble(cantaSungerEnTxt.Text);
            canta.CantaSungerBoy = Convert.ToDouble(cantaSungerBoyTxt.Text);


            canta.CantaSungerEn = canta.CantaSungerEn + 1;
            canta.CantaSungerBoy = canta.CantaSungerBoy + 1;

            int uzunKenar = 238, kisaKenar = 138;
            double kaçTane1, kaçtane2;
            double sonuc1 = 0, sonuc2 = 0;
            double kenar1 = canta.CantaSungerEn;
            double kenar2 = canta.CantaSungerBoy;


            kaçTane1 = Math.Floor(uzunKenar / kenar1);
            kaçtane2 = Math.Floor(kisaKenar / kenar2);

            sonuc1 = kaçTane1 * kaçtane2;



            kaçTane1 = Math.Floor(uzunKenar / kenar2);
            kaçtane2 = Math.Floor(kisaKenar / kenar1);

            sonuc2 = kaçTane1 * kaçtane2;

            if (sonuc1 > sonuc2)
            {
                canta.CantaSungerFiyati = Convert.ToDouble(cantaSungerFiyatTxt.Text);
                canta.CantaSurgutBirimFiyati = canta.CantaSungerFiyati / sonuc1;
                cantaSungerBirimFiyatTxt.Text = Math.Round(canta.CantaSurgutBirimFiyati, 2).ToString();


            }
            else
            {
                canta.CantaSungerFiyati = Convert.ToDouble(cantaSungerFiyatTxt.Text);
                canta.CantaSurgutBirimFiyati = canta.CantaSungerFiyati / sonuc2;
                cantaSungerBirimFiyatTxt.Text =Math.Round( canta.CantaSurgutBirimFiyati,2).ToString();
            }
        }

        private void cantaAstarBirimFiyatTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaAstarBirimFiyati = Convert.ToDouble(cantaAstarMetreFiyatiTxt.Text) * Convert.ToDouble(cantaAstarKullanilanMiktarTxt.Text);

            cantaAstarBirimFiyatTxt.Text = (Math.Round(canta.CantaAstarBirimFiyati, 2)).ToString();
        }

        private void cantaDenyaBirimFiyatTxt_DoubleClick(object sender, EventArgs e)
        {


            canta.CantaDenyaBirimFiyati = Convert.ToDouble(cantaDenyaMetreFiyatiTxt.Text) * Convert.ToDouble(cantaDenyaKullanilanMiktarTxt.Text);


            cantaDenyaBirimFiyatTxt.Text = (Math.Round(canta.CantaDenyaBirimFiyati, 2)).ToString();
        }

        private void cantaSkayBirimFiyatTxt_DoubleClick(object sender, EventArgs e)
        {
            //canta.CantaSkayEn = Convert.ToDouble(cantaSkayEnTxt.Text);
            //canta.CantaSkayBoy = Convert.ToDouble(cantaSkayMetreFiyatiTxt.Text);

            //double skayStandartEn = 140;
            //double skayStandartBoy = 100;

            //double gelenAlan = canta.CantaSkayEn * canta.CantaSkayBoy;
            //double kacCm = gelenAlan / skayStandartEn;


            //double kacTane = skayStandartBoy / kacCm;

            //canta.CantaSkayFiyati = Convert.ToDouble(cantaSkayKullanilanMiktarTxt.Text);
            //canta.CantaSkayBirimFiyati = canta.CantaSkayFiyati / kacTane;

            canta.CantaSkayBirimFiyati= Convert.ToDouble(cantaSkayMetreFiyatiTxt.Text) * Convert.ToDouble(cantaSkayKullanilanMiktarTxt.Text);


            cantaSkayBirimFiyatTxt.Text = (Math.Round(canta.CantaSkayBirimFiyati, 2)).ToString();
        }

        private void cantaLastikBirimFiyatiTxt_DoubleClick(object sender, EventArgs e)
        {
            cantaLastikBirimFiyatiTxt.Text = MetreBirimFiyati(Convert.ToDouble(cantaLastikMetreFiyatiTxt.Text), Convert.ToDouble(cantaLastikKullanilanMiktarTxt.Text)).ToString();
        }

        private void cantaKolonBirimFiyatTxt_DoubleClick(object sender, EventArgs e)
        {
            cantaKolonBirimFiyatTxt.Text = MetreBirimFiyati(Convert.ToDouble(cantaKolonMetreFiyatiTxt.Text), Convert.ToDouble(cantaKolonKullanılanMiktarTxt.Text)).ToString();
        }

        private void cantaCırtBirimFİyatıTxt_DoubleClick(object sender, EventArgs e)
        {
            cantaCirtBirimFiyatiTxt.Text = MetreBirimFiyati(Convert.ToDouble(cantaCırtMetreFiyatiTxt.Text), Convert.ToDouble(cantaCırtKullanılanMiktarTxt.Text)).ToString();


        }

        private void cantaFermuarBirimFiyatiTxt_DoubleClick(object sender, EventArgs e)
        {
            cantaFermuarBirimFiyatiTxt.Text = MetreBirimFiyati(Convert.ToDouble(cantaFermuarMetreFiyatiTxt.Text), Convert.ToDouble(cantaFermuarKullanilanMiktarTxt.Text)).ToString();
        }

        private void cantaEvaBirimFiyatiTxt_DoubleClick(object sender, EventArgs e)
        {
            cantaEvaBirimFiyatiTxt.Text = MetreBirimFiyati(Convert.ToDouble(cantaEvaMetreFiyatiTxt.Text), Convert.ToDouble(cantaEvaKullanilanMiktarTxt.Text)).ToString();
        }

        private void cantaSalpaBirimFiyatiTxt_DoubleClick(object sender, EventArgs e)
        {
            cantaSalpaBirimFiyatiTxt.Text = MetreBirimFiyati(Convert.ToDouble(cantaSalpaMetreFiyatiTxt.Text), Convert.ToDouble(cantaSalpaKullanilanMiktarTxt.Text)).ToString();
        }

        private void cantaDeri1BirimFiyatTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaDeri1BirimFiyati = Convert.ToDouble(cantaDeri1MetreFiyatiTxt.Text) * Convert.ToDouble(cantaDeri1KullanilanMiktarTxt.Text);

            cantaDeri1BirimFiyatTxt.Text = (Math.Round(canta.CantaDeri1BirimFiyati, 2)).ToString();

        }
        private void cantaDeri2BirimFiyatTxt_DoubleClick(object sender, EventArgs e)
        {
            canta.CantaDeri2BirimFiyati = Convert.ToDouble(cantaDeri2MetreFiyatiTxt.Text) * Convert.ToDouble(cantaDeri2KullanilanMiktarTxt.Text);

            cantaDeri2BirimFiyatTxt.Text = (Math.Round(canta.CantaDeri2BirimFiyati, 2)).ToString();
        }


        public double BirimFiyatiHesapla()
        {
            var list = new ArrayList();
            canta.CantaMukavvaBirimFiyati = Convert.ToDouble(cantaMukavvaBirimFiyatıtxt.Text);
            list.Add(canta.CantaMukavvaBirimFiyati);
            double mukavvaBirimFiyati2 = Convert.ToDouble(cantaMukavva2BirimFiyatıtxt.Text);
            list.Add(mukavvaBirimFiyati2);
            double mukavvaBirimFiyati3 = Convert.ToDouble(cantaMukavva3BirimFiyatıtxt.Text);
            list.Add(mukavvaBirimFiyati3);
            double mukavvaBirimFiyati4 = Convert.ToDouble(cantaMukavva4BirimFiyatıtxt.Text);
            list.Add(mukavvaBirimFiyati4);
            double mukavvaBirimFiyati5 = Convert.ToDouble(cantaMukavva5BirimFiyatıtxt.Text);
            list.Add(mukavvaBirimFiyati5);
            double mukavvaBirimFiyati6 = Convert.ToDouble(cantaMukavva6BirimFiyatıtxt.Text);
            list.Add(mukavvaBirimFiyati6);

            canta.CantaAstarBirimFiyati = Convert.ToDouble(cantaAstarBirimFiyatTxt.Text);
            list.Add(canta.CantaAstarBirimFiyati);
            canta.CantaSungerBirimFiyati = Convert.ToDouble(cantaSungerBirimFiyatTxt.Text);
            list.Add(canta.CantaSungerBirimFiyati);
            canta.CantaDenyaBirimFiyati = Convert.ToDouble(cantaDenyaBirimFiyatTxt.Text);
            list.Add(canta.CantaDenyaBirimFiyati);
            canta.CantaSkayBirimFiyati = Convert.ToDouble(cantaSkayBirimFiyatTxt.Text);
            list.Add(canta.CantaSkayBirimFiyati);
            canta.CantaDeri1BirimFiyati = Convert.ToDouble(cantaDeri1BirimFiyatTxt.Text);
            list.Add(canta.CantaDeri1BirimFiyati);
            canta.CantaDeri2BirimFiyati = Convert.ToDouble(cantaDeri2BirimFiyatTxt.Text);
            list.Add(canta.CantaDeri2BirimFiyati);
            canta.CantaKolonBirimFiyati = Convert.ToDouble(cantaKolonBirimFiyatTxt.Text);
            list.Add(canta.CantaKolonBirimFiyati);
            canta.CantaCirtBirimFiyati = Convert.ToDouble(cantaCirtBirimFiyatiTxt.Text);
            list.Add(canta.CantaCirtBirimFiyati);
            canta.CantaLastikBirimFiyati = Convert.ToDouble(cantaLastikBirimFiyatiTxt.Text);
            list.Add(canta.CantaLastikBirimFiyati);
            canta.CantaFermuarBirimFiyati = Convert.ToDouble(cantaFermuarBirimFiyatiTxt.Text);
            list.Add(canta.CantaFermuarBirimFiyati);
            canta.CantaEvaBirimFiyati = Convert.ToDouble(cantaEvaBirimFiyatiTxt.Text);
            list.Add(canta.CantaEvaBirimFiyati);
            canta.CantaSalpaBirimFiyati = Convert.ToDouble(cantaSalpaBirimFiyatiTxt.Text);
            list.Add(canta.CantaSalpaBirimFiyati);
            canta.CantaPlastikTokaBirimFiyati = Convert.ToDouble(cantaPlastikTokaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaPlastikTokaAdetTxt.Text);
            list.Add(canta.CantaPlastikTokaBirimFiyati);
            canta.CantaPlastikKamburBirimFiyati = Convert.ToDouble(cantaPlastikKamburBirimFiyatiTxt.Text) * Convert.ToInt32(cantaPlastikKamburAdetTxt.Text);
            list.Add(canta.CantaPlastikKamburBirimFiyati);
            canta.CantaPlastikKilitBirimFİyati = Convert.ToDouble(cantaPlastikKilitBirimFiyatiTxt.Text) * Convert.ToInt32(cantaPlastikKilitAdetTxt.Text);
            list.Add(canta.CantaPlastikKilitBirimFİyati);
            canta.CantaKilitSifreliBirimFİyati = Convert.ToDouble(cantaKilitSifreliBirimFiyatTxt.Text) * Convert.ToInt32(cantaKilitSifreliAdetTxt.Text);
            list.Add(canta.CantaKilitSifreliBirimFİyati);
            canta.CantaKilitSifresizBirimFiyati = Convert.ToDouble(cantaKilitSifresizBirimFiyatiTxt.Text) * Convert.ToInt32(cantaKilitSifresizAdetTxt.Text);
            list.Add(canta.CantaKilitSifresizBirimFiyati);
            canta.CantaBoncukYarmaBirimFiyati = Convert.ToDouble(cantaBoncukYarmaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaBoncukYarmaAdetTxt.Text);
            list.Add(canta.CantaBoncukYarmaBirimFiyati);
            canta.CantaYanSikmaBirimFiyati = Convert.ToDouble(cantaYanSIkmaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaYanSikmaAdetTxt.Text);
            list.Add(canta.CantaYanSikmaBirimFiyati);
            canta.CantaMiknatisBirimFiyati = Convert.ToDouble(cantaMiknatisBirimFiyatiTxt.Text) * Convert.ToInt32(cantaMiknatisAdetTxt.Text);
            list.Add(canta.CantaMiknatisBirimFiyati);
            canta.CantaTokaBirimFiyati = Convert.ToDouble(cantaTokaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaTokaAdetTxt.Text);
            list.Add(canta.CantaTokaBirimFiyati);
            canta.CantaMekanizmaBirimFiyati = Convert.ToDouble(cantaMekanizmaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaMekanizmaAdetTxt.Text);
            list.Add(canta.CantaMekanizmaBirimFiyati);
            canta.CantaSustaBirimFiyati = Convert.ToDouble(cantaSustaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaSustaAdetTxt.Text);
            list.Add(canta.CantaSustaBirimFiyati);
            canta.CantaTorukBirimFiyati = Convert.ToDouble(cantaTorukBirimFiyatiTxt.Text) * Convert.ToInt32(cantaTorukAdetTxt.Text);
            list.Add(canta.CantaTorukBirimFiyati);
            canta.CantaKamburTokaBirimFiyati = Convert.ToDouble(cantaKamburTokaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaKamburTokaAdetTxt.Text);
            list.Add(canta.CantaKamburTokaBirimFiyati);
            canta.CantaSurgutBirimFiyati = Convert.ToDouble(cantaSurgutBirimFiyatiTxt.Text) * Convert.ToInt32(cantaSurgutAdetTxt.Text);
            list.Add(canta.CantaSurgutBirimFiyati);
            canta.CantaOmuzlukBirimFiyati = Convert.ToDouble(cantaOmuzlukBirimFiyatiTxt.Text) * Convert.ToInt32(cantaOmuzlukAdetTxt.Text);
            list.Add(canta.CantaOmuzlukBirimFiyati);
            canta.CantaCubukSapiBirimFiyati = Convert.ToDouble(cantaCubukSapiBirimFiyatiTxt.Text) * Convert.ToInt32(cantaCubukSapiAdetTxt.Text);
            list.Add(canta.CantaCubukSapiBirimFiyati);
            canta.CantaDugmeTorukBirimFiyati = Convert.ToDouble(cantaDugmeTorukBirimFiyatiTxt.Text) * Convert.ToInt32(cantaDugmeTorukAdetTxt.Text);
            list.Add(canta.CantaDugmeTorukBirimFiyati);
            canta.CantaKapsulBirimFiyati = Convert.ToDouble(cantaKapsulBirimFiyatTxt.Text) * Convert.ToInt32(cantaKapsulAdetTxt.Text);
            list.Add(canta.CantaKapsulBirimFiyati);
            canta.CantaKoseBirimFİyati = Convert.ToDouble(cantaKoseBirimFiyatiTxt.Text) * Convert.ToInt32(cantaKoseAdetTxt.Text);
            list.Add(canta.CantaKoseBirimFİyati);
            canta.CantaPlastikFitilBirimFiyati = Convert.ToDouble(cantaPlastikFitilBirimFiyatiTxt.Text) * Convert.ToInt32(cantaPlastikFitilAdetTxt.Text);
            list.Add(canta.CantaPlastikFitilBirimFiyati);
            canta.CantaBezFitilBirimFiyati = Convert.ToDouble(cantaBezFitilBirimFiyatiTxt.Text) * Convert.ToInt32(cantaBezFitilAdetTxt.Text);
            list.Add(canta.CantaBezFitilBirimFiyati);
            canta.CantaFermuarElcikBirimFiyati = Convert.ToDouble(cantaFermuarElcikBirimFiyatiTxt.Text) * Convert.ToInt32(cantaFermuarElcikAdetTxt.Text);
            list.Add(canta.CantaFermuarElcikBirimFiyati);
            canta.CantaDHalkaBirimFiyati = Convert.ToDouble(cantaDHalkaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaDHalkaAdetTxt.Text);
            list.Add(canta.CantaDHalkaBirimFiyati);
            canta.CantaKareHalkaBirimFiyati = Convert.ToDouble(cantakareHalkaBirimFiyatiTxt.Text) * Convert.ToInt32(cantaKareHalkaAdetTxt.Text);
            list.Add(canta.CantaKareHalkaBirimFiyati);
            canta.CantaKaburaBirimFiyati = Convert.ToDouble(cantaKaburaBirimFiyatıTxt.Text) * Convert.ToInt32(cantaKaburaAdetTxt.Text);
            list.Add(canta.CantaKaburaBirimFiyati);
            canta.CantaBaskiBirimFİyati = Convert.ToDouble(cantaBaskiBirimFiyatiTxt.Text);
            list.Add(canta.CantaBaskiBirimFİyati);
            canta.CantaBicakBirimFiyati = Convert.ToDouble(cantaBicakFiyatiTxt.Text)/Convert.ToDouble(cantaUrunAdediTxt.Text);
            list.Add(canta.CantaBicakBirimFiyati);
            canta.CantaKeskiBirimFiyati = Convert.ToDouble(cantaKeskiFiyatiTxt.Text) / Convert.ToDouble(cantaUrunAdediTxt.Text);
            list.Add(canta.CantaKeskiBirimFiyati);
            canta.CantaSolusyonBirimFİyati = Convert.ToDouble(cantaSolusyonBirimFiyatiTxt.Text);
            list.Add(canta.CantaSolusyonBirimFİyati);
            canta.CantaİplikBirimFiyati = Convert.ToDouble(cantaİplikBirimFiyatiTxt.Text);
            list.Add(canta.CantaİplikBirimFiyati);


            double Toplam = 0;
            foreach (var item in list)
            {
                Toplam += Convert.ToDouble(item);
            }


            return Math.Round(Toplam, 4);
        }
        private void cantaBicakFiyatiTxt_TextChanged(object sender, EventArgs e)
        {
            cantaBicakBirimFiyatiTxt.Text = (Convert.ToDouble(cantaBicakFiyatiTxt.Text) / Convert.ToDouble(cantaUrunAdediTxt.Text)).ToString();
        }
        private void cantaKeskiFiyatiTxt_TextChanged(object sender, EventArgs e)
        {
            cantaKeskiBirimFiyatiTxt.Text = (Convert.ToDouble(cantaKeskiFiyatiTxt.Text) / Convert.ToDouble(cantaUrunAdediTxt.Text)).ToString();
        }


        private void cantaToplaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cantaToplamlbl.Text = BirimFiyatiHesapla().ToString();
            }
            catch (Exception)
            {
                string[] TextBoxlar = {cantaMukavvaBirimFiyatıtxt.Text, cantaAstarBirimFiyatTxt.Text, cantaSungerBirimFiyatTxt.Text,cantaMukavva2BirimFiyatıtxt.Text,cantaMukavva3BirimFiyatıtxt.Text,
                    cantaMukavva4BirimFiyatıtxt.Text,cantaMukavva5BirimFiyatıtxt.Text,cantaMukavva6BirimFiyatıtxt.Text,
                    cantaDenyaBirimFiyatTxt.Text, cantaSkayBirimFiyatTxt.Text, cantaDeri1BirimFiyatTxt.Text, cantaDeri2BirimFiyatTxt.Text,
                    cantaKolonBirimFiyatTxt.Text,cantaCirtBirimFiyatiTxt.Text,cantaLastikBirimFiyatiTxt.Text,cantaFermuarBirimFiyatiTxt.Text,cantaEvaBirimFiyatiTxt.Text,
                    cantaSalpaBirimFiyatiTxt.Text,cantaPlastikTokaBirimFiyatiTxt.Text,cantaPlastikTokaAdetTxt.Text,cantaPlastikKamburBirimFiyatiTxt.Text,cantaPlastikKamburAdetTxt.Text,
                    cantaPlastikKilitBirimFiyatiTxt.Text,cantaPlastikKilitAdetTxt.Text,cantaKilitSifreliBirimFiyatTxt.Text,cantaKilitSifreliAdetTxt.Text,cantaKilitSifresizBirimFiyatiTxt.Text,
                    cantaKilitSifresizAdetTxt.Text,cantaBoncukYarmaBirimFiyatiTxt.Text,cantaBoncukYarmaAdetTxt.Text,cantaYanSIkmaBirimFiyatiTxt.Text,cantaYanSikmaAdetTxt.Text,cantaMiknatisBirimFiyatiTxt.Text,
                    cantaMiknatisAdetTxt.Text,cantaTokaBirimFiyatiTxt.Text,cantaTokaAdetTxt.Text,cantaMekanizmaBirimFiyatiTxt.Text,cantaMekanizmaAdetTxt.Text,cantaSustaBirimFiyatiTxt.Text,cantaSustaAdetTxt.Text,
                    cantaTorukBirimFiyatiTxt.Text,cantaTorukAdetTxt.Text,cantaKamburTokaBirimFiyatiTxt.Text,cantaKamburTokaAdetTxt.Text,cantaSurgutBirimFiyatiTxt.Text,cantaSurgutAdetTxt.Text,cantaOmuzlukBirimFiyatiTxt.Text,
                    cantaOmuzlukAdetTxt.Text,cantaCubukSapiBirimFiyatiTxt.Text,cantaCubukSapiAdetTxt.Text,cantaDugmeTorukBirimFiyatiTxt.Text,cantaDugmeTorukAdetTxt.Text,cantaKapsulBirimFiyatTxt.Text,
                    cantaKapsulAdetTxt.Text,cantaKoseBirimFiyatiTxt.Text,cantaKoseAdetTxt.Text,cantaPlastikFitilBirimFiyatiTxt.Text,cantaPlastikFitilAdetTxt.Text,cantaBezFitilBirimFiyatiTxt.Text,
                    cantaBezFitilAdetTxt.Text,cantaFermuarElcikBirimFiyatiTxt.Text,cantaFermuarElcikAdetTxt.Text,cantaDHalkaBirimFiyatiTxt.Text,cantaDHalkaAdetTxt.Text,cantakareHalkaBirimFiyatiTxt.Text,
                    cantaKaburaBirimFiyatıTxt.Text,cantaKaburaAdetTxt.Text,cantaBaskiBirimFiyatiTxt.Text,cantaBicakBirimFiyatiTxt.Text,cantaKeskiBirimFiyatiTxt.Text,cantaSolusyonBirimFiyatiTxt.Text,
                    cantaİplikBirimFiyatiTxt.Text};
                foreach (string item in TextBoxlar)
                {
                    if (item == "")
                    {

                        MessageBox.Show(" Boş geçilemez");

                        return;

                    }
                }
                //foreach (Control item in this.Controls)
                //{
                //    if (item.GetType().ToString() == "System.Windows.Forms.TextBox" && item.Text == "")
                //    {

                //            MessageBox.Show(" Boş geçilemez");

                //    }

                //}
                //throw;

            }


        }

        private double KarHesaplama()
        {
            Double Toplam = (Convert.ToDouble(cantaToplamlbl.Text) * Convert.ToInt32(cantaUrunAdediTxt.Text));
            double sonToplam = Toplam + ((Toplam * Convert.ToDouble(cantaKarTxt.Text) / 100));
            return sonToplam;
        }
        KurCek kur = new KurCek();
        private void Canta_Load(object sender, EventArgs e)
        {
            cantaSonuclistView.Columns.Add("Ürün Adi", 200);
            cantaSonuclistView.Columns.Add("Ürün Adedi", 200);
            cantaSonuclistView.Columns.Add("Çanta Maliyeti", 200);
            cantaBirimDolarKurTxt.Text = kur.GetRate("USD").ToString();
        }

        private void cantaSonToplamBtn_Click(object sender, EventArgs e)
        {
            try
            {

                canta.CantaUrunAdi = cantaUrunAdiTxt.Text;
                canta.CantaUrunAdedi = cantaUrunAdediTxt.Text;
                string cantaKarliToplam = KarHesaplama().ToString();

                string[] bilgiler = { canta.CantaUrunAdi, canta.CantaUrunAdedi, cantaKarliToplam };
                cantaSonuclistView.Items.Add(new ListViewItem(bilgiler));

            }
            catch (Exception)
            {
                if (cantaKarTxt.Text == "")
                {

                    MessageBox.Show(" Boş geçilemez");

                    return;

                }

                throw;
            }
        }

        private void cantaYeniHesapBtn_Click(object sender, EventArgs e)
        {
            
            cantaMukavvaTuruCbx.Text = "";
            cantaMukavvaAdetiCbx.Text = "";
            cantaMukavva2TuruCbx.Text = "";
            cantaMukavva2AdetiCbx.Text = "";
            cantaMukavva3TuruCbx.Text = "";
            cantaMukavva3AdetiCbx.Text = "";
            cantaMukavva4TuruCbx.Text = "";
            cantaMukavva4AdetiCbx.Text = "";
            cantaMukavva5TuruCbx.Text = "";
            cantaMukavva5AdetiCbx.Text = "";
            cantaMukavva6TuruCbx.Text = "";
            cantaMukavva6AdetiCbx.Text = "";
            cantaToplamlbl.Text = "";
            cantaSonuclistView.Items.Clear();

            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }


        }

        private void cantaKurHessaplaBtn_Click(object sender, EventArgs e)
        {

            cantaTurkLirasiTxt.Text= Math.Round(Convert.ToDouble(cantaDovizTxt.Text) * Convert.ToDouble(cantaBirimDolarKurTxt.Text), 4).ToString();

            
        }

       
    }
}