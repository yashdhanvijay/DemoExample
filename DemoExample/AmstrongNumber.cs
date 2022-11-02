using System;

namespace DemoExample
{
    internal class AmstrongNumber
    {
        public void Check (int num )//28
        {
            int sum = 0;
            for (int i = 1; i < num / 2; i++)
            {
                if (num % 2 == 0)
                {
                    sum += i;
                    
                }
            }
            if (num == sum)
                Console.WriteLine("Number provided is an Amstrong Number");
            else
                Console.WriteLine("Number is not an Amstrong Number");
        }
    }
}
