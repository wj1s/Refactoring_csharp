namespace Refactoring
{
    public class SubstitueAlgorithm
    {
        public string FoundPerson(string[] people)
        {
            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                     return "Don";

                if (people[i].Equals("John"))
                    return "John";

                if (people[i].Equals("Kent"))
                    return "Kent";
            }

            return "";
        }
    }
}