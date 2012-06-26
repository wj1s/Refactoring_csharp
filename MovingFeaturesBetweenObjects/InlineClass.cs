namespace MovingFeaturesBetweenObjects
{
    public class InlineClass
    {
        public class Person
        {
            public string name { get; set; }
        }

        public class TelephoneNumber
        {
            public static string office_area_code { get; set; }
            public static string office_number { get; set; }

            public string GetTelephoneNumber()
            {
                return ("(" + office_area_code + ") ") + office_number;
            }
        }
    }
}