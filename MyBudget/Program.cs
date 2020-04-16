using System;

namespace MyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            var bi = new BudgetImporter();
            bi.ImportFiles();
        }
    }
}
