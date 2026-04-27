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
            var customer = customers.First();

            // Total = 2 * 600 = 1200 (so Silver/Gold discounts kick in)
            const double quantity = 2;
            const double unitPrice = 600;

            PrintInvoiceFor(customer, new NewCustomerDescountStratigy(), quantity, unitPrice);
            PrintInvoiceFor(customer, new SelverCustomerDescountStratigy(), quantity, unitPrice);
            PrintInvoiceFor(customer, new GoldCustomerDescountStratigy(), quantity, unitPrice);
        }

        private static void PrintInvoiceFor(
            Customer customer,
            ICustomerDescountStratigy discountStrategy,
            double quantity,
            double unitPrice)
        {
            var invoiceManager = new InvoiceManager { customerDescountStratigy = discountStrategy };
            var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);

            var discountAmount = invoice.TotalPrice * invoice.DiscountPersentage;
            var net = invoice.TotalPrice - discountAmount;

            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Strategy: {discountStrategy.GetType().Name}");
            Console.WriteLine($"Total:    {invoice.TotalPrice:0.00}");
            Console.WriteLine($"Discount: {invoice.DiscountPersentage:P0} ({discountAmount:0.00})");
            Console.WriteLine($"Net:      {net:0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
