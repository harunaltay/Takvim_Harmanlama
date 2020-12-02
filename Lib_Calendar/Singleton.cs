using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calendar
{
    public class Singleton
    {
        public IPOPLine_Times_WithDayMonthCity[,,] array { get; set; }

        public string[] MonthNames { get; set; }

        private Singleton()
        {
            MonthNames = new string[12];

            MonthNames[0] = "Ocak";
            MonthNames[1] = "Şubat";
            MonthNames[2] = "Mart";
            MonthNames[3] = "Nisan";
            MonthNames[4] = "Mayıs";
            MonthNames[5] = "Haziran";
            MonthNames[6] = "Temmuz";
            MonthNames[7] = "Ağustos";
            MonthNames[8] = "Eylül";
            MonthNames[9] = "Ekim";
            MonthNames[10] = "Kasım";
            MonthNames[11] = "Aralık";
        }

        public int getMonthNumber_int(string monthName)
        {
            int i = 0;

            switch (monthName)
            {
                case "Ocak":
                    i = 0;
                    break;

                case "Şubat":
                    i = 1;
                    break;

                case "Mart":
                    i = 2;
                    break;

                case "Nisan":
                    i = 3;
                    break;

                case "Mayıs":
                    i = 4;
                    break;

                case "Haziran":
                    i = 5;
                    break;

                case "Temmuz":
                    i = 6;
                    break;

                case "Ağustos":
                    i = 7;
                    break;

                case "Eylül":
                    i = 8;
                    break;

                case "Ekim":
                    i = 9;
                    break;

                case "Kasım":
                    i = 10;
                    break;

                case "Aralık":
                    i = 11;
                    break;

                default:
                    throw new Exception("Ay numarası 0 ile 11 arasında olmalı");
                    //break;
            }

            return i;
        }

        private static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}