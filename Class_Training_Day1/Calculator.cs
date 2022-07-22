using System;


namespace Class_Training_Day1
{
    class Calculator
    {
        public static void Main1()
        {
            Console.WriteLine("Start main method");
            add();
            subtract();
            division();
            multi();

            Console.WriteLine("Start main method");
        }

        public static void add()
        {
            Console.WriteLine(2 + 3);   
        }

        public static void subtract()
        {
            Console.WriteLine(2 - 3);
        }

        public static void division()
        {
            Console.WriteLine(9 / 3);
        }
        public static void multi()
        {
            Console.WriteLine(2 * 3);
        }
    }
}
