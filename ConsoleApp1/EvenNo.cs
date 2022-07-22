using System;
//Write a program to print even numbers from 121 to 229 using for loop. 
//Write a program to print odd numbers from 521 to 229 using while loop.
namespace ConsoleApp1
{
    internal class EvenNo
    {
        static void Main(string[] args)
        {
            for(int i=121; i<=229;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Odd no using while loop");
            int j = 521;

            while(j >= 229)
            {
                if(j % 2!=0)
                {
                    j++;
                    Console.WriteLine(j);
                    
                }
            }
        }
    }
}
