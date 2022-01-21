using System;

namespace DZ_3._1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // DZ2.1
            // BankAccount AccountNumber, Balance, BankAccountType
            var bankAccountCredit = new BankAccount(1234, 34, BankAccountType.Credit);
            var accountNumber = bankAccountCredit.AccountNumber;
            Random rng = new();
            bankAccountCredit.Balance += rng.NextDouble() * 100;
            var balanceCredit = bankAccountCredit.Balance;
            Console.WriteLine(accountNumber);
            Console.WriteLine(balanceCredit);
            Console.WriteLine(BankAccountType.Credit);
            var bankAccountDebit = new BankAccount(1234, 34, BankAccountType.Debit);
            var accountNumberDebit = bankAccountDebit.AccountNumber;
            var balanceDebit = bankAccountCredit.Balance + bankAccountCredit.Balance;
            bankAccountCredit.Balance -= bankAccountCredit.Balance;
            Console.WriteLine(accountNumber);
            Console.WriteLine(balanceCredit);
            Console.WriteLine(balanceDebit);
            Console.WriteLine(accountNumberDebit);
        }
    }
}
