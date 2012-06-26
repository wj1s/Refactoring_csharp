using System.Collections.Generic;
using System.Linq;

namespace OrganizingData
{
    public class EncapsulateCollection
    {
        public class Course
        {
            private readonly string courseName;
            private readonly bool isAdvantaged;

            public Course(string courseName, bool isAdvantaged)
            {
                this.courseName = courseName;
                this.isAdvantaged = isAdvantaged;
            }

            public bool IsAdvantaged
            {
                get { return isAdvantaged; }
            }
        }

        public class Person
        {
            public List<Course> Courses { get; set; }
        }

        public class Clinet
        {
            public void AddCourses()
            {
                var kent = new Person();
                var courses = new List<Course>();
                courses.Add(new Course("SmalTalk Programming", false));
                courses.Add(new Course("Appreciating Single Malts", true));
                kent.Courses = courses;

                var advantedCousesNum = kent.Courses.Where(c => c.IsAdvantaged).Count();
            }
        }
    }
}