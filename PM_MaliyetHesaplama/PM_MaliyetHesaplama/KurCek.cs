using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_MaliyetHesaplama
{
    class KurCek
    {
        public decimal GetRate(string code)
        {
            string url = string.Empty;
            var date = DateTime.Now;
            if (date.Date == DateTime.Today)
                url = "http://www.tcmb.gov.tr/kurlar/today.xml";
            else
                url = string.Format("http://www.tcmb.gov.tr/kurlar/{0}{1}/{2}{1}{0}.xml", date.Year, AddZero(date.Month), AddZero(date.Day));

            System.Xml.Linq.XDocument document = System.Xml.Linq.XDocument.Load(url);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var result = document.Descendants("Currency")
            .Where(v => v.Element("ForexBuying") != null && v.Element("ForexBuying").Value.Length > 0)
            .Select(v => new Currency
            {
                Code = v.Attribute("Kod").Value,
                Rate = decimal.Parse(v.Element("ForexBuying").Value.Replace('.', ','))
            }).ToList();
            return result.FirstOrDefault(s => s.Code == code).Rate;
        }

        public class Currency
        {
            public string Code { get; set; }
            public decimal Rate { get; set; }
        }

        private string AddZero(int p)
        {
            if (p.ToString().Length == 1)
                return "0" + p;
            return p.ToString();
        }
    }
}
