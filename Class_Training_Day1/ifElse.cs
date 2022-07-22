using System;

// Write a program to ask a week day from user and check if it is FRIDAY,
// if FRIDAY print "Today is Friday" else print "Today is not Friday"

namespace Class_Training_Day1
{
    class ifElse
    {
        public static void Main1()
        {
            //String str = "FRIDAY";

            Console.WriteLine("Enter week day ");
            String str = Console.ReadLine();

            if(str == "FRIDAY")
            {
                Console.WriteLine("Today is Friday");
            }
            else
            {
                Console.WriteLine("Today is not Friday");
            }

        }

    }
}
