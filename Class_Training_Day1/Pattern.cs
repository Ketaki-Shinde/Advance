using System;


namespace Class_Training_Day1
{
    class Pattern
    {
        public static void Main1()
        {
            Console.WriteLine("Enter number to print pattern");
            int n = Convert.ToInt32(Console.ReadLine());

            //*
            //**
            //***

            //for(int row=1;row<=n;row++) //row=1 1<=5
            //{
            //    for(int col=1; col<=row; col++)//col=1 1<=1
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //8
            //88
            //888
            //8888
            //88888
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write("8");
            //    }
            //    Console.Write("\n");
            //}

            //1
            //23
            //456
            //78910
            //11121314
            //int n1 = 1;
            //for(int row=1; row<= n; row++ ) //row=1 1<=5
            //{
            //    for(int col=1; col<=row; col++) //col=1 1<=
            //    {
            //        Console.Write(n1);
            //        n1++;
            //    }
            //    Console.Write("\n");
            //}

            //***
            //***
            //***
            //***
            //***

            for (int row = 1; row <= n; row++)  //row=1 1<=5
            {
                for (int col =1 ; col <= n; col++)//col=1 1<=5
                {
                    Console.Write("*");//*
                }
                Console.Write("\n");
            }
        }
    }
}
