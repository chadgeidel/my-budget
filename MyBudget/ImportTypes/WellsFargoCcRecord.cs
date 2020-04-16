using FileHelpers;
using System;

namespace MyBudget.ImportTypes
{
    [DelimitedRecord(",")]
    public class WellsFargoCcRecord : IBankExport
    {
        public const string RecordType = "Wells Fargo CC";

        // IBankExport fields
        public DateTime Date => TransactionDate;
        public string Details => Description;
        public decimal Debit { get => TransactionAmount > 0 ? 0 : -TransactionAmount; }
        public decimal Credit { get => TransactionAmount < 0 ? 0 : TransactionAmount; }
        public string Institution => RecordType;

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
            if (!(obj is WellsFargoCcRecord other))
                return false;
            else
                return Equals(other);
        }

        public bool Equals(WellsFargoCcRecord other)
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
