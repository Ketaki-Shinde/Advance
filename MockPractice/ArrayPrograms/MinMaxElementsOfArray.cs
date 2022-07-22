using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice.ArrayPrograms
{
    class MinMaxElementsOfArray
    {
        public static void Main()
        {
            int[] arr = new int[8] {5,6,2,3,4,1,9,7 };

            int max = arr[0];
            int min = arr[0];

            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]>max ) 
                {
                    max = arr[i];
                    
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }    
            }
            Console.WriteLine($"Maximum element of array {max} ");
            Console.WriteLine($"Minimum element of array {min} ");
        }
    }
}
