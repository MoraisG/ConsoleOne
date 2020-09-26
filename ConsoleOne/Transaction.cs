using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOne
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal Amount, DateTime date, string Note)
        {
            this.Amount = Amount;
            this.Date = date;
            this.Notes = Note;
        }
    }
}
