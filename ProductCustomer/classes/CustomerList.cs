using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductCustomer.classes
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count
        {
            get
            {
                return customers.Count;
            }
        }
        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }
        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }
        public Customer this[int index]
        {
            get
            {
                return customers[index];
            }

        }
        public Customer this[string email]
        {
            get
            {
                foreach (Customer customer in customers)
                {
                    if (customer.Email == email)
                    {
                        return customer;
                    }
                }
                return null;
            }
        }
        public void ChangeCustomer()
        {

        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void Add(string customerFirstName, string customerLastName, string customerPhone, string customerEmail, int customerId)
        {
            Customer c = new Customer(customerFirstName, customerLastName, customerPhone, customerEmail, customerId);
            customers.Add(c);
        }
        public static CustomerList operator +(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }
        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }
        public static CustomerList operator -(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }
        public override string ToString()
        {
            string output = "";
            foreach (Customer c in customers)
            {
                output += c.ToString() + "\n";
            }
            return output;
        }
        /*
        change the customer object in a specific position in the list*/
    }
}
