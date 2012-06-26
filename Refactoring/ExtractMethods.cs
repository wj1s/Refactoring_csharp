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
            var displayName = Name + "_display";
            var tmp = 10;
            // 1.print banner
            Console.WriteLine("*************************************");
            Console.WriteLine("*********Customer Owns***************");
            Console.WriteLine("*************************************");

            // 3.calculate outstanding
            for (var i = 0; i < 3; i++)
            {
                tmp += i;
                previousAmount += tmp;
                Console.WriteLine("name:" + displayName);
                Console.WriteLine("i:" + i);
                Console.WriteLine("plus:" + tmp);
                Console.WriteLine("amount:" + previousAmount);
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
        public void should_parse_to_all_when_status_text_is_null()
        {
            var extractMethods = new ExtractMethods();
            Assert.Equal(extractMethods.PrintOwning(1.0), 35.2);
        }
    }
}
