using FileHelpers;
using System;

namespace MyBudget.ImportTypes
{
    [DelimitedRecord(",")]
    [IgnoreFirst(4)]
    public class BhfcuCheckRecord : IBankExport
    {
        public const string RecordType = "BHFCU Checking";

        // IBankExport fields
        public DateTime Date => TransactionDate;
        public string Details => String.IsNullOrWhiteSpace(Memo) ? Description : Memo; // we want Memo, but it's Memo empty
        public decimal Debit => -AmountDebit ?? 0;
        public decimal Credit => AmountCredit ?? 0;
        public string Institution => RecordType;
        public string ToCsvString()
        {
            return this.ToString();
        }

        [FieldQuoted('"')]
        public string TransactionNumber { get; set; }

        [FieldConverter(ConverterKind.Date, "MM/dd/yyyy")]
        public DateTime TransactionDate { get; set; }

        [FieldQuoted('"')]
        public string Description { get; set; }

        [FieldQuoted('"')]
        public string Memo { get; set; }

        public decimal? AmountDebit { get; set; }

        public decimal? AmountCredit { get; set; }

        [FieldQuoted('"')]
        public decimal Balance { get; set; }

        public int? CheckNumber { get; set; }

        public decimal? Fees { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is BhfcuCheckRecord other))
                return false;
            else
                return Equals(other);
        }

        public bool Equals(BhfcuCheckRecord other)
        {
            return other.TransactionNumber == TransactionNumber &&
                other.TransactionDate == TransactionDate &&
                other.Description == Description &&
                other.Memo == Memo &&
                other.AmountDebit == AmountDebit &&
                other.AmountCredit == AmountCredit &&
                other.Balance == Balance &&
                other.CheckNumber == CheckNumber &&
                other.Fees == Fees;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TransactionDate, Description, Memo, AmountDebit, AmountCredit, Balance, CheckNumber, Fees);
        }

        public override string ToString()
        {
            return $"{Date:MM/dd/yyyy},\"{Details}\",{Debit},{Credit},{RecordType}";
        }
    }
}
