﻿

namespace logicalprograms_day6
{
    public static class fibonacciseries
    {
        public static void displayfibonacciseries()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the number of elements");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}