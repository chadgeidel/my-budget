using FileHelpers;
using MyBudget.ImportTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace MyBudget
{
    class BudgetImporter
    {
        public void ImportFiles(Months importMonth, string sourceDir)
        {
            var monthToImport = (int)importMonth;
            var di = new DirectoryInfo(sourceDir);
            var monthPattern = $"*{DateTime.Now.Year}-{monthToImport:D2}*";
            var records = new List<IBankExport>();
            
            foreach (var file in di.GetFiles(monthPattern))
            {
                Console.WriteLine(file);

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

            WriteToCsv(records, $"{DateTime.Now:yyyy}-{monthToImport:D2}-{DateTime.Now.ToFileTime()}.csv");
        }

        private static void WriteToCsv(IEnumerable<IBankExport> records, string filename)
        {
            using var writer = File.AppendText(filename);
            writer.WriteLine("Date,Details,Debit,Credit,RecordType");
            foreach (var record in records)
            {
                writer.WriteLine(record.ToCsvString());
            }

            // what am I doing wrong here?
            //var engine = new FileHelperEngine<IBankExport>();
            //engine.WriteFile($"CombinedRecords-{DateTime.Now.ToFileTime()}.csv", records);
        }

        private T[] ReadBankFile<T>(string filename) where T : class
        {
            var bhEngine = new FileHelperEngine<T>();
            return bhEngine.ReadFile(filename);
        }
    }
}
