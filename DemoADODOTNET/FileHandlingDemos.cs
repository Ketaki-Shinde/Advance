﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdoNet
{
    internal class FileHandlingDemos
    {
        public class Dept
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
        }


        static void WriteToFile(Dept dept)
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\TestFile", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(dept.Id);
                bw.Write(dept.Name);
                bw.Write(dept.Location);
                bw.Close();
                fs.Close();
                Console.WriteLine("Data added to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"G:\Files\TestFolder\TestFile", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32()); //Id
                Console.WriteLine(br.ReadString());// Name
                Console.WriteLine(br.ReadString());// Location
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            Dept dept = new Dept { Id = 1, Name = "HR", Location = "Pune" };
            WriteToFile(dept);
            ReadFromFile();
        }

    }
}
