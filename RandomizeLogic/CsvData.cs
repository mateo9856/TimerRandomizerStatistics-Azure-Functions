using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeLogic
{
    public class CsvData
    {
        private CsvConfiguration Reader { get; set; }

        public CsvData()
        {
            Reader = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord= false
            };
        }

        public List<Statistics> ReadStatisticsData()
        {
            try
            {
                using (var reader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "RandomizeLogic", "SampleCSVFile_11kb.csv")))
                using (var csv = new CsvReader(reader, Reader))
                {
                    var records = csv.GetRecords<Statistics>();
                    return records.ToList();
                }
            } catch {
                return new List<Statistics>();
            }
            
        }
    }
}
