using System;


namespace ConsoleApp1
{
    internal class ToggleCase
    {
        static void Main(string[] args)
        {
            String str = "GeeKfoRGeek";
            Console.WriteLine(str);
            char[] ch = str.ToCharArray();

            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i]>='A' && ch[i]<='Z')
                {
                    ch[i] = (char)((int)ch[i]+32);
                }
                else if (ch[i]>='a' && ch[i]<='z')
                {
                    ch[i] = (char)((int)ch[i]-32);
                }
                
            }
            String str1 = new String(ch);
            Console.WriteLine(str1);
            //for(int i=0;i<ch.Length;i++)
            //{
            //    Console.WriteLine(ch[i]);
            //}

        }
    }
}
