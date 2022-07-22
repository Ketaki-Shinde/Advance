using System;
// calculate factors of given number and count it

namespace ConsoleApp1
{
    class Factors
    {
        public static void Main()
        {
            Console.WriteLine("Enter number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for(int i=1; i<=num; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Factors "+i);
                    count++;
                }
            }
            Console.WriteLine("Count " + count);

            
        }

    }
}
