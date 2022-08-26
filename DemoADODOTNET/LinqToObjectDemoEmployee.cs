using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdoNet
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {City} ";
        }
    }

    public class LinqToObjectDemoEmployee
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
             new Employee() { Id = 1, Name = "Ketaki", Salary = 10000, City = "Pune" },
             new Employee() { Id = 2, Name = "Utkarsh", Salary = 80000, City = "Satara" },
             new Employee() { Id = 3, Name = "Sagar", Salary = 30000, City = "Mumbai" },
             new Employee() { Id = 4, Name = "Nikhil", Salary = 45000, City = "Kop" },
             new Employee() { Id = 5, Name = "Asmita", Salary = 25000, City = "Akola" },
             new Employee() { Id = 6, Name = "Sonali", Salary = 15000, City = "Mumbai" },
             new Employee() { Id = 7, Name = "Pallavi", Salary = 10000, City = "Sangali" },
             new Employee() { Id = 8, Name = "Mayur", Salary = 14000, City = "Pune" },
             new Employee() { Id = 9, Name = "Sanket", Salary = 35000, City = "Karad" },
             new Employee() { Id = 10, Name = "Raj", Salary = 25000, City = "Pune" }
        };

            //display all employees
            var result1 = from e in employees
                          select e;

            //display employee with asending order by name
            var result2 = from e in employees
                          orderby e.Name
                          select e;

            //display employee whose salary is > 25000
            var result3 = from e in employees
                          where e.Salary > 25000
                          select e;

            // display employee whos from 'Pune' City
            var result4 = from e in employees
                          where e.City=="Pune"
                          select e;

            //display employee with desending order by salary
            var result5 = from e in employees
                          orderby e.Salary descending
                          select e;

            //display employee whose name start with 'P'
            var result6 = from e in employees
                          where e.Name.StartsWith("P")
                          select e;

            //display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var result7 = from e in employees
                          where e.Salary > 25000 && e.City == "Mumbai"
                          select e;



            foreach (var item in result7)
            {
                Console.WriteLine(item);
            }

        }


    }
}
