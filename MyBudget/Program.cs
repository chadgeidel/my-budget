using System;
using System.IO;

namespace MyBudget
{
    class Program
    {
        static void Main()
        {
            var bi = new BudgetImporter();
            var year = DateTime.Today.Year;
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Budget\\Bank\\{year} Statements";
            if (!Directory.Exists(readDir))
            {
                Console.WriteLine($"Couldn't find {readDir}");
                return;
            }

            foreach (Months month in Enum.GetValues(typeof(Months)))
            {
                var imported = bi.ImportFiles(year, month, readDir);
                if (imported)
                {
                    // write individual month csv
                    bi.WriteToCsv($"{year}-{month}-{DateTime.Now.ToFileTime()}.csv", month);
                }
            }
            Console.WriteLine("Finshed importing");

            // write cumulative csv
            bi.WriteToCsv($"{year}-cumulative-{DateTime.Now.ToFileTime()}.csv");
        }
    }
}
