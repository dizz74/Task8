using System;
using System.IO;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader("../../../text.txt"))
            {
                string s;
                int strokes = 0;
                int chars = 0;
                int words = 0;

                while ((s = sr.ReadLine()) != null)
                {
                    strokes++;
                    chars += s.Length; 
                    words += s.Split().Length;
                }
                Console.WriteLine("Строк:{0} Слов {1} Символов: {2}",strokes,words,chars);//space count included

            }


            Console.ReadKey();

            

        }
    }
}
