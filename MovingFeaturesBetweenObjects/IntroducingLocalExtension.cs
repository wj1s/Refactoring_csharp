using System;

namespace MovingFeaturesBetweenObjects
{
    public static class IntroducingLocalExtension
    {
        public static DateTime NextDay(this DateTime dateTime, DateTime arg)
        {
            return new DateTime(arg.Year, arg.Month, arg.Day + 1);
        }
    }
}