﻿using System;
using System.IO;

namespace MyBudget
{
    class Program
    {
        static void Main()
        {
            var bi = new BudgetImporter();
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Budget\\Bank\\{DateTime.Today.Year} Statements";
            if (!Directory.Exists(readDir))
            {
                Console.WriteLine($"Couldn't find {readDir}");
                return;
            }

            // cumulative this year
            foreach (Months month in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine($"Importing {month}");
                bi.ImportFiles(month, readDir);
            }
            Console.WriteLine("Finshed importing");
            bi.WriteToCsv($"{DateTime.Now.Year}-cumulative-{DateTime.Now.ToFileTime()}.csv");

            //// one month
            //Months individualMonth = Months.May;
            //bi.ImportFiles(individualMonth, readDir);
            //bi.WriteToCsv($"{DateTime.Now.Year}-{individualMonth}-{DateTime.Now.ToFileTime()}.csv");
        }
    }
}
