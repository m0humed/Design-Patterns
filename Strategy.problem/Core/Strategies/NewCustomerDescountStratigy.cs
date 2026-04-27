using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.problem.Core.Strategies
{
    public class NewCustomerDescountStratigy : ICustomerDescountStratigy
    {
        public double CalculateDiscount(double TotalPrice)
        {
            return 0;
        }
    }
}
