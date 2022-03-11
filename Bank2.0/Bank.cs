using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2._0
{
    internal class Bank
    {
        private List<Account> accounts;
        private List<Customer> customers;
        private int currentAccountNumber;
        private int currentCustomerNumber;

        public Bank()
        {
            accounts = new List<Account>();
            customers = new List<Customer>();
            currentAccountNumber = 101;
            currentCustomerNumber = 101;
        }

        public void CreateAccount(Customer customer)
        {
            Account account = new Account(customer, currentAccountNumber.ToString(), 0);
            accounts.Add(account);
            ++currentAccountNumber;
        }

        public void CreateCustomer(string name)
        {
            Customer customer = new Customer(currentCustomerNumber.ToString(), name);
            customers.Add(customer);
            currentCustomerNumber++;
        }
        
        public Customer FindCustomer(string customerNumber)
        {
            foreach(Customer customer in customers)
            {
                if (customer.getCustomerNumber() == customerNumber)
                {
                    return customer;
                }    
            }
            return null;
        }

        public List<Account> FindAccounts(Customer customer)
        {
            List<Account> userAccounts = new List<Account>();
            foreach (Account account in accounts)
            {
                if (account.GetCustomer().getCustomerNumber() == customer.getCustomerNumber())
                {
                    userAccounts.Add(account);
                }
            }
            return userAccounts;
        }
    }
}
