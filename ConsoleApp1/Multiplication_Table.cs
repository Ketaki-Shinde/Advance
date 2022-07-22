using System;
//5's table   5*1=5

namespace ConsoleApp1
{
    class Multiplication_Table
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for multiplication table : ");
            int num1 = Convert.ToInt32(Console.ReadLine());//5

            int result;
            for(int i=1; i<=10; i++)
            {
                result = num1 * i;
                Console.WriteLine($"{num1}*{i}={result}");
                //Console.WriteLine("{0}*{1}={2}",num1,i,result);
            }
        }
    }
}
