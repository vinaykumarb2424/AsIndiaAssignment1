using System;

namespace Missing_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, totalcountsum, actualsum = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n - 1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int j in a)
            {
                actualsum = actualsum + j;
            }
            totalcountsum = (n * (n + 1)) / 2;
            Console.WriteLine("Missing Number is");
            Console.WriteLine(totalcountsum - actualsum);
            Console.ReadLine();
        }
    }
}
