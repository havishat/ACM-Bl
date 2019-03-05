using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
