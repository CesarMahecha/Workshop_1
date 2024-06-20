namespace Workshop_1
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            return Price * (decimal)(1+Tax);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}
