namespace Refactoring
{
    public class InlineTemp
    {
        public bool InlineTempMethod()
        {
            var basePrice = anOrder.BasePrice();
            return basePrice > 1000;
        }
    }

    public static class anOrder
    {
        public static decimal BasePrice()
        {
            return 0;
        }
    }
}