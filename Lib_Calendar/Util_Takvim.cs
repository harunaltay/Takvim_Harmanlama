using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calendar
{
    public class Util_Takvim
    {
        // --- Almanca

        public static string AlmancaAyAdi(string ayAdi_input)
        {
            string ad = "";

            switch (ayAdi_input)
            {
                case "Ocak":
                    ad = "Januar";
                    break;

                case "Şubat":
                    ad = "Februar";
                    break;

                case "Mart":
                    ad = "März";
                    break;

                case "Nisan":
                    ad = "April";
                    break;

                case "Mayıs":
                    ad = "Mai";
                    break;

                case "Haziran":
                    ad = "Juni";
                    break;

                case "Temmuz":
                    ad = "Juli";
                    break;

                case "Ağustos":
                    ad = "August";
                    break;

                case "Eylül":
                    ad = "September";
                    break;

                case "Ekim":
                    ad = "Oktober";
                    break;

                case "Kasım":
                    ad = "November";
                    break;

                case "Aralık":
                    ad = "Dezember";
                    break;

                default:
                    break;
            }

            return ad;
        }

        public static string AlmancaGunAdi(string gunAdi_input)
        {
            string ad = "";

            switch (gunAdi_input)
            {
                case "Pazartesi":
                    ad = "Montag";
                    break;

                case "Salı":
                    ad = "Dienstag";
                    break;

                case "Çarşamba":
                    ad = "Mittwoch";
                    break;

                case "Perşembe":
                    ad = "Donnerstag";
                    break;

                case "Cuma":
                    ad = "Freitag";
                    break;

                case "Cumartesi":
                    ad = "Samstag";
                    break;

                case "Pazar":
                    ad = "Sonntag";
                    break;

                default:
                    break;
            }

            return ad;
        }

        // --- İngilizce

        public static string ingilizceAyAdi(string ayAdi_input)
        {
            string ad = "";

            switch (ayAdi_input)
            {
                case "Ocak":
                    ad = "January";
                    break;

                case "Şubat":
                    ad = "Feburary";
                    break;

                case "Mart":
                    ad = "March";
                    break;

                case "Nisan":
                    ad = "April";
                    break;

                case "Mayıs":
                    ad = "May";
                    break;

                case "Haziran":
                    ad = "June";
                    break;

                case "Temmuz":
                    ad = "July";
                    break;

                case "Ağustos":
                    ad = "August";
                    break;

                case "Eylül":
                    ad = "September";
                    break;

                case "Ekim":
                    ad = "October";
                    break;

                case "Kasım":
                    ad = "November";
                    break;

                case "Aralık":
                    ad = "December";
                    break;

                default:
                    break;
            }

            return ad;
        }

        public static string ingilizceGunAdi(string gunAdi_input)
        {
            string ad = "";

            switch (gunAdi_input)
            {
                case "Pazartesi":
                    ad = "Monday";
                    break;

                case "Salı":
                    ad = "Tuesday";
                    break;

                case "Çarşamba":
                    ad = "Wednesday";
                    break;

                case "Perşembe":
                    ad = "Thursday";
                    break;

                case "Cuma":
                    ad = "Friday";
                    break;

                case "Cumartesi":
                    ad = "Saturday";
                    break;

                case "Pazar":
                    ad = "Sunday";
                    break;

                default:
                    break;
            }

            return ad;
        }
    }
}
