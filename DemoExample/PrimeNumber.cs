using System;

namespace DemoExample
{
    public class PrimeNumber
    {
        public void CheckPrime (int num )//28
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;

                }
            }
            if (count == 2)
                Console.WriteLine("Number Provided is a Prime Number");
            else
                Console.WriteLine("Number is not a Prime Number");


            
        }
    }
}
