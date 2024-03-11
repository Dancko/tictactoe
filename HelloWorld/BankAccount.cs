using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class BankAccount
    {
        private float _balance;
        private string _name;

        public BankAccount(string name, float balance = 0)
        {   
            _name = name;
            _balance = balance;
        }

        public void Deposit(float sum)
        {
            _balance += sum;
        }

        public void Withdrawal(float sum)
        {
            _balance -= sum;
        }

        public string CurrentBalance { 
            get {
                return $"Current balance is: {_balance}";
                } 
        }
    }
}
