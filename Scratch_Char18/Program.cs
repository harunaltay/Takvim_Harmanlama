using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch_Char18
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void ReplaceAllChar18WithBlanks(string pathOfFile)
        {
            string pathOfFileInputted = pathOfFile;

            string textRead = File.ReadAllText(pathOfFileInputted);
            Console.WriteLine("string read    : '{0}'", textRead);

            //char c = textRead.ElementAt(0);
            //Console.WriteLine("char read      : '{0}'", c);
            //Console.WriteLine("int read       : '{0}'", (int)c);

            //string s;
            //s = c.ToString();

            //Console.WriteLine("back to string : '{0}'", s);
            //Console.WriteLine("(char)18       : '{0}'", (char)18);

            textRead = textRead.Replace((char)18, char.Parse(" "));
            Console.WriteLine("değişti mi? --> '{0}'", textRead);

            File.WriteAllText(pathOfFileInputted, textRead);
        }
    }
}