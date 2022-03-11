using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2._0
{
    internal class Account
    {
        private Customer customer;
        private string accountNumber;
        private float balance;

        public Account(Customer customer, string accountNumber, float balance)
        {
            this.customer = customer;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public float Withdraw(float amount)
        {
            if (balance < amount)
            {
                return 0;
            }
            balance -= amount;
            return amount;
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public string ToString()
        {
            return accountNumber + " - " + balance.ToString();
        }
    }
}
