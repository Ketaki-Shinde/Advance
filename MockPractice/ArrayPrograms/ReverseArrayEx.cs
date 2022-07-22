using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice.ArrayPractice
{
    internal class ReverseArrayEx
    {
        public static void Main1(String[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter elements into array: ");
            Console.WriteLine("Original array: ");
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reverse array: ");
            for (int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
