using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using static System.Math;

namespace ConsoleOne
{
    class Program
    {
        //Versão 1.0

        static void Main(string[] args)
        {
            var conta = new BankAccount("Gabriel", 1000);
            conta.Depositar(100, DateTime.Now, "Alcione depositou");
            Console.WriteLine($"Saldo atual {conta.Balance}");
            conta.Sacar(58, DateTime.Now.AddDays(1) , "COSERN" );
            Console.WriteLine($"Saldo disponível {conta.Balance}");


         //  try
         //  {
         //       var contaInvalida = new BankAccount("Alcione", -50);
         //  }
         //   catch (ArgumentOutOfRangeException e)
         //   {
         //       Console.WriteLine("Não foi possível criar a conta");
         //       Console.WriteLine(e.ToString());
               // throw;
         //   }

            Console.WriteLine(conta.GetAccountHistory()); 

        }
}
}
