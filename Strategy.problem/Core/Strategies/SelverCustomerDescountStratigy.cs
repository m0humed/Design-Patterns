using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.problem.Core.Strategies
{
    internal class SelverCustomerDescountStratigy : ICustomerDescountStratigy
    {
        public double CalculateDiscount(double TotalPrice)
        {
            if (TotalPrice > 1000)
            {
                return .05;
            }

            return 0;
        }
    }
}
