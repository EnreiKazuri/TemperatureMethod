using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TemperatureMethod.Models
{
    [XmlRoot(ElementName = "data")]
    public class ReadingSummary
    {
        [XmlElement(ElementName = "row")]
        public List<Reading> FileReadings { get; set; }
        public decimal MinValues { get; set; }
        public decimal MaxValues { get; set; }
        public decimal Average { get; set; }
        public string StatsString { get; set; }

        public ReadingSummary()
        {
            this.FileReadings = new List<Reading>();
        }
        public void PopulateValues()
        {
            SortReadings();
            this.MinValues = ReturnMinValue();
            this.MaxValues = ReturnMaxValue();
            this.Average = ReturnAverage();
            PrintStats();
        }
        public void SortReadings()
        {
            FileReadings.Sort((x, y) => x.Meassure.CompareTo(y.Meassure));
        }
        public decimal ReturnMinValue() { return FileReadings.First().Meassure; }
        public decimal ReturnMaxValue() { return FileReadings.Last().Meassure; }
        public decimal ReturnAverage()
        {
            decimal totalMeassures = 0;
            foreach (var reading in FileReadings)
            {
                totalMeassures += reading.Meassure;
            }
            return totalMeassures/FileReadings.Count;
        }
        public void PrintStats()
        {
            StatsString = MaxValues + "," + MinValues + "," + Average;
            Console.WriteLine("Max: {0}, Min: {1}, Avg: {2}",this.MaxValues, this.MinValues, this.Average);
        }
    }
}
