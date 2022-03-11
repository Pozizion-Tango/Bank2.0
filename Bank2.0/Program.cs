using System;

namespace Bank2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bank bank = new Bank();
                int menuSelection = GetMainSelection();
                if (menuSelection == 1)
                {
                    CreateNewCustomer(bank);
                }
                else if (menuSelection == 2)
                {
                    SelectExcistingCustomer(bank);
                } 
            }
        }

        private static void SelectExcistingCustomer(Bank bank)
        {
            Console.WriteLine("Enter Customer Number:");
            string customerNumber = Console.ReadLine();
            Customer customer = bank.FindCustomer(customerNumber);
            if (customer == null)
            {
                Console.WriteLine("Customer Number Invalid");
                return;
            }
            Console.WriteLine(customer.getCustomerName+" Has The Following Account.");
            foreach (Account account in bank.FindAccounts(customer))
            {
                Console.WriteLine(account.ToString());
            }
        }

        private static void CreateNewCustomer(Bank bank)
        {
            Console.WriteLine("Please Enter Your Name:");
            string username = Console.ReadLine();
            bank.CreateCustomer(username);
            Console.Write("Account Succefully Created!");
        }

        private static int GetMainSelection()
        {
            Console.WriteLine("Selection Option");
            Console.WriteLine("1: Create New Customer");
            Console.WriteLine("2: Select Excisting Customer");
            string inPut = Console.ReadLine();
            int result = int.Parse(inPut);
            return result;
        }
    }
}