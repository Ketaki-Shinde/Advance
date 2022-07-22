using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice.ArrayPractice
{
    class EvnArray
    {
        public static void Main1()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter Elements into array : ");
            
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}
