using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calendar
{
    public class IPOPLine_Times_WithDayMonthCity
    {
        public string stringLineTextInputted { get; set; }

        public string Name_City { get; set; }
        public string Name_Month { get; set; }
        public string Name_Day_string { get; set; }
        public int Name_Day_int { get; set; }

        public string x1_imsak { get; set; }
        public string x2_gunes { get; set; }
        public string x3_oylen { get; set; }
        public string x4_ikindi { get; set; }
        public string x5_aksam { get; set; }
        public string x6_yatsi { get; set; }
        public string x7_kible_saati { get; set; }

        public IPOPLine_Times_WithDayMonthCity(
            string stringLineTextInputted_in,
            string Name_City_in,
            string Name_Month_in)
        {
            this.stringLineTextInputted = stringLineTextInputted_in.Trim();
            this.Name_City = Name_City_in.Trim();
            this.Name_Month = Name_Month_in.Trim();

            parseTheLineInputted();

            Name_Day_int = Int32.Parse(this.Name_Day_string);
        }

        private void parseTheLineInputted()
        {
            string[] sArray = stringLineTextInputted.Split
                (new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Name_Day_string = sArray[0];

            x1_imsak = sArray[1] + "." + sArray[2];
            x2_gunes = sArray[3] + "." + sArray[4];
            x3_oylen = sArray[5] + "." + sArray[6];

            try
            {
                x4_ikindi = sArray[7] + "." + sArray[8];
            }
            catch (Exception e)
            {
                Console.WriteLine("stringLineTextInputted : " + stringLineTextInputted);
                Console.WriteLine("Name_City : " + Name_City);
                Console.WriteLine("Name_Month : " + Name_Month);
                Console.WriteLine();

                Console.WriteLine(e);
                throw new Exception();
            }


            x5_aksam = sArray[9] + "." + sArray[10];
            x6_yatsi = sArray[11] + "." + sArray[12];
            x7_kible_saati = sArray[13] + "." + sArray[14];
        }

        public string ToString_Times_WithoutKible()
        {
            string s = "";

            s += x1_imsak + "\t";
            s += x2_gunes + "\t";
            s += x3_oylen + "\t";
            s += x4_ikindi + "\t";
            s += x5_aksam + "\t";
            s += x6_yatsi;

            return s;
        }

        public string ToString_ShowTheLine()
        {
            string s = "";
            s += "***\n";

            s += "this.stringLineTextInputted : " + this.stringLineTextInputted + "\n";
            s += "\n";

            s += "this.Name_City\t\t: " + this.Name_City + "\n";
            s += "this.Name_Month\t\t: " + this.Name_Month + "\n";
            s += "this.Name_Day_string\t: " + this.Name_Day_string + "\n";
            s += "this.Name_Day_int\t: " + this.Name_Day_int + "\n";
            s += "\n";

            s += "x1_imsak  \t: " + x1_imsak + "\n";
            s += "x2_gunes  \t: " + x2_gunes + "\n";
            s += "x3_oylen  \t: " + x3_oylen + "\n";
            s += "x4_ikindi \t: " + x4_ikindi + "\n";
            s += "x5_aksam  \t: " + x5_aksam + "\n";
            s += "x6_yatsi  \t: " + x6_yatsi + "\n";
            s += "x7_kible_saati \t: " + x7_kible_saati + "\n";
            s += "***\n";

            return s;
        }
    }
}
