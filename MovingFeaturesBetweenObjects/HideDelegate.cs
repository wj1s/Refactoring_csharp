namespace MovingFeaturesBetweenObjects
{
    public class HideDelegate
    {
        public class Person
        {
            public Department department { get; set; }
        }

        public class Department
        {
            private readonly Person manager;

            public Department(Person manager)
            {
                this.manager = manager;
            }

            public Person GetManager()
            {
                return manager;
            }
        }
    }
}