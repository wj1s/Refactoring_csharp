namespace OrganizingData
{
    public class ReplaceSubclassWithFields
    {
        abstract class Person
        {
            protected abstract bool IsMale();
            protected abstract string getCode();
        }

        class Male : Person
        {
            protected override bool IsMale()
            {
                return true;
            }

            protected override string getCode()
            {
                return "M";
            }
        }

        class FeMale : Person
        {
            protected override bool IsMale()
            {
                return false;
            }

            protected override string getCode()
            {
                return "F";
            }
        }

        public class Client
        {
            public void GetPerson()
            {
                var male = new Male();
                var feMale = new FeMale();
            }
        }
    }
}