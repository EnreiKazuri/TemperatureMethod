using TemperatureMethod.SummariesByFile;
using Newtonsoft.Json;
using System.Globalization;

namespace TemperatureMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select which file to Read:\n(1) CSV\n(2) Json\n(3) XML");
                string decision = Console.ReadLine();
                switch (decision)
                {
                    case "1":
                        var csvFile = new csvRecordSummary();
                        csvFile.ExecuteRead();
                        csvFile.ExecuteWrite();
                        Console.ReadKey();
                        break;
                    case "2":
                        var jsonFile = new JsonRecordSummary();
                        jsonFile.ExecuteRead();
                        jsonFile.ExecuteWrite();
                        Console.ReadKey();
                        break;
                    case "3":
                        var xmlFile = new XMLRecordSummary();
                        xmlFile.ExecuteRead();
                        xmlFile.ExecuteWrite();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Please select a valid Choice");
                        Thread.Sleep(2000);
                        continue;
                }
            }
            
        }
    }
}