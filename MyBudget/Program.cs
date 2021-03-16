using System;

namespace MyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            var bi = new BudgetImporter();
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Budget\\Bank\\2021 Statements";
            Console.WriteLine("Importing January");
            bi.ImportFiles(Months.January, readDir);
            Console.WriteLine("Importing February");
            bi.ImportFiles(Months.February, readDir);
            Console.WriteLine("Importing March");
            bi.ImportFiles(Months.March, readDir);
            Console.WriteLine("Finshed importing");
            bi.WriteToCsv($"{DateTime.Now.Year}-cumulative-{DateTime.Now.ToFileTime()}.csv");
        }
    }
}
