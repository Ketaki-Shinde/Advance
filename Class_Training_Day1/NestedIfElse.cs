using System;


namespace Class_Training_Day1
{
    class NestedIfElse
    {
        public static void Main11()
        {
            Console.WriteLine("Enter 3 numbers ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greater");

            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("number 2 is greater");
            }
            else
            {
                Console.WriteLine("number 3 is greater");
            }
 /*               if(num1 > num3)
                {
                    Console.WriteLine("number 1 is grater");
                }
                else
                {
                    if(num3 > num2)
                    {
                        Console.WriteLine("number 3 is greater");
                    }
                    else
                    {
                        Console.WriteLine("number 2 is greater");
                    }
                }
            }
            else
            {
                Console.WriteLine("number 2 is greater");
            }*/
        }
    }
}
