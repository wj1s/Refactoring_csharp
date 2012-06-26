using System;

namespace MovingFeaturesBetweenObjects
{
    public class MoveClass
    {
        public class Account
        {
            private AccountType accountType;
            private int daysOverdrawn;

            public decimal OverDraftCharge()
            {
                if (accountType.IsPremium())
                {
                    var result = 10M;
                    if (daysOverdrawn > 7)
                        result += (daysOverdrawn - 7) * 0.85M;
                    return result;
                }

                return daysOverdrawn * 1.75M;
            }

            public decimal BankCharge()
            {
                var result = 4.5M;
                if (daysOverdrawn > 0)
                    result += OverDraftCharge();
                return result;
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
