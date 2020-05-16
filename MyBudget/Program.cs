using System;

namespace MyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            var bi = new BudgetImporter();
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Documents\\Bank\\2020 Statements";
            bi.ImportFiles(Months.May, readDir);
        }
    }
}
