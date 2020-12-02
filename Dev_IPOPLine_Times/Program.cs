using Lib_Calendar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_IPOPLine_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOneLine();
        }

        private static void TestOneLine()
        {
            string path;
            path = "D:\\Takvim_2018x_Faal\\Dosyalar_Input\\Test\\2018_ADANA_Ocak_01.txt";

            string stringLine = "";

            stringLine = File.ReadAllText(path);
            stringLine = stringLine.Trim();

            IPOPLine_Times_WithDayMonthCity line = new IPOPLine_Times_WithDayMonthCity
                (stringLine, "Adanaaa!", "Ocaaaakk!");

            Console.WriteLine(line.ToString_ShowTheLine());
        }
    }
}
