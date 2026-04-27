using Strategy.problem.Core;


namespace Strategy.problem.Entities
{
    public class CustomerDataReader
    {

        public IEnumerable<Customer> GetCustomers() 
        { 
            return new List<Customer>
            {
                new Customer { Id = 1 , Name = "Kory" , CustomerType =  CustomerType.Gold},
                new Customer { Id = 2 , Name = "Ali" , CustomerType =  CustomerType.Selver},
                new Customer { Id = 3 , Name = "Rabai" , CustomerType =  CustomerType.New },
                new Customer { Id = 4 , Name = "Somaa" , CustomerType =  CustomerType.Selver }
            }
            ; 
        
        }
    }
}
