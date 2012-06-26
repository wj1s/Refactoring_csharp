namespace OrganizingData
{
    public class SelfEncapsulateField
    {
        public class IntRange
        {
            private readonly int low;
            private int high;

            public IntRange(int low, int high)
            {
                this.low = low;
                this.high = high;
            }

            public bool Includes(int arg)
            {
                return arg >= low && arg <= high;
            }

            public void Grow(int factor)
            {
                high = high*factor;
            }
        }
    }
}
