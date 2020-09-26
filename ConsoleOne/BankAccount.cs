using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ConsoleOne
{
    class BankAccount
    {
        private static int NumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        public BankAccount(string Name, decimal SaldoInicial)
        {
            this.Owner = Name;
            this.Number = NumberSeed.ToString();
            NumberSeed++;
            this.Depositar(SaldoInicial, DateTime.Now, "Saldo inicial");
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void Depositar(decimal Montante, DateTime dataDeposito, string Obs)
        {
            if (Montante <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(Montante), "Valor para depósito é inconsistente");
            }

            var deposito = new Transaction(Montante, dataDeposito, Obs);
            this.allTransactions.Add(deposito);
        }

        public void Sacar(decimal Montante, DateTime dataSaque, string Obs)
        {
            if (Montante <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Montante), "Valor para saque é inconsistente");
            }

            if (Balance - Montante < 0)
            {
                throw new InvalidOperationException("Saldo indisponível para o saque desejado");
            }

            var saque = new Transaction(Montante, dataSaque, Obs);
            this.allTransactions.Add(saque);
        }
    }
}
