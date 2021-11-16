using System;
using System.IO;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileName = "calc.txt";
            if (!File.Exists(fileName)) File.Create(fileName);

            using (StreamWriter sw = new StreamWriter(fileName, false)) {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(0,50));
                }
            }

            using(StreamReader sr=new StreamReader(fileName))
            {
                string s;
                int summ=0;
                while ((s = sr.ReadLine()) != null)
                {
                    summ += Convert.ToInt32(s);
                    Console.WriteLine(s);
                }
                Console.WriteLine("Сумма:{0}",summ);

            }


                Console.ReadKey();
        }
    }
}
