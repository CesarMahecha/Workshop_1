using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_1
{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public string Products { get; set; }

        public override decimal ValueToPay()
        {
            return Price * (decimal)Discount * (decimal)(1 + Tax);
        }
        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tProducts...: {Products}" +
                $"\n\tDiscount...: {$"{Discount:P2}",15}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}
