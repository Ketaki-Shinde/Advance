using System;

namespace ConsoleApp1
{
    class String_Occurence_Count
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter string ");
            string str = "India is country and India is best";
            string word = "India";
            string[] s1 = str.Split();
            int count = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i]==word)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
