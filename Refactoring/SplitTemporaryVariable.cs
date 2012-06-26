using System;

namespace Refactoring
{
    public class SplitTemporaryVariable
    {
        public void Method(decimal height, decimal width)
        {
            var temp = 2*(height + width);
            Console.WriteLine(temp);
            temp = height*width;
            Console.WriteLine(temp);
        }
    }
}