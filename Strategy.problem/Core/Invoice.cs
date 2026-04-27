using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Strategy.problem.Entities
{
    public class Invoice
    {
        public Customer? Customer { get; set; }

        public List<InvoiceLine> Lines { get; set; } = new List<InvoiceLine>();

        public double DiscountPersentage { get; set; }

        public double TotalPrice => Lines.Sum(l => l.Quantity * l.UnitPrice);
    }
}
