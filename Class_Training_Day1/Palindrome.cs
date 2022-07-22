using System;


namespace Class_Training_Day1
{
    class Palindrome
    {
        public static void Main1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int length = arr.Length - 1;
            string strRev = null;
            while(length>=0)
            {
                strRev = strRev + arr[length];
                length--;
            }
            Console.WriteLine("Reverse array is : "+strRev);





            //string str;
            //Console.WriteLine("Enter string ");
            //str = Console.ReadLine();

            //string rev = string.Empty;
            //for(int i=str.Length-1; i>=0; i--)
            //{
            //    rev =rev+ str[i];
            //}
            //if (rev==str)
            //{
            //    Console.WriteLine("String is palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("String is not palindrome");
            //}
        }
    }
}
//    string str;
//    Console.WriteLine("Enter string ");
//    str = Console.ReadLine();

//    string rev_str="";
//    int length;
//    length = str.Length - 1;
//    for (int i=0;i>=length;i--)
//    {
//        rev_str = rev_str + str[i];
//    }

//    Console.WriteLine("Reverse String is : "+rev_str);