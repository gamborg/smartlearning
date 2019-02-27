using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace opgave2_1
{
    class RateService
    {
        const string ExternalFeed = "http://www.nationalbanken.dk/_vti_bin/DN/DataService.svc/CurrencyRatesXML?lang=da";

        private Dictionary<string, RateModel> Rates { get; set; }
        public bool IsLoading { get; private set; }

        public RateService(bool loadData = true)
        {
            Rates = new Dictionary<string, RateModel>();
            if (loadData)
            {
                LoadExtenalData();
            }
        }

        public RateModel GetRate(string symbol)
        {
            if (IsLoading)
            {
                return null;
            }

            if (Rates.ContainsKey(symbol))
            {
                return Rates[symbol];
            }

            return null;
        }

        private bool LoadExtenalData()
        {
            IsLoading = true;
            using (var client = new WebClient())
            {
                var xml = client.DownloadString(new Uri(ExternalFeed));

                XmlSerializer serializer = new XmlSerializer(typeof(ExchangeRates));
                var xmlReader = new StringReader(xml);

                var rateCollectionModel = (ExchangeRates)serializer.Deserialize(xmlReader);
                foreach (var cur in rateCollectionModel.DailyRates.Currencies)
                {
                    var rate = double.Parse(cur.Rate.Replace(",","."));
                    Rates.Add(cur.Code, new RateModel { Rate = rate, Code = cur.Code, Desc = cur.Desc });
                }

            }
            IsLoading = false;
            return true;
        }
    }
}