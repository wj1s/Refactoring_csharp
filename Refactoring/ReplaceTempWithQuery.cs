namespace Refactoring
{
    public class ReplaceTempWithQuery
    {
        public decimal GetPrice()
        {
            var basePrice = quantity*itemPrice;
            decimal discountFactor;
            if (basePrice > 1000)
                discountFactor = 0.95M;
            else
                discountFactor = 0.98M;

            return basePrice*discountFactor;
        }

        protected decimal itemPrice { get; set; }
        protected int quantity { get; set; }
    }
}