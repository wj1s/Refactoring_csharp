using System;
using Xunit;
namespace Refactoring
{
    public class ExtractMethods
    {
        private const string Name = "foo";

        public double PrintOwning(double previousAmount)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*********Customer Owns***************");
            Console.WriteLine("*************************************");

            previousAmount = previousAmount * 1.2;
            string displayName = Name + "_display";

            var tmp = 5;
            for (var i = 0; i < 3; i++)
            {
                previousAmount += tmp;
            }

            tmp = 10;
            for (int i = 0; i < tmp; i++)
            {
                Console.WriteLine("name:" + displayName);
            }

            Console.WriteLine("Done!");
            Console.WriteLine("name:" + displayName);
            Console.WriteLine("amount" + previousAmount);
            return previousAmount;
        }
    }

    public class ExtractMethodsTest
    {
        [Fact]
        public void should_print_right()
        {
            var extractMethods = new ExtractMethods();
            Assert.Equal(extractMethods.PrintOwning(1.0), 16.2);
        }
    }
}
