using System;


namespace Class_Training_Day1
{
    class UserThroughEnter
    {
        public static void Main4()
        {
            //Example to add 2 numbers which user will input a no

            Console.WriteLine("Enter 1st number ");
            // Console.ReadLine() - always give a string value and I enter a int value so i have to convert it. 
            //type conversion
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of 2 number is : "+(n1+n2));
            Console.WriteLine("The multiplication is : "+(n1*n2));

            subtract();

            //when i am writing subtract method in Main() then dont have to declare variable again.

            // static void subtract()
            //{

            //    Console.WriteLine("The subtraction of 2 number is : " + (n1 - n2));
            //}



        }

        //creating a seperate method for sutraction out of Main()
        public static void subtract()
        {
            Console.WriteLine("Enter 1st number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The subtraction of 2 number is : "+(num1-num2));
        }




    }
}
