using Strategy.problem.Core;
using Strategy.problem.Core.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.problem.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public CustomerType CustomerType { get; set; } 
    }
}
