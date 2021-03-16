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
        static readonly Dictionary <string, string> SearchTermMapping = new Dictionary<string, string>
        {
            // deposit
            {"colorado state", "Income"},
            // housing
            {"mortgage", "Mortgage"}, 
            // utilities
            {"xcel", "Utilities"},
            {"denver water", "Utilities"},
            {"comcast", "Utilities"},
            {"xfinity", "Utilities"},
            {"vzwrlss", "Utilities"},
            // insurance
            {"northwestern mu", "Insurance"},
            {"geico", "Insurance"},
            // storage
            {"clearhome", "Storage"},
            // shopping
            {"target", "Target"},
            {"costco whse", "Costco"},
            {"amzn.com", "Amazon"},
            {"sprouts", "Groceries"},
            {"king", "Groceries"},
            {"water - coffee", "Groceries"},
            {"wholefds", "Groceries"},
            {"safeway", "Groceries"},
            // health
            {"health", "Health"},
            {"walgreens", "Health"},
            {"salon velluto", "Health"},
            {"deanna woodroff", "Health"},
            {"ulta", "Health"},
            // doggos
            {"petsmart", "Doggos"},
            {"krisers", "Doggos"},
            {"petco", "Doggos"},
            {"chewy", "Doggos"},
            {"red rocks", "Doggos"},
            {"animal care", "Doggos"},
            // auto
            {"gas", "Auto"},
            {"ferney", "Auto"},
            {"metro express", "Auto"},
            {"co motor vehicle", "Auto"},
            // dining out
            {"tejado", "Restaurants"},
            {"good times", "Restaurants"},
            {"tasty house", "Restaurants"},
            {"kaos", "Restaurants"},
            {"illegal pete", "Restaurants"},
            {"starbucks", "Restaurants"},
            // booze
            {"hb liquor", "Booze"},
            {"total wine", "Booze"},
            {"argonaut", "Booze"},
            // apple
            {"apple.com", "Apple"},
            // streaming
            {"netflix", "Streaming"},
            {"youtube", "Streaming"},
            // electronics
            {"best buy", "Electronics"},
            {"micro center", "Electronics"},
            {"level 7", "Electronics"},
            {"backblaze", "Electronics"},
            {"iracing", "Electronics"},
            // home improvement
            {"ikea", "Home Improvement"},
            {"cost plus wld", "Home Improvement"},
            {"wm supercent", "Home Improvement"},
            {"lowes", "Home Improvement"},
            // clothes
            {"everlane", "Clothes"},
            {"mgemi", "Clothes"},
            {"uniqlo", "Clothes"},
            // atm
            {"atm", "ATM"},
            // shopping
            {"ebay", "Shopping"},
            {"fedex", "Shopping"}
        };

        private List<IBankExport> records;

        public BudgetImporter()
        {
            records = new List<IBankExport>();
        }

        public void ImportFiles(Months importMonth, string sourceDir)
        {
            var monthToImport = (int)importMonth;
            var di = new DirectoryInfo(sourceDir);
            var monthPattern = $"*{DateTime.Now.Year}-{monthToImport:D2}*";

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

            // what am I doing wrong here?
            //var engine = new FileHelperEngine<IBankExport>();
            //engine.WriteFile($"CombinedRecords-{DateTime.Now.ToFileTime()}.csv", records);
        }

        private static string GetBucket(string description)
        {
            return SearchTermMapping.FirstOrDefault(kvp => description.ToLower().Contains(kvp.Key)).Value ?? string.Empty;
        }

        private T[] ReadBankFile<T>(string filename) where T : class
        {
            var bhEngine = new FileHelperEngine<T>();
            return bhEngine.ReadFile(filename);
        }
    }
}
