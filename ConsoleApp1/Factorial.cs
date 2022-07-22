using System;
// factorial pgm 5!=5*4*3*2*1

namespace ConsoleApp1
{
    class Factorial
    {
        public static void Main()
        {
            Console.WriteLine("enter number fir factorial");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for(int i=1; i<=num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
