using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2._0
{
    internal class Customer
    {
        private string customerNumber;
        private string name;

        public Customer(string customerNumber, string name)
        {
            this.customerNumber = customerNumber;
            this.name = name;
        }

        public string getCustomerNumber()
        {
            return customerNumber;
        }

        public string getCustomerName()
        {
            return name;
        }
    }
}
