using System;


namespace Class_Training_Day1
{
    class RelationalOp
    {
        public static void Main2()
        {
            //char str = 'S';
            // string str2 = null;

            int num1, num2;
            float num3;
            Console.WriteLine("Enter the 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            // variable defination


            // CONVERT - no error will come if value is NULL
            //num1 = Convert.ToInt32(str2);
            //Console.WriteLine("num1 is " + num1);
            // PARSE - error will come if value is NULL
            // num1 = int.Parse(str2); 

            //ASCII Example
            //Console.WriteLine("str is " + str);
            // this will give you an ASCII value of str that means ASCII value of 'S'
            //num1 = Convert.ToInt32((str));
            //Console.WriteLine("num1 is "+ num1);

            Console.WriteLine("Enter the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd float number");

            //num3 = Convert.ToInt64(Console.ReadLine());  this will not work
            /// difference between COnvert and Parse - Convert handles NULL value but Parse cannot handle NULL value it will throe exception
            num3 = float.Parse(Console.ReadLine());

            // Relational Operator always return a boolean value
            // greater than >
            bool result = num1 > num2;
            Console.WriteLine("greater result is " + result);

            // greater than or equal to >=
            Console.WriteLine("greater or equal to result is " + (num1 >= num2));

            // less than <
            Console.WriteLine("less than  result is " + (num1 < num2));

            // less than or equals to <=
            Console.WriteLine("less than or equals to result is " + (num1 <= num2));

            // Equals to == will check only values
            Console.WriteLine("the equals result 2 int is " + (num1 == num2));
            Console.WriteLine("the equals result of int and float is " + (num1 == num3));


            // Not Equals to != 
            Console.WriteLine("the not equals result 2 int is " + (num1 != num2));
            Console.WriteLine("the not equals result of int and float is " + (num1 != num3));

        }
    }
}
