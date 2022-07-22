using System;
// WAP to input a day of week and check whether it is weekday or weekend.

namespace Class_Training_Day1
{
    class CheckDay
    {
        public static void Main1()
        {
            Console.WriteLine("Enter day ");
            String day = Console.ReadLine().ToUpper();
            Console.WriteLine(day);

            if(day=="MONDAY" || day=="TUESDAY" || day == "WEDNESDAY" || day == "THURSDAY" || day == "FRIDAY")
            {
                Console.WriteLine("It is weekday");
            }
            else if(day == "SATURDAY" || day == "SUNDAY")
            {
                Console.WriteLine("It is weekend");
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }
        }
    }
}
