using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TemperatureMethod.Models;
using Newtonsoft.Json;
using System.IO;

namespace TemperatureMethod.SummariesByFile
{
    public class JsonRecordSummary : RecordSummary
    {
        public override string extension => ".json";

        public override void ReadFile()
        {
            using (var reader = new StreamReader(pathToRead))
            {
                string readingsFromJson = reader.ReadToEnd();
                List<Reading> readings = JsonConvert.DeserializeObject<List<Reading>>(readingsFromJson);
                foreach (var item in readings)
                {
                    summary.FileReadings.Add(item);
                }
            }
        }
    }
}
