using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TemperatureMethod.Models;

namespace TemperatureMethod.SummariesByFile
{
    internal class XMLRecordSummary : RecordSummary
    {
        public override string extension => ".xml";
        
        public override void ReadFile()
        {
            using (var reader = new StreamReader(pathToRead))
            {
                var serializer = new XmlSerializer(typeof(ReadingSummary));
                this.summary = (ReadingSummary)serializer.Deserialize(reader);
            }
        }
    }
}
