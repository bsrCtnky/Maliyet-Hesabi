using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_MaliyetHesaplama
{
    class KutuMaliyet
    {
        private string kutuUrunAdi;
        private string kutuUrunAdedi;
        private double kutuUrunEn;
        private double kutuUrunBoy;
        private double kutuUrunYukseklik;
        private string kutuKagitModeli;
        private double kutuKagitModeliBirimFiyati;
        private double kutuBicakVeKesimFiyati;
        private double kutuRenkMaliyetiFiyati;
        private string kutuBaskiTuru;
        private double kutuBaskiTuruBirimFiyati;
        private double kutuMetalAksesuarFiyati;
        private double kutuKilitFiyati;
        private double kutuLastikFiyati;
        private double kutuKagitBaskiFiyati;
        private double kutuDikisFiyati;
        private double kutuFlokFiyati;
        private double kutuMiknatisFiyati;
        private string kutuMukavvaTuru;
        private string kutuMukavvaAdet;
        private double kutuMukavvaFiyati;
        private double kutuMukavvaBirimFiyati;
        private double kutuMDFKasaFiyati;
        private double kutuTutkallamaFiyati;
        private double kutuSungerFiyati;
        private double kutuEvaFiyati;
        private double kutuIstifvePaketlemeFiyati;
        private double kutuKarToplami;
        private string kutuKarToplam;


        
        public string KutuUrunAdi { get => kutuUrunAdi; set => kutuUrunAdi = value; }
        public string KutuUrunAdedi { get => kutuUrunAdedi; set => kutuUrunAdedi = value; }
        public double KutuUrunEn { get => kutuUrunEn; set => kutuUrunEn = value; }
        public double KutuUrunBoy { get => kutuUrunBoy; set => kutuUrunBoy = value; }
        public double KutuUrunYukseklik { get => kutuUrunYukseklik; set => kutuUrunYukseklik = value; }
        public string KutuKagitModeli { get => kutuKagitModeli; set => kutuKagitModeli = value; }
        public double KutuKagitModeliBirimFiyati { get => kutuKagitModeliBirimFiyati; set => kutuKagitModeliBirimFiyati = value; }
        public double KutuBicakVeKesimFiyati { get => kutuBicakVeKesimFiyati; set => kutuBicakVeKesimFiyati = value; }
        public double KutuRenkMaliyetiFiyati { get => kutuRenkMaliyetiFiyati; set => kutuRenkMaliyetiFiyati = value; }
        public string KutuBaskiTuru { get => kutuBaskiTuru; set => kutuBaskiTuru = value; }
        public double KutuBaskiTuruBirimFiyati { get => kutuBaskiTuruBirimFiyati; set => kutuBaskiTuruBirimFiyati = value; }
        public double KutuMetalAksesuarFiyati { get => kutuMetalAksesuarFiyati; set => kutuMetalAksesuarFiyati = value; }
        public double KutuKilitFiyati { get => kutuKilitFiyati; set => kutuKilitFiyati = value; }
        public double KutuLastikFiyati { get => kutuLastikFiyati; set => kutuLastikFiyati = value; }
        public double KutuKagitBaskiFiyati { get => kutuKagitBaskiFiyati; set => kutuKagitBaskiFiyati = value; }
        public double KutuDikisFiyati { get => kutuDikisFiyati; set => kutuDikisFiyati = value; }
        public double KutuFlokFiyati { get => kutuFlokFiyati; set => kutuFlokFiyati = value; }
        public double KutuMiknatisFiyati { get => kutuMiknatisFiyati; set => kutuMiknatisFiyati = value; }
        public string KutuMukavvaTuru { get => kutuMukavvaTuru; set => kutuMukavvaTuru = value; }
        public string KutuMukavvaAdet { get => kutuMukavvaAdet; set => kutuMukavvaAdet = value; }
        public double KutuMukavvaFiyati { get => kutuMukavvaFiyati; set => kutuMukavvaFiyati = value; }
        public double KutuMukavvaBirimFiyati { get => kutuMukavvaBirimFiyati; set => kutuMukavvaBirimFiyati = value; }
        public double KutuMDFKasaFiyati { get => kutuMDFKasaFiyati; set => kutuMDFKasaFiyati = value; }
       
        public double KutuSungerFiyati { get => kutuSungerFiyati; set => kutuSungerFiyati = value; }
        public double KutuEvaFiyati { get => kutuEvaFiyati; set => kutuEvaFiyati = value; }
        public double KutuIstifvePaketlemeFiyati { get => kutuIstifvePaketlemeFiyati; set => kutuIstifvePaketlemeFiyati = value; }
        public double KutuKarToplami { get => kutuKarToplami; set => kutuKarToplami = value; }
        public string KutuKarToplam { get => kutuKarToplam; set => kutuKarToplam = value; }
        public double KutuTutkallamaFiyati { get => kutuTutkallamaFiyati; set => kutuTutkallamaFiyati = value; }
    }
}
