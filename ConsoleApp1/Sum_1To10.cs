using System;
//print sum of first 10 numbers

namespace ConsoleApp1
{
    class Sum_1To10
    {
        public static void Main(String[] args)
        {
            int sum = 0;
            for(int i=1; i<=10;i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
    }
}
