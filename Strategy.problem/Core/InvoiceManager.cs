using Strategy.problem.Core.Strategies;
using Strategy.problem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.problem.Core
{
    public class InvoiceManager
    {
        public ICustomerDescountStratigy customerDescountStratigy { get; set; }

        public Invoice CreateInvoice(Customer customer , double quantity , double unitPrice)
        {
            if (customerDescountStratigy is null)
            {
                throw new InvalidOperationException("Customer discount strategy is not set.");
            }

            var invoice = new Invoice
            {
                Customer = customer ,
                Lines = new List<InvoiceLine>
                {
                    new InvoiceLine
                    {
                        Quantity = quantity ,
                        UnitPrice = unitPrice
                    }
                }
            };
            invoice.DiscountPersentage = customerDescountStratigy.CalculateDiscount(invoice.TotalPrice);
            return invoice ;

        }
    }
}
