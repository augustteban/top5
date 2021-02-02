using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCustomer
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Boolean isEmailConfirmed { get; set; }
        public double LoyaltyPoints { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
