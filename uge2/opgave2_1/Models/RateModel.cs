using System.Collections.Generic;
using System.Xml.Serialization;

namespace opgave2_1
{
    [XmlRoot("exchangerates")]
    public class ExchangeRates
    {
        [XmlElement("dailyrates")]
        public Rate DailyRates { get; set; } = new Rate();
    }

    public class Rate
    {
        [XmlElement("currency")]
        public List<Currency> Currencies { get; set; }

    }

    public class Currency
    {
        [XmlAttribute("code")]
        public string Code { get; set; }

        [XmlAttribute("desc")]
        public string Desc { get; set; }

        [XmlAttribute("rate")]
        public string Rate { get; set; }
    }

    public class RateModel
    {
        public string Code { get; set; }

        public string Desc { get; set; }

        public double Rate { get; set; }

        public override string ToString()
        {
            return Desc + " : " + Rate.ToString();
        }
    }

    // public class RateCollectionModel
    // {
    //     [XmlArrayItem("currency")]
    //     public RateModel[] Currencies { get; set; }
    // }
}