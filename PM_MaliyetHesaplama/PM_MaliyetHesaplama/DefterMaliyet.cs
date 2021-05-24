using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_MaliyetHesaplama
{
    public partial class DefterMaliyet
    {
        private string defterUrunAdi;
        private int    defterUrunAdedi;
        private double defterUrunEn;
        private double defterUrunBoy;
        private double defterUrunYukseklik;
        private int    defterUrunYaprakSayisi;
        private double defetKagitMaliyetFiyati;
        private double defterKullanilanKagitFiyati;
        private double defterKagitGramaji;
        private double defterKagitGramajiFiyati;
        private double defterYanKagitFiyati;
        private double defterKagitBaskiFiyati;
        private double defterKagitKirimFiyati;
        private double defterKagitHarmanFiyati;
        private double defterSirtKagitFiyati;
        private double defterKoseAcmaFiyati;
        private double defterIplikDikisFiyati;
        private double defterSungerFiyati;
        private double defterMiknatisFiyati;
        private double defterMetalAksesuarFiyati;
        private double defterBicakKesimFiyati;
        private double defterAstarFiyati;
        private double defterSalpaFiyati;
        private string defterDeriTuru;
        private string defterDeriAdet;
        private double defterDeriFiyati;
        private double defterDeriBirimFiyati;
        private string defterMukavvaTuru;
        private string defterMukavvaAdet;
        private  double defterMukavvaFiyati;
        private double defterMukavvaBirimFiyati;
        private double defterKenarDikisiFiyati;
        private double defterSerazeFiyati;
        private double defterKurdaleFiyati;
        private double defterKalemlikLastigiFiyati;
        private double defterYanLastikFiyati;
        private double defterTelaFiyati;
        private double defterTutkallamaveUstAlmaFiyati;
        private double defterAmbalajlamaFiyati;
        private double defterKoliFiyati;
        private string defterKarToplam;

        public string DefterUrunAdi { get => defterUrunAdi; set => defterUrunAdi = value; }
        public int DefterUrunAdedi { get => defterUrunAdedi; set => defterUrunAdedi = value; }
        public double DefterUrunEn { get => defterUrunEn; set => defterUrunEn = value; }
        public double DefterUrunBoy { get => defterUrunBoy; set => defterUrunBoy = value; }
        public double DefterUrunYukseklik { get => defterUrunYukseklik; set => defterUrunYukseklik = value; }
        public int DefterUrunYaprakSayisi { get => defterUrunYaprakSayisi; set => defterUrunYaprakSayisi = value; }
        public double DefterKullanilanKagitFiyati { get => defterKullanilanKagitFiyati; set => defterKullanilanKagitFiyati = value; }
        public double DefterKagitGramajiFiyati { get => defterKagitGramajiFiyati; set => defterKagitGramajiFiyati = value; }
        public double DefterYanKagitFiyati { get => defterYanKagitFiyati; set => defterYanKagitFiyati = value; }
        public double DefterKagitBaskiFiyati { get => defterKagitBaskiFiyati; set => defterKagitBaskiFiyati = value; }
        public double DefterKagitKirimFiyati { get => defterKagitKirimFiyati; set => defterKagitKirimFiyati = value; }
        public double DefterIplikDikisFiyati { get => defterIplikDikisFiyati; set => defterIplikDikisFiyati = value; }
        public double DefterSungerFiyati { get => defterSungerFiyati; set => defterSungerFiyati = value; }
        public double DefterMiknatisFiyati { get => defterMiknatisFiyati; set => defterMiknatisFiyati = value; }
        public double DefterMetalAksesuarFiyati { get => defterMetalAksesuarFiyati; set => defterMetalAksesuarFiyati = value; }
        public double DefterBicakKesimFiyati { get => defterBicakKesimFiyati; set => defterBicakKesimFiyati = value; }
        public double DefterAstarFiyati { get => defterAstarFiyati; set => defterAstarFiyati = value; }
        public double DefterSalpaFiyati { get => defterSalpaFiyati; set => defterSalpaFiyati = value; }
        public string DefterDeriTuru { get => defterDeriTuru; set => defterDeriTuru = value; }
        public string DefterDeriAdet { get => defterDeriAdet; set => defterDeriAdet = value; }
        public double DefterDeriFiyati { get => defterDeriFiyati; set => defterDeriFiyati = value; }
        public double DefterDeriBirimFiyati { get => defterDeriBirimFiyati; set => defterDeriBirimFiyati = value; }
        public string DefterMukavvaTuru { get => defterMukavvaTuru; set => defterMukavvaTuru = value; }
        public string DefterMukavvaAdet { get => defterMukavvaAdet; set => defterMukavvaAdet = value; }
        public double DefterMukavvaFiyati { get => defterMukavvaFiyati; set => defterMukavvaFiyati = value; }
        public double DefterMukavvaBirimFiyati { get => defterMukavvaBirimFiyati; set => defterMukavvaBirimFiyati = value; }
        public double DefterKenarDikisiFiyati { get => defterKenarDikisiFiyati; set => defterKenarDikisiFiyati = value; }
        public double DefterSerazeFiyati { get => defterSerazeFiyati; set => defterSerazeFiyati = value; }
        public double DefterKurdaleFiyati { get => defterKurdaleFiyati; set => defterKurdaleFiyati = value; }
        public double DefterKalemlikLastigiFiyati { get => defterKalemlikLastigiFiyati; set => defterKalemlikLastigiFiyati = value; }
        public double DefterYanLastikFiyati { get => defterYanLastikFiyati; set => defterYanLastikFiyati = value; }
        public double DefterTelaFiyati { get => defterTelaFiyati; set => defterTelaFiyati = value; }
        public double DefterTutkallamaveUstAlmaFiyati { get => defterTutkallamaveUstAlmaFiyati; set => defterTutkallamaveUstAlmaFiyati = value; }
        public double DefterAmbalajlamaFiyati { get => defterAmbalajlamaFiyati; set => defterAmbalajlamaFiyati = value; }
        public double DefterKoliFiyati { get => defterKoliFiyati; set => defterKoliFiyati = value; }
        public double DefterKagitGramaji { get => defterKagitGramaji; set => defterKagitGramaji = value; }
        public double DefetKagitMaliyetFiyati { get => defetKagitMaliyetFiyati; set => defetKagitMaliyetFiyati = value; }
        public double DefterKagitHarmanFiyati { get => defterKagitHarmanFiyati; set => defterKagitHarmanFiyati = value; }
        public double DefterSirtKagitFiyati { get => defterSirtKagitFiyati; set => defterSirtKagitFiyati = value; }
   
      
        public string DefterKarToplam { get => defterKarToplam; set => defterKarToplam = value; }
        public double DefterKoseAcmaFiyati { get => defterKoseAcmaFiyati; set => defterKoseAcmaFiyati = value; }
    }
}
