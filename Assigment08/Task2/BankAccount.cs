using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task2
{
    public partial class BankAccount
    {
        private readonly string _accountNumber;
        private readonly string _accountHolderName;
        private Currency _balance { get; set; }
        public BankAccount(string accountNumber, string accountHolderName, Currency balance)
        {
            _accountHolderName = accountHolderName;
            _accountNumber = accountNumber;
            _balance = balance;
        }

        public void Deposit(Currency amount)
        {
            _balance = new Currency(_balance._amount + amount._amount, amount._cur);
        }

        public void Withdraw(Currency amount)
        {
            _balance = new Currency(_balance._amount - amount._amount, amount._cur);
        }

        public void BalanceCheck()
        {
           Console.WriteLine (($"{ _balance.Amount}{ _balance.Curr}"));
        }
    } 
    public struct Currency
    {
        public decimal _amount;
        public string _cur;
        public decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        public string Curr
        {
            get
            {
                return _cur;
            }
            set
            {
                _cur = value;
            }
        }
        public Currency(decimal amount, string cur)
        {
            _amount = amount;
            _cur = cur;
        }
    }
}
        
    
