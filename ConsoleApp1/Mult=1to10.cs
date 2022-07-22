using System;
//print multication from 1 to 10

namespace ConsoleApp1
{
    class Mult_1to10
    {
        public static void Main()
        {
            int mult=1 ;
            for(int i=1; i<=10;i++)
            {
                mult = mult * i;
            }
            Console.WriteLine(mult);
        }
    }
}
