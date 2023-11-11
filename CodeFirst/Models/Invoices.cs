using Microsoft.VisualBasic;

namespace CodeFirst.Models
{
    public class Invoices
    {
        public int InvoicesId { get; set; }
        public DateAndTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }


        public int CustomersId { get; set; }
        public Customers Customers { get; set; }
    }
}
