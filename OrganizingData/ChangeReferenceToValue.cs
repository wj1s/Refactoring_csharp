namespace OrganizingData
{
    public class ChangeReferenceToValue
    {
        public class Currency
        {
            private readonly string code;

            private Currency(string code)
            {
                this.code = code;
            }

            public string Code
            {
                get { return code; }
            }
        }
    }
}