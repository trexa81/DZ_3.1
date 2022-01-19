using System;

namespace DZ_3._1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // DZ2.1
            // BankAccount AccountNumber, Balance, BankAccountType
            var bankAccount = new BankAccount(1234, 34, BankAccountType.Credit);
            var balance = bankAccount.Balance;
            Random rng = new();
            bankAccount.Balance += rng.Next(1, 1000);
            Console.WriteLine(balance);
            Console.WriteLine(bankAccount.Balance);
            Console.WriteLine(BankAccountType.Credit);
        }
    }
}
