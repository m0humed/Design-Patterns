using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.problem.Core.Strategies
{
    internal class GoldCustomerDescountStratigy : ICustomerDescountStratigy
    {
        public double CalculateDiscount(double TotalPrice)
        {
            if (TotalPrice > 1000)
            {
                return .10;
            }
            
           return 0;
            
        }
    }
}
