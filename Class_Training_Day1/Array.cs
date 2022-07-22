using System;


namespace Class_Training_Day1
{
    class Array
    {
        public static void Main1()
        {
            // Array - collection of records of similar data type - 
            // if you wat to store marks of 50 students - use array but condition all should be of same data type

            //variables - data type 
            // int marks1,marks2,marks3,marks4,marks5;
            // syntax -  datatype[] arrayname = new datatype[size];
            // size - no of records that you want to store

            // WAP to store the marks of 5 students
            int[] marks = new int[5];// 5 - size means number of records in an array

            // initialize an array
            // syntax - arrayname[index] = value
            // index alwyas starts from 0 - to uniquely identify the elements of an array
            // index represents the position of an element in an array
            // inde in an array will go till size -1 . why? because index starts from 0
            marks[0] = 45;
            //marks[1] = 55;
            marks[2] = 23;
            marks[3] = 67;
            //marks[4] = 88;

            // print the marks of 2nd student - index1 - why? because index starts from 0
            // method1 to print the elements of an array
            //Console.WriteLine(marks[0]);
            //Console.WriteLine(marks[1]); //55
            //Console.WriteLine(marks[2]);
            //Console.WriteLine(marks[3]);
            //Console.WriteLine(marks[4]);

            // method2 - to print the elements of an array
            //for (int i = 0; i < 5; i++) // i=1
            //    Console.WriteLine(marks[i]);   //marks[0]=45 marks[1]=55

            // method3 - to print the elements of an array

            //int length = marks.Length; // length is the property of marks ,  length is to find the number of array element
            //for (int i = 0; i < length; i++)
            //    Console.WriteLine(marks[i]);

            // foreach loop is to go through each and every element of an array
            // foreach loop is used for array
            //syntax - foreach(datatype variablename in arrayname) - in is a keyword
            // increment/decrement operator
            // by default starts from 0th index and goes till the last elemnt of an array

            // foreach loops runs till the last element of an array
            int counter = 0;
            foreach (int i in marks)
            {
                Console.WriteLine(i);
                counter++;
              
            }

            Console.WriteLine("size of an array " + counter);

            


        }
    }
}
