using System;

namespace ProductCustomer.classes
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private int id;

        public Customer() { }

        public Customer(string customerFirstName, string customerLastName, string customerPhone, string customerEmail, int customerId)
        {
            this.firstName = customerFirstName;
            this.lastName = customerLastName;
            this.phone = customerPhone;
            this.email = customerEmail;
            this.id = customerId;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public override string ToString()
        {
            return String.Format("First Name: {0} Last Name: {1} Phone Number: {2} Email: {3} ID: {4}", firstName, lastName, phone, email, id);
        }
    }
}
