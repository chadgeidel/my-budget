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
        public void ImportFiles()
        {
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Documents\\Bank\\2020 Statements";
            var di = new System.IO.DirectoryInfo(readDir);

            var records = new List<IBankExport>();

            foreach (var file in di.GetFiles())
            {
                // ignore non-april files
                if (!file.Name.Contains("2020-04"))
                {
                    continue;
                }

                Console.WriteLine(file.ToString());

                if (file.Name.ToLower().Contains("bhfcu checking"))
                {
                    records.AddRange(ReadBhfcuCheckFile(file.FullName));
                }
                else if (file.Name.ToLower().Contains("bhfcu cc"))
                {
                    records.AddRange(ReadBhfcuCcFile(file.FullName));
                }
                else if (file.Name.ToLower().Contains("wells fargo checking"))
                {
                    var a = ReadWfCheckFile(file.FullName);
                    records.AddRange(a);
                }
                else if (file.Name.ToLower().Contains("wells fargo cc"))
                {
                    records.AddRange(ReadWfCcFile(file.FullName));
                }
                else
                {
                    Console.WriteLine("\tNo file reader for this file.");
                }
            }

            //var jan = records.Where(r => r.Date.Month == 1);
            //var feb = records.Where(r => r.Date.Month == 2);
            //var mar = records.Where(r => r.Date.Month == 3);
            var apr = records.Where(r => r.Date.Month == 4);
            var individualCount = apr.Count(); // jan.Count() + feb.Count() + mar.Count();
            if (individualCount != records.Count())
            {
                throw new Exception("Records are missing in individual months!");
            }

            //WriteToCsv(records, $"CombinedRecords-{DateTime.Now.ToFileTime()}.csv");
            //WriteToCsv(jan, $"January-{DateTime.Now.ToFileTime()}.csv");
            //WriteToCsv(feb, $"February-{DateTime.Now.ToFileTime()}.csv");
            //WriteToCsv(mar, $"March-{DateTime.Now.ToFileTime()}.csv");
            WriteToCsv(apr, $"April-{DateTime.Now.ToFileTime()}.csv");
        }

        private static void WriteToCsv(IEnumerable<IBankExport> records, string filename)
        {
            using var writer = File.AppendText(filename);
            writer.WriteLine("Date,Details,Debit,Credit,RecordType");
            foreach (var record in records)
            {
                writer.WriteLine(record);
            }

            // what am I doing wrong here?
            //var engine = new FileHelperEngine<IBankExport>();
            //engine.WriteFile($"CombinedRecords-{DateTime.Now.ToFileTime()}.csv", records);
        }

        //private BankExport ReadBankFile<BankFileType>(string filename)
        //{
        //    var bhEngine = new FileHelperEngine<BankFileType>();
        //    return bhEngine.ReadFile(filename);
        //}

        private BhfcuCheckRecord[] ReadBhfcuCheckFile(string filename)
        {
            var bhEngine = new FileHelperEngine<BhfcuCheckRecord>();
            return bhEngine.ReadFile(filename);
        }

        private BhfcuCcRecord[] ReadBhfcuCcFile(string filename)
        {
            var bhEngine = new FileHelperEngine<BhfcuCcRecord>();
            return bhEngine.ReadFile(filename);
        }

        private WellsFargoCheckRecord[] ReadWfCheckFile(string filename)
        {
            var wfEngine = new FileHelperEngine<WellsFargoCheckRecord>();
            return wfEngine.ReadFile(filename);
        }

        private WellsFargoCcRecord[] ReadWfCcFile(string filename)
        {
            var wfEngine = new FileHelperEngine<WellsFargoCcRecord>();
            return wfEngine.ReadFile(filename);
        }
    }
}
