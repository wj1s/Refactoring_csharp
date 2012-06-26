namespace MovingFeaturesBetweenObjects
{
    public class ExtractClass
    {
        public class Person
        {
            public string name { get; set; }
            public string office_area_code { get; set; }
            public string office_number { get; set; }

            public string GetTelephoneNumber()
            {
                return ("(" + office_area_code + ") ") + office_number;
            }
        }

        public class TelephoneNumber
        {
        }
    }
}