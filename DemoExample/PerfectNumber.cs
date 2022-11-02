using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExample
{
    internal class PerfectNumber
    {
        public void Check(int num)//28
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
                Console.WriteLine("Number Provided is a Perfect Number");
            else
                Console.WriteLine("Number is a Perfect Number");
        }
    }
}
