using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TemperatureMethod.Models
{
    [XmlRoot(ElementName = "row")]
    public class Reading
    {
        [XmlElement(ElementName = "id")]
        public int ID { get; set; }
        [XmlElement(ElementName = "location")]
        public string Location { get; set; }
        [XmlElement(ElementName = "date")]
        public DateTime Date { get; set; }
        [XmlElement(ElementName = "meassure")]
        public decimal Meassure { get; set; }
        private Reading() { }
        public Reading(int id, string location, DateTime date, decimal meassure)
        {
            this.ID = id;
            this.Location = location;
            this.Date = date;
            this.Meassure = meassure;
        }
    }
}
