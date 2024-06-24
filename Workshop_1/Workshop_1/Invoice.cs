using System.Text;

namespace Workshop_1
{
    public class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal ValueToPay()
        {
            decimal total = 0;
            foreach (Product product in _products)
            {
                total += product.ValueToPay();
            }
            return total;
        }

        public override string ToString()
        {
            decimal invoiceTotal = ValueToPay();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"RECEIPT:");
            sb.AppendLine($"------------------------------------");
            foreach (Product product in _products)
            {
                sb.AppendLine(product.ToString());
            }
            sb.AppendLine($"                    ================");
            sb.AppendLine($"TOTAL:                  {invoiceTotal:C2}");
            return sb.ToString();
        }
    }
}
