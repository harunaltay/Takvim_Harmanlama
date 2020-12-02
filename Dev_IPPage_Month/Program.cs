using Lib_Calendar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_IPPage_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            Show_OneMonth();
        }

        private static void Show_OneMonth()
        {
            string path;
            path = "D:\\Takvim_2018x_Faal\\Dosyalar_Input\\Test\\2018_ADANA_Ocak.txt";

            string stringInputtedPageRaw = File.ReadAllText(path);

            IPPage_Month_OfDay month = new IPPage_Month_OfDay(stringInputtedPageRaw, "Adanaa!", "Ocakkk!");

            //Console.WriteLine(month.ToString_ShowMeThePage());
            //Console.WriteLine(month.ToString_ShowMeThePage_WithChecking_2Times());

            Console.WriteLine(month.ToString_ShowMeThePage_WithTimesSeparately());
        }
    }
}
