using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_1
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity * (decimal)(1 + Tax);
        }
        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tMeasurement: {Measurement}" +
                $"\n\tQuantity...: {$"{Quantity:F2}",15}" +
                $"\n\tPrice......: {$"{Price}",15}" +
                $"\n\tTax........: {$"{Tax}",15}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}
