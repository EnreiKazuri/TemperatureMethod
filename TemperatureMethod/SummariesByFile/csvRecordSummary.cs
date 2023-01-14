using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TemperatureMethod.Models;

namespace TemperatureMethod.SummariesByFile
{
    public class csvRecordSummary : RecordSummary
    {
        public override string extension => ".csv";

        public override void ReadFile()
        {
            var fileReading = File.ReadLines(pathToRead).ToList();
            fileReading.RemoveAt(0);
            foreach (var item in fileReading)
            {
                var splits = item.Split(',');
                var id = splits[0];
                var location = splits[1];
                var date = splits[2];
                var meassure = splits[3];
                summary.FileReadings.Add(new Reading(int.Parse(id), location, DateTime.Parse(date), decimal.Parse(meassure)));
            }
            //using (var reader = new StreamReader(pathToRead))
            //{
            //    var serializer = new CsvReader(reader, CultureInfo.InvariantCulture);
            //    serializer.Read();
            //    var readings = serializer.GetRecords<Reading>();
            //    foreach (var reading in readings.ToList())
            //    {
            //        summary.FileReadings.Add(reading);
            //    }
            //}
        }
    }
}
