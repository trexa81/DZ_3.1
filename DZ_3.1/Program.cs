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
            var accountNumber = bankAccount.AccountNumber;
            Random rng = new();
            bankAccount.Balance += rng.NextDouble() * 100;
            var balance = bankAccount.Balance;
            Console.WriteLine(accountNumber);
            Console.WriteLine(balance);
            Console.WriteLine(bankAccount.Balance);
            Console.WriteLine(BankAccountType.Credit);
        }
    }
}
