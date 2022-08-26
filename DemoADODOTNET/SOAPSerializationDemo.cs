using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

/*namespace DemoAdoNet
{
    [Serializable]
    public class Student3
    {
        public int Rollno { get; set; }
        public String Name { get; set; }
        public double Percentage { get; set; }
    }
    public class SOAPSerializationDemo
    {
        static void SOAPSerializationWrite(Student3 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\SoapFile.dat", FileMode.Create, FileAccess.Write);
                SoapFormatter sf= new SoapFormatter();
                sf.Serialize(fs, stud);
                Console.WriteLine("Xml data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SOAPSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\SoapFile.dat", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Student3 stud = (Student3)sf.Deserialize(fs);
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
            Student3 stud = new Student3 { Rollno = 101, Name = "Suraj", Percentage = 89.44 };
            SOAPSerializationWrite(stud);
            SOAPSerializationRead();
        }

    }
}*/
