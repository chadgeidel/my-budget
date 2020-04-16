using FileHelpers;
using MyBudget.ImportTypes;
using System;
using System.Collections.Generic;
using System.IO;

namespace MyBudget
{
    class BudgetImporter
    {
        public void ImportFiles()
        {
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Documents\\Bank\\Budget\\2020 Statements";
            var di = new System.IO.DirectoryInfo(readDir);

            var records = new List<IBankExport>();

            foreach (var file in di.GetFiles())
            {
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

            using (var writer = File.AppendText($"CombinedRecords-{DateTime.Now.ToFileTime()}.csv"))
            {
                writer.WriteLine("Date,Details,Debit,Credit,RecordType");
                foreach (var record in records)
                {
                    writer.WriteLine(record);
                }
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
