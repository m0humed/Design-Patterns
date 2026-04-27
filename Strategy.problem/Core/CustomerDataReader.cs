using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.problem.Entities
{
    public class CustomerDataReader
    {

        public IEnumerable<Customer> GetCustomers() 
        { 
            return new List<Customer>
            {
                new Customer { Id = 1 , Name = "Kory" },
                new Customer { Id = 2 , Name = "Ali" },
                new Customer { Id = 3 , Name = "Rabai" },
                new Customer { Id = 4 , Name = "Somaa" }
            }
            ; 
        
        }
    }
}
