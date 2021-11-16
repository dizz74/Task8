using System;
using System.IO;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "C:/VM/";

            DirectoryInfo di = new DirectoryInfo(dirPath);
            if (!di.Exists)
                Console.WriteLine("Error");
            else
                PrintDirInfo(di);

            Console.ReadKey();
        }


        static void PrintDirInfo(DirectoryInfo d)
        {
            Console.WriteLine("D {0}", d.FullName);
            foreach (DirectoryInfo inDir in d.GetDirectories())
            {
                PrintDirInfo(inDir);
                Console.WriteLine("D {0}", d.FullName);
            }

            foreach (FileInfo fi in d.GetFiles())
            {
                Console.WriteLine("F {0}", fi.FullName);
            }
        }
    }
}
