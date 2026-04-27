using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.problem.Core.Strategies
{
    public interface ICustomerDescountStratigy
    {
        double CalculateDiscount(double TotalPrice);

    }
}
