using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DemoAdoNet
{
    [Serializable]
    public class Student
    {
        public int Rollno { get; set; }
        public String Name { get; set; }
        public double Percentage { get; set; }
    }
    public class BinarySerializationDemo
    {
        static void BinarySerializationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, stud);
                Console.WriteLine("Bianry data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BinarySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Student stud = (Student)bf.Deserialize(fs);
                Console.WriteLine(stud.Rollno);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Student stud = new Student { Rollno = 101, Name = "Suraj", Percentage = 89.44 };
            BinarySerializationWrite(stud);
            BinarySerializationRead();


        }
    }
}
