using System;

namespace MyBudget.ImportTypes
{
    public interface IBankExport
    {
        public DateTime Date { get; }
        public string Details { get; }
        public decimal Debit { get; }
        public decimal Credit { get; }
        public string Institution { get; }
        public string ToCsvString();
    }
}
