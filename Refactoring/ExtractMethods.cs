using System;
using Xunit;
namespace Refactoring
{
    public class ExtractMethods
    {
        private const string Name = "foo";

        public double PrintOwning(double previousAmount)
        {
            previousAmount = previousAmount * 1.2;
            const string displayName = Name + "_display";
            var tmp = 10;
            for (int i = 0; i < tmp; i++)
            {
                Console.WriteLine("name:" + displayName);
            }
            tmp = 5;
            // 1.print banner
            Console.WriteLine("*************************************");
            Console.WriteLine("*********Customer Owns***************");
            Console.WriteLine("*************************************");

            // 3.calculate outstanding
            for (var i = 0; i < 3; i++)
            {
                previousAmount += tmp;
            }

            //2.print details
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
            Assert.Equal(extractMethods.PrintOwning(1.0), 61.2);
        }
    }
}
