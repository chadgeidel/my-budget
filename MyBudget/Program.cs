using System;
using System.IO;

namespace MyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            var bi = new BudgetImporter();
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Budget\\Bank\\2021 Statements";

            // all
            //foreach (Months month in Enum.GetValues(typeof(Months)))
            //{
            //    if (!Directory.Exists(readDir))
            //    {
            //        Console.WriteLine($"Couldn't find {readDir}");
            //        break;
            //    }
            //    Console.WriteLine($"Importing {month}");
            //    bi.ImportFiles(month, readDir);
            //}
            //Console.WriteLine("Finshed importing");
            //bi.WriteToCsv($"{DateTime.Now.Year}-cumulative-{DateTime.Now.ToFileTime()}.csv");

            // month
            Months individualMonth = Months.March;
            bi.ImportFiles(individualMonth, readDir);
            bi.WriteToCsv($"{DateTime.Now.Year}-{individualMonth}-{DateTime.Now.ToFileTime()}.csv");
        }
    }
}
