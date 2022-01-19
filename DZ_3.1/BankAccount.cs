using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3._1
{
    public class BankAccount
    {
        private long _AccountNumber;
        private double _Balance;
        public BankAccountType _BankAccountType;

        public BankAccount(long AccountNumber, double Balance, BankAccountType BankAccountType)
        {
            _AccountNumber = AccountNumber;
            _Balance = Balance;
            _BankAccountType = BankAccountType;
        }
       
        public double Balance
        {
            get
            {
                Random rng = new Random();
                //return _Balance;
                return rng.Next(1, 1000);
            }
            set
            {
                _Balance = value;
            }
        }

       
    }
    public enum BankAccountType
    {
        Credit,
        Debit
    }

}
