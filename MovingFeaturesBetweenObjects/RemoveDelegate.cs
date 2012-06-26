namespace MovingFeaturesBetweenObjects
{
    public class RemoveDelegate
    {
        public class Person
        {
            public Department department { get; set; }

            public Person GetManager()
            {
                return department.GetManager();
            }
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