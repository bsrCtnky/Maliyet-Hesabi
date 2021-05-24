using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_MaliyetHesaplama
{
    class TeklifAttribute
    {
        private string teklifUrunAdi;
        private int teklifUrunAdedi;
        private string teklifurunTuru;
        private int teklifUrunTuruID;
        private string teklifSahibi;
        private DateTime tarih;
        private double maliyet;

        public string TeklifUrunAdi { get => teklifUrunAdi; set => teklifUrunAdi = value; }
        public int TeklifUrunAdedi { get => teklifUrunAdedi; set => teklifUrunAdedi = value; }
        public string TeklifurunTuru { get => teklifurunTuru; set => teklifurunTuru = value; }
        public int TeklifUrunTuruID { get => teklifUrunTuruID; set => teklifUrunTuruID = value; }
        public string TeklifSahibi { get => teklifSahibi; set => teklifSahibi = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public double Maliyet { get => maliyet; set => maliyet = value; }
    }
}
