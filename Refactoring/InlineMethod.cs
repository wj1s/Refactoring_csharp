namespace Refactoring
{
    public class InlineMethod
    {
        private decimal numberOfLateDeliveries;

        public int GetRating()
        {
            return (MoreThanFiveLateDeliveries()) ? 2 : 1;
        }

        private bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }
}