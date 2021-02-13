using System;

namespace MyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            var bi = new BudgetImporter();
            var readDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive\\Budget\\Bank\\2021 Statements";
            bi.ImportFiles(Months.February, readDir);
        }
    }
}
