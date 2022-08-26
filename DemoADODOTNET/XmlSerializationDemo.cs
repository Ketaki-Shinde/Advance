using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoAdoNet
{
    [Serializable]
    public class Student2
    {
        public int Rollno { get; set; }
        public String Name { get; set; }
        public double Percentage { get; set; }
    }
    public class XmlSerializationDemo
    {
        static void XMLSerializationWrite(Student2 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\XmlFile.dat", FileMode.Create, FileAccess.Write);
                XmlSerializer xs=new XmlSerializer(typeof(Student2));
                xs.Serialize(fs, stud);
                Console.WriteLine("Xml data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\XmlFile.dat", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Student2));
                Student2 stud = (Student2)xs.Deserialize(fs);
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
            Student2 stud = new Student2 { Rollno = 101, Name = "Suraj", Percentage = 89.44 };
            XMLSerializationWrite(stud);
            XmlSerializationRead();
        }
    }
}
