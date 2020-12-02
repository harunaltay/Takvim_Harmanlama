using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_Calendar;
using System.IO;

namespace Dev_Calendar
{
    class Programs
    {
        static void Main(string[] args)
        {
            f1_WriteTo_Takvim_Gazete();

            //f1_WriteTo_Takvim_Duvar(); // 2021 de başlandı

            //f1_1_WriteTo_Takvim_Duvar_4_24_sehirler_ayri(); // 2020 de de çalıştı

            //f1_WriteTo_Takvim_Duvar_Bediuzzaman();

            //f1_WriteTo_Takvim_Duvar_Bediuzzaman_2019(); // 2020 de de çalıştı! // 2021 de de çalışacak mı bakalım!

            //f1_WriteTo_Takvim_Duvar_Almanya(); // 2019 a uygun hale getirildi // 2020 de de çalışır mı?

            //f1_WriteTo_Takvim_Duvar_Avustralya(); // 2019 a uygun hale getirildi
        }

        private static void f1_WriteTo_Takvim_Gazete()
        {
            Calendar calendar = new Calendar(); //Gazete Takvimi

            //Console.WriteLine(calendar.ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed());

            calendar.PopulateTheArray();

            //calendar.JustDisplayTheArrayForOutput();

            calendar.FinalResult_WriteAYear_MonthDayCity_Gazete(); // Gazete için bunu kullan
        }

        private static void f1_WriteTo_Takvim_Duvar()
        {
            Calendar calendar = new Calendar("DuvarTakvimi"); //Duvar Takvimi 

            //Console.WriteLine(calendar.ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed());

            calendar.PopulateTheArray();

            //calendar.JustDisplayTheArrayForOutput();

            calendar.FinalResult_WriteAYear_MonthDayCity_Duvar(); // Duvar için bunu kullan
        }

        private static void f1_1_WriteTo_Takvim_Duvar_4_24_sehirler_ayri()
        {
            Calendar calendar = new Calendar("DuvarTakvimi"); //Duvar Takvimi 

            //Console.WriteLine(calendar.ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed());

            calendar.PopulateTheArray();

            //calendar.JustDisplayTheArrayForOutput();

            calendar.FinalResult_WriteAYear_MonthDayCity_Duvar_4_24_ayri(); // Duvar için bunu kullan
        }

        private static void f1_WriteTo_Takvim_Duvar_Almanya()
        {
            Calendar calendar = new Calendar("Almanya", 1);

            //Console.WriteLine(calendar.ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed());

            calendar.PopulateTheArray();

            //calendar.JustDisplayTheArrayForOutput();

            calendar.FinalResult_WriteAYear_MonthDayCity_Duvar_Almanya_4_27_sehirler(); // Duvar için bunu kullan
        }

        private static void f1_WriteTo_Takvim_Duvar_Avustralya()
        {
            Calendar calendar = new Calendar("Avustralya", 1, 1); //Avustralya 

            //Console.WriteLine(calendar.ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed());

            calendar.PopulateTheArray();

            //calendar.JustDisplayTheArrayForOutput();

            calendar.FinalResult_WriteAYear_MonthDayCity_Duvar_Avustralya(); // Duvar için bunu kullan
        }

        private static void f1_WriteTo_Takvim_Duvar_Bediuzzaman()
        {
            Calendar calendar = new Calendar("DuvarTakvimi", "Bediuzzaman Takvimi"); //Duvar Takvimi 

            //Console.WriteLine(calendar.ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed());

            calendar.PopulateTheArray();

            //calendar.JustDisplayTheArrayForOutput();

            //calendar.FinalResult_WriteAYear_MonthDayCity_Duvar_Bediuzzaman1_3OzelSehir();
            calendar.FinalResult_WriteAYear_MonthDayCity_Duvar_Bediuzzaman2_2OzelSehir();
        }

        private static void f1_WriteTo_Takvim_Duvar_Bediuzzaman_2019()
        {
            Calendar calendar = new Calendar("DuvarTakvimi", "Bediuzzaman Takvimi", 2019); //Duvar Takvimi 

            //Console.WriteLine(calendar.ipDirectory.ToString_ShowMeTheDirectory_Detailed_Processed());

            calendar.PopulateTheArray();

            //calendar.JustDisplayTheArrayForOutput();

            calendar.FinalResult_WriteAYear_MonthDayCity_Duvar_Bediuzzaman1_ve_2_4OzelSehir(); 
            // 2021'de de çalışacak inşaallah!
        }
    }
}
