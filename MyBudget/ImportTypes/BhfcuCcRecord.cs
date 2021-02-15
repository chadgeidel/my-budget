using FileHelpers;
using System;

namespace MyBudget.ImportTypes
{
    [DelimitedRecord(",")]
    [IgnoreFirst(4)]
    public class BhfcuCcRecord : IBankExport
    {
        public const string RecordType = "BHFCU CC";

        // BankExport fields
        public DateTime Date => TransactionDate;
        public string Details => Memo;
        public decimal Debit => -AmountDebit ?? 0;
        public decimal Credit => AmountCredit ?? 0;
        public string Institution => RecordType;
        public string ToCsvString()
        {
            return $"{Date:MM/dd/yyyy},\"{Details}\",{Debit},{Credit},{RecordType}";
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

        public decimal? Principal { get; set; }

        [FieldOptional]
        public decimal? Interest { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is BhfcuCcRecord other))
                return false;
            else
                return Equals(other);
        }

        public bool Equals(BhfcuCcRecord other)
        {
            return other.TransactionNumber == TransactionNumber &&
                other.TransactionDate == TransactionDate &&
                other.Description == Description &&
                other.Memo == Memo &&
                other.AmountDebit == AmountDebit &&
                other.AmountCredit == AmountCredit &&
                other.Balance == Balance &&
                other.CheckNumber == CheckNumber &&
                other.Fees == Fees &&
                other.Principal == Principal &&
                other.Interest == Interest;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(TransactionNumber);
            hash.Add(TransactionDate);
            hash.Add(Description);
            hash.Add(Memo);
            hash.Add(AmountDebit);
            hash.Add(AmountCredit);
            hash.Add(Balance);
            hash.Add(CheckNumber);
            hash.Add(Fees);
            hash.Add(Principal);
            hash.Add(Interest);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"{Date:MM/dd/yyyy},\"{Details}\",{Debit},{Credit},{RecordType}";
        }
    }
}
