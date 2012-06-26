namespace MovingFeaturesBetweenObjects
{
    public class MoveField
    {
        public class Account
        {
            private AccountType accountType;
            private decimal interestField;

            public decimal InterestForAmountDays(decimal amount, int days)
            {
                return interestField * amount * days / 365;
            }

            public decimal OverDraftCharge()
            {
                if (accountType.IsPremium())
                {
                    var result = 10M;
                    return result;
                }

                return 0;
            }
        }

        public class AccountType
        {
            public bool IsPremium()
            {
                return true;
            }
        }
    }
}