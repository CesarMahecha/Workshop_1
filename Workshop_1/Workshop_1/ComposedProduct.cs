using System.Numerics;

namespace Workshop_1
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public override decimal ValueToPay()
        {
            decimal totalValueToPay = 0;
            foreach (Product product in Products)
            {
                totalValueToPay += product.ValueToPay();
            }
            return totalValueToPay * (1-(decimal)Discount);
        }
        public override string ToString()
        {
            return $"{Id} {Description}" +
                   $"\n\tProducts...: {string.Join(", ", Products.Select(p => p.Description)),15}" +
                   $"\n\tDiscount...: {$"{Discount:P2}",15}" +
                   $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}
