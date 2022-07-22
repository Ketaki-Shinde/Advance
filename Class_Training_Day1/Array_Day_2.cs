using System;
//Wap print diagonal elements of matrix

namespace Class_Training_Day1
{
    class Array_Day_2
    {
        public static void Main1()
        {
            /*   0   1  2
               0 00 01 02
               1 10 11 12
               2 20 21 22
             */
            int[,] arr = new int[3,3];

            Console.WriteLine("Enter elements of array");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //prints left diagonal
            for (int row=0; row < 3; row++)
            {
                for (int col=0; col < 3; col++)
                {
                    if(row == col)
                    {
                        Console.WriteLine(arr[row, col]);
                    }
                }
            }

            //print right diagonal
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if ((row+col) == 2)
                    {
                        Console.WriteLine(arr[row, col]);
                    }
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if ((row==0)  )
                    {
                        Console.WriteLine(arr[row, col]);
                    }
                }
            }

        }
        
    }
}
