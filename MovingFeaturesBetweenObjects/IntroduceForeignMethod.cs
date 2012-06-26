using System;

namespace MovingFeaturesBetweenObjects
{
    public class IntroduceForeignMethod
    {
        public class ServerClass
        {
            private DateTime previousDate;

            public ServerClass(DateTime previousDate)
            {
                this.previousDate = previousDate;
            }

            public DateTime GetDate()
            {
                return new DateTime(previousDate.Year, previousDate.Month, previousDate.Day + 1);
            }
        }
    }
}