using FileHelpers;
using System;

namespace MyBudget.ImportTypes
{
    [DelimitedRecord(",")]
    public class WellsFargoCheckRecord : IBankExport
    {
        public const string RecordType = "Wells Fargo Checking";

        // BankExport fields
        public DateTime Date { get => TransactionDate; }
        public string Details { get => Description; }
        public decimal Debit { get => TransactionAmount > 0 ? 0 : -TransactionAmount; }
        public decimal Credit { get => TransactionAmount < 0 ? 0 : TransactionAmount; }
        public string Institution => RecordType; 
        public string ToCsvString()
        {
            return this.ToString();
        }

        [FieldConverter(ConverterKind.Date, "MM/dd/yyyy")]
        [FieldQuoted('"')]
        public DateTime TransactionDate { get; set; }

        [FieldQuoted('"')]
        public decimal TransactionAmount { get; set; }

        [FieldQuoted('"')]
        public string Star { get; set; } // (no idea what this is used for)

        [FieldQuoted('"')]
        public int? CheckNumber { get; set; }

        [FieldQuoted('"')]
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is WellsFargoCheckRecord other))
                return false;
            else
                return Equals(other);
        }

        public bool Equals(WellsFargoCheckRecord other)
        {
            return other.TransactionDate == TransactionDate &&
                other.TransactionAmount == TransactionAmount &&
                other.Star == Star &&
                other.CheckNumber == CheckNumber &&
                other.Description == Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TransactionDate, TransactionAmount, CheckNumber, Description);
        }

        public override string ToString()
        {
            return $"{Date:MM/dd/yyyy},\"{Details}\",{Debit},{Credit},{RecordType}";
        }
    }
}
