using System;
//A compny decided to give bonus of 5% to employee if his/her year of service is more than 5.
//Ask user for their salaries and year of service of employee.

namespace Class_Training_Day1
{
    class Emp
    {
        public static void Main11()
        {
            double total_sal;

            Console.WriteLine("Enter salary of employee ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter year of service of employee ");
            double Service_yr = Convert.ToDouble(Console.ReadLine());

            if(Service_yr > 5)
            {
                total_sal = salary+(salary * 5) / 100;
                Console.WriteLine("Salary after 5% bonus : "+total_sal);
            }
            else
            {
                Console.WriteLine("Salary is "+salary);
            }
        }
    }
}
