using Lib_Calendar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_IPDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //f1_ShowTheDirectory();

            f2_WriteTheDirectory();
        }

        private static void f2_WriteTheDirectory()
        {
            string ipPathDir = null;
            ipPathDir = "D:\\Takvim_2018x_Faal\\Dosyalar_Input\\Hepsi_82_il_ReadOnly";

            IPDirectory ipDirectory = new IPDirectory(ipPathDir, "2018 hoş geldiniz!");

            string s = "";

            //s = ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed();
            s = ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed_WithTimes();

            File.WriteAllText("d:\\TestWriteFile.txt", s); //Yeni dir açmıyor, hata veriyor.
        }

        private static void f1_ShowTheDirectory()
        {
            string ipPathDir = null;
            ipPathDir = "D:\\Takvim_2018x_Faal\\Dosyalar_Input\\Hepsi_82_il_ReadOnly";

            IPDirectory ipDirectory = new IPDirectory(ipPathDir, "2018 hoş geldiniz!");

            string s = "";

            //s = ipDirectory.ToString_ShowMeTheDirectory_Summary();
            //s = ipDirectory.ToString_ShowTheCities_ShowArraySplittedRaw();
            //s = ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed();
            s = ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed_WithTimes();

            Console.WriteLine(s);
        }
    }
}