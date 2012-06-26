namespace OrganizingData
{
    public class ReplaceTypeCodeWithClass
    {
        public class Person
        {
            public static int O = 0;
            public static int A = 1;
            public static int B = 2;
            public static int AB = 3;

            public Person(int bloodGroup)
            {
                BloodGroup = bloodGroup;
            }

            public int BloodGroup { get; private set; }
        }

        public class Client
        {
            public void UpdateBloodGroup()
            {
                var person = new Person(Person.AB);
                var bloodGroup = person.BloodGroup;
            }
        }
    }
}