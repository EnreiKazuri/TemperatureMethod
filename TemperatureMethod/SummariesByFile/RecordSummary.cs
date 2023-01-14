using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureMethod.Models;

namespace TemperatureMethod.SummariesByFile
{
    public abstract class RecordSummary
    {
        public string pathToRead = @"..\..\..\Sample-Files\data";
        public string pathToWrite = @"..\..\..\Sample-Files\data";
        public abstract string extension { get;}
        public ReadingSummary summary;
        public RecordSummary(){ this.summary = new ReadingSummary(); pathToRead += extension; pathToWrite += extension + ".out.csv"; }
        public void ExecuteRead()
        {
            ReadFile();
            summary.PopulateValues();
        }
        public void ExecuteWrite()
        {
            WriteFile();
        }
        public abstract void ReadFile();
        
        public void WriteFile()
        {
           File.WriteAllText(pathToWrite, summary.StatsString);
        }
    }
}
