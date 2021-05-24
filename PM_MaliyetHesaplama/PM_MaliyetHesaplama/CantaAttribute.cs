using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PM_MaliyetHesaplama
{
    class CantaAttribute
    {
        private string cantaUrunAdi;
        private string cantaUrunAdedi;
        private double cantaUrunEn;
        private double cantaUrunBoy;

        private double cantaAstarEn;
        private double cantaAstarBoy;

        private double cantaSungerEn;
        private double cantaSungerBoy;

        private double cantaDenyaEn;
        private double cantaDenyaBoy;

        private double cantaSkayEn;
        private double cantaSkayBoy;

        private double cantaDeri1En;
        private double cantaDeri1Boy;

        private double cantaDeri2En;
        private double cantaDeri2Boy;

        private string cantaMukavvaTuru;
        private string cantaMukavvaAdet;
        private double cantaMukavvaFiyati;
        private double cantaMukavvaBirimFiyati;

        private double cantaAstarBirimFiyati;
        private double cantaAstarFiyati;

        private double cantaDenyaBirimFiyati;
        private double cantaDenyaFiyati;

        private double cantaSkayBirimFiyati;
        private double cantaSkayFiyati;

        private double cantaSungerFiyati;
        private double cantaSungerBirimFiyati;

        private double cantaDeri1Fiyati;
        private double cantaDeri1BirimFiyati;

        private double cantaDeri2Fiyati;
        private double cantaDeri2BirimFiyati;

        private double cantaKolonBirimFiyati;
        private double cantaKolonMetreFiyati;

        private double cantaCirtBirimFiyati;
        private double cantaCirtMetreFiyati;

        private double cantaLastikBirimFiyati;
        private double cantaLastikMetreFiyati;

        private double cantaFermuarBirimFiyati;
        private double cantaFermuarMetreFiyati;

      

        private double cantaEvaBirimFiyati;
        private double cantaEvaMetreFiyati;

        

        private double cantaSalpaBirimFiyati;
        private double cantaSalpaMetreFiyati;

        private double cantaPlastikTokaBirimFiyati;
        private double cantaPlastikKamburBirimFiyati;
        private double cantaPlastikKilitBirimFİyati;
        private double cantaKilitSifreliBirimFİyati;
        private double cantaKilitSifresizBirimFiyati;
        private double cantaBoncukYarmaBirimFiyati;
        private double cantaYanSikmaBirimFiyati;
        private double cantaMiknatisBirimFiyati;
        private double cantaTokaBirimFiyati;
        private double cantaMekanizmaBirimFiyati;
        private double cantaSustaBirimFiyati;
        private double cantaTorukBirimFiyati;
        private double cantaKamburTokaBirimFiyati;
        private double cantaSurgutBirimFiyati;
        private double cantaOmuzlukBirimFiyati;
        private double cantaCubukSapiBirimFiyati;
        private double cantaDugmeTorukBirimFiyati;
        private double cantaKapsulBirimFiyati;
        private double cantaKoseBirimFİyati;
        private double cantaFermuarElcikBirimFiyati;
        private double cantaDHalkaBirimFiyati;
        private double cantaKareHalkaBirimFiyati;
        private double cantaKaburaBirimFiyati;
        private double cantaPlastikFitilBirimFiyati;
        private double cantaBezFitilBirimFiyati;

        private int cantaPlastikTokaAdet;
        private int cantaPlastikKamburAdet;
        private int cantaPlastikKilitAdet;
        private int cantaKilitSifreliAdet;
        private int cantaKilitSifresizAdet;
        private int cantaBoncukYarmaAdet;
        private int cantaYanSikmaAdet;
        private int cantaMiknatisAdet;
        private int cantaTokaAdet;
        private int cantaMekanizmaAdet;
        private int cantaSustaAdet;
        private int cantaTorukAdet;
        private int cantaKamburTokaAdet;
        private int cantaSurgutAdet;
        private int cantaOmuzlukAdet;
        private int cantaCubukSapiAdet;
        private int cantaDugmeTorukAdet;
        private int cantaKapsulAdet;
        private int cantaKoseAdet;
        private int cantaFermuarElcikAdet;
        private int cantaDHalkaAdet;
        private int cantaKareHalkaAdet;
        private int cantaKaburaAdet;

        private double cantaBaskiBirimFİyati;
        private double cantaBicakBirimFiyati;
        private double cantaKeskiBirimFiyati;
        private double cantaSolusyonBirimFİyati;
        private double cantaİplikBirimFiyati;







        public string CantaUrunAdi { get => cantaUrunAdi; set => cantaUrunAdi = value; }
        public string CantaUrunAdedi { get => cantaUrunAdedi; set => cantaUrunAdedi = value; }
        public double CantaUrunEn { get => cantaUrunEn; set => cantaUrunEn = value; }
   
        public double CantaUrunBoy { get => cantaUrunBoy; set => cantaUrunBoy = value; }
        public string CantaMukavvaTuru { get => cantaMukavvaTuru; set => cantaMukavvaTuru = value; }
        public string CantaMukavvaAdet { get => cantaMukavvaAdet; set => cantaMukavvaAdet = value; }
        public double CantaMukavvaFiyati { get => cantaMukavvaFiyati; set => cantaMukavvaFiyati = value; }
        public double CantaMukavvaBirimFiyati { get => cantaMukavvaBirimFiyati; set => cantaMukavvaBirimFiyati = value; }
        public double CantaAstarBirimFiyati { get => cantaAstarBirimFiyati; set => cantaAstarBirimFiyati = value; }
        public double CantaKolonBirimFiyati { get => cantaKolonBirimFiyati; set => cantaKolonBirimFiyati = value; }
        public double CantaCirtBirimFiyati { get => cantaCirtBirimFiyati; set => cantaCirtBirimFiyati = value; }
        public double CantaLastikBirimFiyati { get => cantaLastikBirimFiyati; set => cantaLastikBirimFiyati = value; }
        public double CantaFermuarBirimFiyati { get => cantaFermuarBirimFiyati; set => cantaFermuarBirimFiyati = value; }
      
        public double CantaEvaBirimFiyati { get => cantaEvaBirimFiyati; set => cantaEvaBirimFiyati = value; }
        public double CantaDenyaBirimFiyati { get => cantaDenyaBirimFiyati; set => cantaDenyaBirimFiyati = value; }
        public double CantaSkayBirimFiyati { get => cantaSkayBirimFiyati; set => cantaSkayBirimFiyati = value; }
        public double CantaPlastikTokaBirimFiyati { get => cantaPlastikTokaBirimFiyati; set => cantaPlastikTokaBirimFiyati = value; }
        public double CantaPlastikKamburBirimFiyati { get => cantaPlastikKamburBirimFiyati; set => cantaPlastikKamburBirimFiyati = value; }
        public double CantaPlastikKilitBirimFİyati { get => cantaPlastikKilitBirimFİyati; set => cantaPlastikKilitBirimFİyati = value; }
        public double CantaKilitSifreliBirimFİyati { get => cantaKilitSifreliBirimFİyati; set => cantaKilitSifreliBirimFİyati = value; }
        public double CantaKilitSifresizBirimFiyati { get => CantaKilitSifresizBirimFiyati1; set => CantaKilitSifresizBirimFiyati1 = value; }
        public double CantaKilitSifresizBirimFiyati1 { get => cantaKilitSifresizBirimFiyati; set => cantaKilitSifresizBirimFiyati = value; }
        public double CantaBoncukYarmaBirimFiyati { get => cantaBoncukYarmaBirimFiyati; set => cantaBoncukYarmaBirimFiyati = value; }
        public double CantaYanSikmaBirimFiyati { get => cantaYanSikmaBirimFiyati; set => cantaYanSikmaBirimFiyati = value; }
        public double CantaMiknatisBirimFiyati { get => cantaMiknatisBirimFiyati; set => cantaMiknatisBirimFiyati = value; }
        public double CantaTokaBirimFiyati { get => cantaTokaBirimFiyati; set => cantaTokaBirimFiyati = value; }
        public double CantaMekanizmaBirimFiyati { get => cantaMekanizmaBirimFiyati; set => cantaMekanizmaBirimFiyati = value; }
        public double CantaSustaBirimFiyati { get => cantaSustaBirimFiyati; set => cantaSustaBirimFiyati = value; }
        public double CantaTorukBirimFiyati { get => cantaTorukBirimFiyati; set => cantaTorukBirimFiyati = value; }
        public double CantaKamburTokaBirimFiyati { get => cantaKamburTokaBirimFiyati; set => cantaKamburTokaBirimFiyati = value; }
        public double CantaSurgutBirimFiyati { get => cantaSurgutBirimFiyati; set => cantaSurgutBirimFiyati = value; }
        public double CantaOmuzlukBirimFiyati { get => cantaOmuzlukBirimFiyati; set => cantaOmuzlukBirimFiyati = value; }
        public double CantaCubukSapiBirimFiyati { get => cantaCubukSapiBirimFiyati; set => cantaCubukSapiBirimFiyati = value; }
        public double CantaDugmeTorukBirimFiyati { get => cantaDugmeTorukBirimFiyati; set => cantaDugmeTorukBirimFiyati = value; }
        public double CantaKapsulBirimFiyati { get => cantaKapsulBirimFiyati; set => cantaKapsulBirimFiyati = value; }
        public double CantaKoseBirimFİyati { get => cantaKoseBirimFİyati; set => cantaKoseBirimFİyati = value; }
        public double CantaFermuarElcikBirimFiyati { get => cantaFermuarElcikBirimFiyati; set => cantaFermuarElcikBirimFiyati = value; }
        public double CantaDHalkaBirimFiyati { get => cantaDHalkaBirimFiyati; set => cantaDHalkaBirimFiyati = value; }
        public double CantaKareHalkaBirimFiyati { get => cantaKareHalkaBirimFiyati; set => cantaKareHalkaBirimFiyati = value; }
        public double CantaKaburaBirimFiyati { get => cantaKaburaBirimFiyati; set => cantaKaburaBirimFiyati = value; }
        public double CantaAstarEn { get => cantaAstarEn; set => cantaAstarEn = value; }
        public double CantaAstarBoy { get => cantaAstarBoy; set => cantaAstarBoy = value; }
        public double CantaDenyaEn { get => cantaDenyaEn; set => cantaDenyaEn = value; }
        public double CantaDenyaBoy { get => cantaDenyaBoy; set => cantaDenyaBoy = value; }
        public double CantaSkayEn { get => cantaSkayEn; set => cantaSkayEn = value; }
        public double CantaSkayBoy { get => cantaSkayBoy; set => cantaSkayBoy = value; }
        public double CantaDeri1Boy { get => cantaDeri1Boy; set => cantaDeri1Boy = value; }
        public double CantaDeri1En { get => cantaDeri1En; set => cantaDeri1En = value; }
        public double CantaDeri2En { get => cantaDeri2En; set => cantaDeri2En = value; }
        public double CantaDeri2Boy { get => cantaDeri2Boy; set => cantaDeri2Boy = value; }
        public double CantaAstarFiyati { get => cantaAstarFiyati; set => cantaAstarFiyati = value; }
        public double CantaDenyaFiyati { get => cantaDenyaFiyati; set => cantaDenyaFiyati = value; }
        public double CantaSkayFiyati { get => cantaSkayFiyati; set => cantaSkayFiyati = value; }
        public double CantaSungerFiyati { get => cantaSungerFiyati; set => cantaSungerFiyati = value; }
        public double CantaSungerBirimFiyati { get => cantaSungerBirimFiyati; set => cantaSungerBirimFiyati = value; }
        public double CantaDeri1Fiyati { get => cantaDeri1Fiyati; set => cantaDeri1Fiyati = value; }
        public double CantaDeri1BirimFiyati { get => cantaDeri1BirimFiyati; set => cantaDeri1BirimFiyati = value; }
        public double CantaDeri2Fiyati { get => cantaDeri2Fiyati; set => cantaDeri2Fiyati = value; }
        public double CantaDeri2BirimFiyati { get => cantaDeri2BirimFiyati; set => cantaDeri2BirimFiyati = value; }
        public double CantaKolonMetreFiyati { get => cantaKolonMetreFiyati; set => cantaKolonMetreFiyati = value; }
        public double CantaCirtMetreFiyati { get => cantaCirtMetreFiyati; set => cantaCirtMetreFiyati = value; }
        public double CantaLastikMetreFiyati { get => cantaLastikMetreFiyati; set => cantaLastikMetreFiyati = value; }
        public double CantaFermuarMetreFiyati { get => cantaFermuarMetreFiyati; set => cantaFermuarMetreFiyati = value; }
        public double CantaEvaMetreFiyati { get => cantaEvaMetreFiyati; set => cantaEvaMetreFiyati = value; }
        public double CantaSalpaBirimFiyati { get => cantaSalpaBirimFiyati; set => cantaSalpaBirimFiyati = value; }
        public double CantaSalpaMetreFiyati { get => cantaSalpaMetreFiyati; set => cantaSalpaMetreFiyati = value; }
        public double CantaPlastikFitilBirimFiyati { get => cantaPlastikFitilBirimFiyati; set => cantaPlastikFitilBirimFiyati = value; }
       
        public int CantaPlastikTokaAdet { get => cantaPlastikTokaAdet; set => cantaPlastikTokaAdet = value; }
        public int CantaPlastikKamburAdet { get => cantaPlastikKamburAdet; set => cantaPlastikKamburAdet = value; }
        public int CantaPlastikKilitAdet { get => cantaPlastikKilitAdet; set => cantaPlastikKilitAdet = value; }
        public int CantaKilitSifreliAdet { get => cantaKilitSifreliAdet; set => cantaKilitSifreliAdet = value; }
        public int CantaKilitSifresizAdet { get => cantaKilitSifresizAdet; set => cantaKilitSifresizAdet = value; }
        public int CantaBoncukYarmaAdet { get => cantaBoncukYarmaAdet; set => cantaBoncukYarmaAdet = value; }
        public int CantaYanSikmaAdet { get => cantaYanSikmaAdet; set => cantaYanSikmaAdet = value; }
        public int CantaMiknatisAdet { get => cantaMiknatisAdet; set => cantaMiknatisAdet = value; }
        public int CantaTokaAdet { get => cantaTokaAdet; set => cantaTokaAdet = value; }
        public int CantaMekanizmaAdet { get => cantaMekanizmaAdet; set => cantaMekanizmaAdet = value; }
        public int CantaSustaAdet { get => cantaSustaAdet; set => cantaSustaAdet = value; }
        public int CantaTorukAdet { get => cantaTorukAdet; set => cantaTorukAdet = value; }
        public int CantaKamburTokaAdet { get => cantaKamburTokaAdet; set => cantaKamburTokaAdet = value; }
        public int CantaSurgutAdet { get => cantaSurgutAdet; set => cantaSurgutAdet = value; }
        public int CantaOmuzlukAdet { get => cantaOmuzlukAdet; set => cantaOmuzlukAdet = value; }
        public int CantaCubukSapiAdet { get => cantaCubukSapiAdet; set => cantaCubukSapiAdet = value; }
        public int CantaDugmeTorukAdet { get => cantaDugmeTorukAdet; set => cantaDugmeTorukAdet = value; }
        public int CantaKapsulAdet { get => cantaKapsulAdet; set => cantaKapsulAdet = value; }
        public int CantaKoseAdet { get => cantaKoseAdet; set => cantaKoseAdet = value; }
        public int CantaFermuarElcikAdet { get => cantaFermuarElcikAdet; set => cantaFermuarElcikAdet = value; }
        public int CantaDHalkaAdet { get => cantaDHalkaAdet; set => cantaDHalkaAdet = value; }
        public int CantaKareHalkaAdet { get => cantaKareHalkaAdet; set => cantaKareHalkaAdet = value; }
        public int CantaKaburaAdet { get => cantaKaburaAdet; set => cantaKaburaAdet = value; }
        public double CantaBaskiBirimFİyati { get => cantaBaskiBirimFİyati; set => cantaBaskiBirimFİyati = value; }
        public double CantaBicakBirimFiyati { get => cantaBicakBirimFiyati; set => cantaBicakBirimFiyati = value; }
        public double CantaKeskiBirimFiyati { get => cantaKeskiBirimFiyati; set => cantaKeskiBirimFiyati = value; }
        public double CantaSolusyonBirimFİyati { get => cantaSolusyonBirimFİyati; set => cantaSolusyonBirimFİyati = value; }
        public double CantaİplikBirimFiyati { get => cantaİplikBirimFiyati; set => cantaİplikBirimFiyati = value; }
        public double CantaSungerEn1 { get => CantaSungerEn; set => CantaSungerEn = value; }
        public double CantaSungerBoy1 { get => CantaSungerBoy; set => CantaSungerBoy = value; }
        public double CantaSungerEn { get => cantaSungerEn; set => cantaSungerEn = value; }
        public double CantaSungerBoy { get => cantaSungerBoy; set => cantaSungerBoy = value; }
        public double CantaBezFitilBirimFiyati { get => cantaBezFitilBirimFiyati; set => cantaBezFitilBirimFiyati = value; }
    }
}
