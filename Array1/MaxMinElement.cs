using System;
//WAP to find the maximum and minimum value in an array.

namespace MockPractice
{
    class MaxMinElement
    {
        public static void Main1()
        {
            int[] arr = new int[6] {1,5,4,9,8,2 };
            int min = 0, max = 0;

            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]<arr[i+1])
                {
                    max = arr[i+1];
                    min = arr[i];
                }
                else 
                {
                    max = arr[i];
                    min = arr[i+1];
                }
            }
           
        }
    }
}
