namespace OrganizingData
{
    public class ReplaceArrayWithObject
    {
        public class ArrayClass
        {
            readonly string[] row = new string[3];
            public void InitRows()
            {
                row[0] = "Liverpool";
                row[1] = "15";
                var name = row[0];
                var wins = int.Parse(row[1]);
            }
        }
    }
}