using FileHelpers;
using MyBudget.ImportTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyBudget
{
    class BudgetImporter
    {
        private readonly List<IBankExport> records;

        public BudgetImporter()
        {
            records = new List<IBankExport>();
        }

        public void ImportFiles(Months importMonth, string sourceDir)
        {
            var monthToImport = (int)importMonth;
            var di = new DirectoryInfo(sourceDir);
            var monthPattern = $"*{DateTime.Now.Year}-{monthToImport:D2}*.csv";

            // get all files matching pattern, if no files exist this will exit
            foreach (var file in di.GetFiles(monthPattern))
            {
                switch (file.Name)
                {
                    case string bhfcuchk when bhfcuchk.Contains("bhfcu checking", StringComparison.OrdinalIgnoreCase):
                        records.AddRange(ReadBankFile<BhfcuCheckRecord>(file.FullName));
                        break;
                    case string bhfcucc when bhfcucc.Contains("bhfcu cc", StringComparison.OrdinalIgnoreCase):
                        records.AddRange(ReadBankFile<BhfcuCcRecord>(file.FullName));
                        break;
                    case string wfchk when wfchk.Contains("wells fargo checking", StringComparison.OrdinalIgnoreCase):
                        records.AddRange(ReadBankFile<WellsFargoCheckRecord>(file.FullName));
                        break;
                    case string wfcc when wfcc.Contains("wells fargo cc", StringComparison.OrdinalIgnoreCase):
                        records.AddRange(ReadBankFile<WellsFargoCcRecord>(file.FullName));
                        break;
                    default:
                        Console.WriteLine("\tNo file reader for this file.");
                        break;
                }
            }
        }

        public void WriteToCsv(string filename)
        {
            using var writer = File.AppendText(filename);
            writer.WriteLine("Date,Details,Debit,Credit,RecordType,Bucket");
            foreach (var record in records.OrderBy(r => r.Date))
            {
                writer.WriteLine(record.ToCsvString() + $",{GetBucket(record.Details)}");
            }
        }

        public void WriteToCsv(string filename, Months specificMonth)
        {
            using var writer = File.AppendText(filename);
            writer.WriteLine("Date,Details,Debit,Credit,RecordType,Bucket");
            foreach (var record in records
                .Where(m => m.Date.Month == (int)specificMonth)
                .OrderBy(r => r.Date))
            {
                writer.WriteLine(record.ToCsvString() + $",{GetBucket(record.Details)}");
            }
        }

        private static string GetBucket(string description)
        {
            return TermMapping.SearchTermMapping.FirstOrDefault(kvp => description.ToLower().Contains(kvp.Key)).Value ?? string.Empty;
        }

        private static T[] ReadBankFile<T>(string filename) where T : class
        {
            var bhEngine = new FileHelperEngine<T>();
            return bhEngine.ReadFile(filename);
        }
    }
}
