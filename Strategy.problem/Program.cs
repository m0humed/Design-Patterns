using System;
using System.Linq;
using Strategy.problem.Core;
using Strategy.problem.Core.Strategies;
using Strategy.problem.Entities;

namespace Strategy.problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new CustomerDataReader().GetCustomers().ToList();
            var customer1 = customers.First(x=>x.Id==1);
            var customer2 = customers.First(x => x.Id == 2);
            var customer3 = customers.First(x => x.Id == 3);

            // Total = 2 * 600 = 1200 (so Silver/Gold discounts kick in)
            const double quantity = 2;
            const double unitPrice = 600;

            PrintInvoiceFor(customer1,  quantity, unitPrice);
            PrintInvoiceFor(customer2,  quantity, unitPrice);
            PrintInvoiceFor(customer3, quantity, unitPrice);
        }

        private static void PrintInvoiceFor(
            Customer customer,
            double quantity,
            double unitPrice)
        {

            var invoiceManager = new InvoiceManager ();
            if(customer.CustomerType == CustomerType.Gold)
            {
                invoiceManager.customerDescountStratigy = new GoldCustomerDescountStratigy();
            }else if (customer.CustomerType == CustomerType.Selver)
            {
                invoiceManager.customerDescountStratigy = new SelverCustomerDescountStratigy();
            }else
            {
               invoiceManager.customerDescountStratigy = new NewCustomerDescountStratigy();
            }
            var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);

            var discountAmount = invoice.TotalPrice * invoice.DiscountPersentage;
            var net = invoice.TotalPrice - discountAmount;

            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Strategy: {customer.CustomerType.GetType().Name}");
            Console.WriteLine($"Total:    {invoice.TotalPrice:0.00}");
            Console.WriteLine($"Discount: {invoice.DiscountPersentage:P0} ({discountAmount:0.00})");
            Console.WriteLine($"Net:      {net:0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
