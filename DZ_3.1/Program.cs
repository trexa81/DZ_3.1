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
            Reverse();
            Reverse(Console.ReadLine());
        }

        static void Reverse(string  strings = "Hello!")
        {
            Console.WriteLine(strings);
            //strings  = "Hello!";
            var x = strings.ToCharArray(); //стринг в чар
            var n = x.Length;        // длина массива
            var k = n / 2;          // середина массива
            char temp;               // вспомогательный элемент для обмена значениями
            for (var i = 0; i < k; i++)
            {
                temp = x[i];
                x[i] = x[n - i - 1];
                x[n - i - 1] = temp;
            }
            
            foreach (var i in x)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
            string txt = new(x);
            Console.WriteLine(txt);

        }
    }
}
