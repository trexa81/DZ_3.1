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
        private BankAccountType _BankAccountType;

        public enum BankAccountType
        {
            Credit,
            Debit
        }
        public double Balance
        {
            get
            {
                return Random.Double.Next
            }
        }

        public BankAccount(long AccountNumber, double Balance, string BankAccountType)
        {
            _AccountNumber = AccountNumber;
            _Balance = Balance;
            _BankAccountType = BankAccountType;
        }
    }

    
}
