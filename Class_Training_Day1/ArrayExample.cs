using System;


namespace Class_Training_Day1
{
    class ArrayExample
    {
        public static void Main1()
        {
            // WAP to  have an arrayof 10 elements and print the even numbers
            // Syntax - datattype[] arrayname = new int[size] 
            int[] arr = new int[10]; // array declartion 
            arr[0] = 10;
            arr[1] = 21;
            arr[2] = 80;
            arr[3] = 51;
            arr[4] = 55;
            arr[5] = 88;
            arr[6] = 97;
            arr[7] = 5;
            arr[8] = 63;
            arr[9] = 7;
            arr[12] = 71;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even number is " + i);
            }
        }
    }
}
