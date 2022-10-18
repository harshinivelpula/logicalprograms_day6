using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograms_day6
{
    public static class reversenumber
    {
        public static void display()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n != 0)
                {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;

            }
            Console.WriteLine("reversed number is " + reverse);
        }
    }
}
