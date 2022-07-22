using System;


namespace Class_Training_Day1
{
    class PrgramName
    {
        public static void Main1()
        {

            //variable declaration and defination
            int num1, num2; 

            //Arithmatic operations 
            //Enter values from user

            Console.WriteLine("Enter 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Multiplication of numbers
            Console.WriteLine(num1 +"*"+ num2 +" = "+(num1*num2));

            //Subtraction
            Console.WriteLine("subtraction of 2 number : "+num1+" - "+num2+" = "+(num1-num2));

            //Division 
            //remainder
            Console.WriteLine("Division i.e ramainder of 2 num : "+num1+" / "+num2+" = "+(num1/num2));

            //quotient i.e mod
            Console.WriteLine("Quotient is : "+num1+" % "+num2+" = "+(num1%num2));

            //Assignment operator =
            int num = 8;
            Console.WriteLine("Assignment operator is " + num);

        }
    }
}
