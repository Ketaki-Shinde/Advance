using System;
//to print from 1 to 10

namespace ConsoleApp1
{
    class Square
    {
        public static void Main(string[] args)
        {
            int square;
            for(int i=1; i<=10; i++)
            {
                square = i * i;
                Console.WriteLine($"{i} * {i} = {square}");
            }
        }
    }
}
