namespace CodeFirst.Models
{
    public class Details
    {

        public int DetaailId { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
        public float Subtotal { get; set; }



        public int ProductsId { get; set; }
        public int InvoicesId { get; set; }

        public Products Products { get; set; }
        public Invoices Invoices { get; set; }

    }

}
