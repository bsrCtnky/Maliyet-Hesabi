using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_MaliyetHesaplama
{
    class MukavvaAttribute
    {
        private string bireKacAd;
        private int bireKacDeger;
        private string mukavvaTuru;
        private int mukavvaAdet;

        public string BireKacAd { get => bireKacAd; set => bireKacAd = value; }
        public int BireKacDeger { get => bireKacDeger; set => bireKacDeger = value; }
        public string MukavvaTuru { get => mukavvaTuru; set => mukavvaTuru = value; }
        public int MukavvaAdet { get => mukavvaAdet; set => mukavvaAdet = value; }
    }
}
