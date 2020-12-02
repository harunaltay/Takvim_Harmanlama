using Lib_Calendar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_IPFile_City
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            path = "D:\\Takvim_2018x_Faal\\Dosyalar_Input\\Test\\ADANA.txt";

            FileInfo fi = new FileInfo(path);

            ////IPFile_City_OfMonthDay city = new IPFile_City_OfMonthDay(fi);
            IPFile_City_OfMonthDay city = new IPFile_City_OfMonthDay(fi, "2018 oldu!");

            string s = "";

            s = city.ToString_ShowTheCity_MonthByMonth_WithLineDetails();
            //s = city.ToString_ShowTheCity_MonthByMonth();

            Console.WriteLine(s);
        }
    }
}
