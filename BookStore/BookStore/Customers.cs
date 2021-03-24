using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public Customers(string FirstName, string LastName, string City, string Address, string State, string Zip, string Phone, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
            this.Address = Address;
            this.State = State;
            this.Zip = Zip;
            this.Phone = Phone;
            this.Email = Email;
        }
        public Customers()
        {
            this.FirstName = null;
            this.LastName = null;
            this.City = null;
            this.Address = null;
            this.State = null;
            this.Zip = null;
            this.Phone = null;
            this.Email = null;

        }
    }
}
