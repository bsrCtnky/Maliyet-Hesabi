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
    public partial class Defter : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=GRAFIK2\\SQLEXPRESS;Initial Catalog=PM_MaliyetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DefterMaliyet defter = new DefterMaliyet();
        MukavvaBilgileri mukavvaBilgileri = new MukavvaBilgileri();
        KurCek kur = new KurCek();

        public Defter()
        {
            InitializeComponent();


            MukavvaTurCbx();
            MukavvaAdetCbx();


        }



        public void MukavvaTurCbx()
        {
            string BaseQuery = "SELECT  mukavvaTuru FROM  [PM_MaliyetDB].[dbo].[Mukavva]";

            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {
                deftermukavvaTuruCbx.Items.Add(rdr["mukavvaTuru"]);
            }
            baglanti.Close();


        }
        public void MukavvaAdetCbx()
        {
            string BaseQuery = "SELECT BireKacAd FROM[PM_MaliyetDB].[dbo].[BireKac]";
            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {

                defterMukavvaAdetiCbx.Items.Add(rdr["BireKacAd"]);
            }
            baglanti.Close();

        }

        public void BireKac()
        {
            defter.DefterUrunEn = Convert.ToDouble(defterurunEntxt.Text)+1;
            defter.DefterUrunBoy = Convert.ToDouble(defterurunBoyTxt.Text)+1;

            //defter.DefterUrunEn= defter.DefterUrunEn + 1;
            //defter.DefterUrunBoy= defter.DefterUrunBoy + 1;

            int uzunKenar = 100, kisaKenar = 70;
            double kacTane1, kactane2;
            double sonuc1 , sonuc2 ;
            double kenar1 = defter.DefterUrunEn;
            double kenar2 = defter.DefterUrunBoy;


            kacTane1 = Math.Floor(uzunKenar / kenar1);
            kactane2 = Math.Floor(kisaKenar / kenar2);


            sonuc1 = Math.Floor(kacTane1 * kactane2);




            kacTane1 = Math.Floor(uzunKenar / kenar2);
            kactane2 = Math.Floor(kisaKenar / kenar1);


            sonuc2 = Math.Floor(kacTane1 * kactane2);


            if (sonuc1 > sonuc2)
            {
                defterBireKacAlırTxt.Text = sonuc1.ToString();
            }
            else
            {
                defterBireKacAlırTxt.Text = sonuc1.ToString();
            }
        }

        //public void DeriMaliyetiHesapla()
        //{
        //    defter.DefterUrunEn = Convert.ToDouble(defterurunEntxt.Text);
        //    defter.DefterUrunBoy = Convert.ToDouble(defterurunBoyTxt.Text);

        //    defter.DefterUrunEn = defter.DefterUrunEn + 1;
        //    defter.DefterUrunBoy = defter.DefterUrunBoy + 1;

        //    int uzunKenar = 140, kisaKenar = 100;
        //    double kacTane1, kactane2;
        //    double sonuc1 = 0, sonuc2 = 0;
        //    double kenar1 = defter.DefterUrunEn;
        //    double kenar2 = defter.DefterUrunBoy;


        //    kacTane1 = Math.Floor(uzunKenar / kenar1);
        //    kactane2 = Math.Floor(kisaKenar / kenar2);


        //    sonuc1 = Math.Floor(kacTane1 * kactane2);




        //    kacTane1 = Math.Floor(uzunKenar / kenar2);
        //    kactane2 = Math.Floor(kisaKenar / kenar1);


        //    sonuc2 = Math.Floor(kacTane1 * kactane2);


        //    if (sonuc1 > sonuc2)
        //    {
        //        defterDeriBirimFiyatıtxt.Text = (Math.Round(Convert.ToDouble(defterDeriFiyatitxt.Text) / sonuc1, 2)).ToString();
        //    }
        //    else
        //    {
        //        defterDeriBirimFiyatıtxt.Text = (Math.Round(Convert.ToDouble(defterDeriFiyatitxt.Text)  / sonuc2, 2)).ToString();
        //    }
        //}

      

        private void DefterBireKacAlırTxt_DoubleClick(object sender, EventArgs e)
        {
            BireKac();
        }

        private void DefterMukavvaBulBtn_Click(object sender, EventArgs e)
        {
            defter.DefterMukavvaTuru = deftermukavvaTuruCbx.SelectedItem.ToString();
            defter.DefterMukavvaAdet = defterMukavvaAdetiCbx.SelectedItem.ToString();

            deftermukavvaBirimFiyatitxt.Text = MukavvaBirimFiyati(defter.DefterMukavvaTuru, defter.DefterMukavvaAdet).ToString();
        }

        public double MukavvaBirimFiyati(String mukkavvaTuru, String mukavvaAdeti)
        {


            defter.DefterMukavvaFiyati = Convert.ToDouble(deftermukavvaFiyatitxt.Text);


            int gelenMukavvaAdeti = mukavvaBilgileri.MukavvaAdetBilgisi(mukkavvaTuru);

            int gekenBirKac = mukavvaBilgileri.BireKacDegerler(mukavvaAdeti);


            defter.DefterMukavvaBirimFiyati = defter.DefterMukavvaFiyati / gelenMukavvaAdeti / gekenBirKac;

            return defter.DefterMukavvaBirimFiyati;
        }

        //--------------------------------------------------MATBAA HESABI--------------------------------------------------------

        public double MatbaaKagitMaliyeti(double en, double boy)
        {
            double kagitMaliyeti=0;

           
           
            en = en * 4;
            boy = boy * 4;
       
            if (en > 100)
            {
                en = en / 2;
            }
            else if (boy > 100)
            {
                boy = boy / 2;
            }
          

            double temp;
            if (en > boy)
            {
                temp = en;
                en = boy;
                boy = temp;
            }

            //int[] standartEn = { 57, 64, 68, 70 };
            //int[] standartBoy = { 82, 88, 90, 100 };

            if (en < 57 && boy < 82)
            {
                en = 57;
                boy = 82;

                kagitMaliyeti = (Convert.ToDouble(defterkullanilanKagitFiyatitxt.Text) / 1000) * KagitAgirlik(en, boy);
                return kagitMaliyeti;
            }
            else if (en > 57 && en < 64 && boy > 82 && boy < 90)
            {
                en = 64;
                boy = 90;

                kagitMaliyeti = (Convert.ToDouble(defterkullanilanKagitFiyatitxt.Text) / 1000) * KagitAgirlik(en, boy);
                return kagitMaliyeti;

            }
            else if (en > 64 && en < 68 && boy > 90 && boy < 100)
            {
                en = 68;
                boy = 100;
                kagitMaliyeti = (Convert.ToDouble(defterkullanilanKagitFiyatitxt.Text) / 1000) * KagitAgirlik(en, boy);
                return kagitMaliyeti;

            }
            else if (en > 60 && en < 70 && boy > 90 && boy < 100)
            {
                en = 70;
                boy = 100;

                kagitMaliyeti = (Convert.ToDouble(defterkullanilanKagitFiyatitxt.Text) / 1000) * KagitAgirlik(en, boy);
                return kagitMaliyeti;

            }
            else if (en < 57 && boy > 82 && boy < 88)
            {
                en = 57;
                boy = 88;
           
                kagitMaliyeti =( Convert.ToDouble(defterkullanilanKagitFiyatitxt.Text)/1000) * KagitAgirlik(en, boy);
                return kagitMaliyeti;
            }
            else
            {
                return kagitMaliyeti;
            }

        }

        public double KagitAgirlik(double en, double boy)
        {
            double ilkgirilenEn = Convert.ToDouble(defterurunEntxt.Text)*4;
            double ilkgirilenBoy = Convert.ToDouble(defterurunBoyTxt.Text)*4;
            defter.DefterUrunYaprakSayisi = Convert.ToInt32(defteryaprakSayisitxt.Text);
            defter.DefterUrunAdedi = Convert.ToInt32(defterurunAdeditxt.Text);
            defter.DefterKagitGramaji = Convert.ToDouble(defterkagitGramajitxt.Text);
            int formaSayisi = Convert.ToInt32(defteryaprakSayisitxt.Text) / 16;



            if (ilkgirilenEn > 100 || ilkgirilenBoy > 100)
            {
              
                double agirlik = ((en * boy * defter.DefterKagitGramaji) / 10000) * formaSayisi;
              
                //double agirlik = ((en * boy * defter.DefterKagitGramaji) / 10000) * ((formaSayisi * (defter.DefterUrunAdedi + 100)));
                return agirlik;
            }
            else
            {
                
                double agirlik = ((en * boy * defter.DefterKagitGramaji) / 10000) * formaSayisi;
           
                //double agirlik = ((en * boy * defter.DefterKagitGramaji) / 10000) * ((formaSayisi * (defter.DefterUrunAdedi + 100)) / 2);
                return agirlik;
            }



        }


        //---------------------------------------------------------Birim Fİyati Bul-------------------------------------------------

        public double MatbaaBirimFiyati()
        {
            //int formaSayisi= Convert.ToInt32(defteryaprakSayisitxt.Text) / 16;*/
            double en = Convert.ToDouble(defterurunEntxt.Text);
            double boy = Convert.ToDouble(defterurunBoyTxt.Text);
         
            defter.DefetKagitMaliyetFiyati = MatbaaKagitMaliyeti(en,boy);

            defter.DefterYanKagitFiyati = Convert.ToDouble(defteryanKagittxt.Text);
            defter.DefterKagitBaskiFiyati =  Convert.ToDouble(defterbaskiKalipFiyatitxt.Text);
            defter.DefterKagitKirimFiyati =  Convert.ToDouble(defterkirimFiyatitxt.Text);
            defter.DefterKagitHarmanFiyati = Convert.ToDouble(defterHarmanFiyatiTxt.Text);
            defter.DefterIplikDikisFiyati =  Convert.ToDouble(defteriplikDikisitxt.Text);
            defter.DefterSirtKagitFiyati = Convert.ToDouble(defterSırtKagitTxt.Text);
            defter.DefterKoseAcmaFiyati =  Convert.ToDouble(defterKoseAcmaTxt.Text);

            //defter.DefterKagitBaskiFiyati = formaSayisi * Convert.ToDouble(defterbaskiKalipFiyatitxt.Text);
            //defter.DefterKagitKirimFiyati = formaSayisi * Convert.ToInt32(defterurunAdeditxt.Text) * Convert.ToDouble(defterkirimFiyatitxt.Text);
            //defter.DefterKagitHarmanFiyati = formaSayisi * Convert.ToInt32(defterurunAdeditxt.Text) * Convert.ToDouble(defterHarmanFiyatiTxt.Text);
            //defter.DefterIplikDikisFiyati = formaSayisi * Convert.ToInt32(defterurunAdeditxt.Text) * Convert.ToDouble(defteriplikDikisitxt.Text);
            //defter.DefterSirtKagitFiyati = formaSayisi * Convert.ToInt32(defterurunAdeditxt.Text) * Convert.ToDouble(defterSırtKagitTxt.Text);
            //defter.DefterKoseAcmaFiyati = Convert.ToInt32(defterurunAdeditxt.Text) * Convert.ToDouble(defterKoseAcmaTxt.Text);

            double toplam = defter.DefetKagitMaliyetFiyati + defter.DefterKagitBaskiFiyati + defter.DefterKagitKirimFiyati + defter.DefterYanKagitFiyati+
                defter.DefterKagitHarmanFiyati + defter.DefterIplikDikisFiyati + defter.DefterSirtKagitFiyati + defter.DefterKoseAcmaFiyati;
           /* toplam = toplam;*/             // / Convert.ToInt32(defterurunAdeditxt.Text);

            return toplam;
        }

        public double KapakBirimFiyati()
        {
            defter.DefterMukavvaBirimFiyati = Convert.ToDouble(deftermukavvaBirimFiyatitxt.Text);
            defter.DefterKenarDikisiFiyati = Convert.ToDouble(defterkenarDikisiTxt.Text);
            defter.DefterSerazeFiyati = Convert.ToDouble(defterserazetxt.Text);
            defter.DefterKurdaleFiyati = Convert.ToDouble(defterkurdaletxt.Text);
            defter.DefterKalemlikLastigiFiyati = Convert.ToDouble(defterkalemlikLastigitxt.Text);
            defter.DefterYanLastikFiyati = Convert.ToDouble(defteryanLastiktxt.Text);
            defter.DefterTelaFiyati = Convert.ToDouble(deftertelatxt.Text);
            defter.DefterTutkallamaveUstAlmaFiyati = Convert.ToDouble(deftertutkallamatxt.Text);
            defter.DefterAmbalajlamaFiyati = Convert.ToDouble(defterambalajlamatxt.Text);
            defter.DefterKoliFiyati = Convert.ToDouble(defterKolitxt.Text);
            defter.DefterSungerFiyati = Convert.ToDouble(deftersungertxt.Text);
            defter.DefterMiknatisFiyati = Convert.ToDouble(deftermıknatısTxt.Text);
            defter.DefterMetalAksesuarFiyati = Convert.ToDouble(deftermetalAksesuarTxt.Text);
            defter.DefterBicakKesimFiyati = Convert.ToDouble(defterbıcakvekesimTxt.Text);
            defter.DefterAstarFiyati = Convert.ToDouble(defterastarTxt.Text);
            defter.DefterSalpaFiyati = Convert.ToDouble(deftersalpaTxt.Text);
            defter.DefterDeriBirimFiyati = Convert.ToDouble(defterDeriBirimFiyatıtxt.Text);


            double topla = defter.DefterMukavvaBirimFiyati + defter.DefterKenarDikisiFiyati + defter.DefterSerazeFiyati + defter.DefterKurdaleFiyati + defter.DefterKalemlikLastigiFiyati
                + defter.DefterYanLastikFiyati + defter.DefterTelaFiyati + defter.DefterTutkallamaveUstAlmaFiyati + defter.DefterAmbalajlamaFiyati + defter.DefterKoliFiyati + defter.DefterSungerFiyati
                + defter.DefterMiknatisFiyati + defter.DefterMetalAksesuarFiyati + defter.DefterBicakKesimFiyati + defter.DefterAstarFiyati + defter.DefterSalpaFiyati + defter.DefterDeriBirimFiyati;


            return Math.Round(topla, 4);
        }

        private double KarHesaplama()
        {
            Double Toplam = ((Convert.ToDouble(defterMatbaaMaliyetiTxt.Text) + Convert.ToDouble(defterKapakMaliyetiTxt.Text)) * Convert.ToInt32(defterurunAdeditxt.Text));
            double defterKarToplami = Toplam + ((Toplam * Convert.ToDouble(defterkarTxt.Text) / 100));
            return defterKarToplami;
        }

       


        //--------------------------------------------------------EVENT--------------------------------------------------
        private void DefterMatbaaMaliyetiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                defterMatbaaMaliyetiTxt.Text = MatbaaBirimFiyati().ToString();
            }
            catch (Exception)
            {
                string[] TextBoxlar = {defterurunAdeditxt.Text,defteryaprakSayisitxt.Text, defterbaskiKalipFiyatitxt.Text,
                   defterkirimFiyatitxt.Text, defterHarmanFiyatiTxt.Text, defteriplikDikisitxt.Text,
                    defterSırtKagitTxt.Text,defterKoseAcmaTxt.Text,defterurunBoyTxt.Text,defterurunBoyTxt.Text,defterurunEntxt.Text,defterkagitGramajitxt.Text,defterkullanilanKagitFiyatitxt.Text,
                    defteryanKagittxt.Text,defterbaskiKalipFiyatitxt.Text
                     };
                foreach (string item in TextBoxlar)
                {
                    if (item == "")
                    {

                        MessageBox.Show(" Boş geçilemez");

                        return;

                    }

                }


                throw;

            }

        }

        private void DefterKapakMaliyetiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                defterKapakMaliyetiTxt.Text = KapakBirimFiyati().ToString();
            }
            catch (Exception)
            {
                string[] TextBoxlar = {deftermukavvaBirimFiyatitxt.Text,defterkenarDikisiTxt.Text,defterserazetxt.Text,defterkurdaletxt.Text,defterkalemlikLastigitxt.Text,
                    defteryanLastiktxt.Text,deftertelatxt.Text,deftertutkallamatxt.Text,defterambalajlamatxt.Text,defterKolitxt.Text,deftersungertxt.Text,deftermıknatısTxt.Text,
                    deftermetalAksesuarTxt.Text,defterbıcakvekesimTxt.Text,defterastarTxt.Text,deftersalpaTxt.Text,defterDeriBirimFiyatıtxt.Text
                     };
                foreach (string item in TextBoxlar)
                {
                    if (item == "")
                    {

                        MessageBox.Show(" Boş geçilemez");

                        return;

                    }
                }
                throw;
            }

        }

        private void Defter_Load(object sender, EventArgs e)
        {
            defterSonuclistView.Columns.Add("Ürün Adi", 150);
            defterSonuclistView.Columns.Add("Ürün Adedi", 150);
            defterSonuclistView.Columns.Add("Kutu Maliyeti", 150);
            defterBirimDolarKurTxt.Text = kur.GetRate("USD").ToString();
            defterEuroTxt.Text = kur.GetRate("EUR").ToString();
        }

        private void DeftersonToplamBtn_Click(object sender, EventArgs e)
        {
            try
            {

                defter.DefterUrunAdi = defterurunAditxt.Text;
                string DefterUrunAdedi = defterurunAdeditxt.Text;
                defter.DefterKarToplam = KarHesaplama().ToString();

                string[] bilgiler = { defter.DefterUrunAdi, DefterUrunAdedi, defter.DefterKarToplam };
                defterSonuclistView.Items.Add(new ListViewItem(bilgiler));

            }
            catch (Exception)
            {
                if (defterkarTxt.Text == "")
                {

                    MessageBox.Show(" Boş geçilemez");

                    return;

                }

            }

            //------------------------------------------------------------------------------------------------------


        }

        private void DefterKurHessaplaBtn_Click(object sender, EventArgs e)
        {
        
            defterToplamDolarTxt.Text = Math.Round(Convert.ToDouble(defterkurTLTxt.Text) * Convert.ToDouble(defterBirimDolarKurTxt.Text), 4).ToString();
        }

        private void DefterYeniHesapBtn_Click(object sender, EventArgs e)
        {
            deftermukavvaTuruCbx.Text = "";
            defterMukavvaAdetiCbx.Text = "";
            defterSonuclistView.Clear();
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }

        private void EuroHesaplaBtn_Click(object sender, EventArgs e)
        {
            defterEuroTLTxt.Text= Math.Round(Convert.ToDouble(defterKurEuroTlTxt.Text) * Convert.ToDouble(defterEuroTxt.Text), 4).ToString();
            defterDeriFiyatitxt.Text = Math.Round(Convert.ToDouble(defterKurEuroTlTxt.Text) * Convert.ToDouble(defterEuroTxt.Text), 4).ToString();
        }

        private void DefterDeriBireKacAlirTxt_TextChanged(object sender, EventArgs e)
        {
            defterDeriBirimFiyatıtxt.Text =Math.Round((Convert.ToDouble(defterDeriFiyatitxt.Text) / Convert.ToDouble(defterDeriBireKacAlirTxt.Text)),2).ToString();
        }
    }
}
