using System;

// ask a number from the user,
// if it is greater than 5 print "number is greater than 5"
// else print "number is less than 5"
namespace Class_Training_Day1
{
    class ifElse1
    {
        public static void Main1()
        {
            Console.WriteLine("Enter number ");
            int num = int.Parse(Console.ReadLine());

            if (num > 5)
            {
                Console.WriteLine("Number is greater than 5 ");
            }
            else
            {
                Console.WriteLine("number is less than 5");
            }
        }
    }
}
