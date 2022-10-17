

namespace logicalprograms_day6
{
    public static class perfectnumber
    {
        public static void checkperfectnumber()
        {
            int n, i, sum;
            int mn, mx;
            {
                Console.WriteLine("find the perfect number within the given number of range");
                Console.WriteLine("input the starting range of number");
                mn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the starting range of number");
                mx = Convert.ToInt32(Console.ReadLine());

                for (n = mn; n <= mx; n++)
                {
                    i = 1;
                    sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == 0)
                        Console.WriteLine(n);
                }
            }
        }
    }
}
