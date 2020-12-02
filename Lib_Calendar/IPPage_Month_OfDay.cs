using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calendar
{
    public class IPPage_Month_OfDay
    {
        public string stringInputtedTextRaw { get; set; }
        public string[] stringArrayLinesRaw { get; set; }
        public string[] stringArrayLinesFirst4LinesDeleted { get; set; }
        public string[] stringArrayLinesFirst3LinesDeleted { get; set; }
        public string NameOfMonth { get; set; }
        public string NameOfCity { get; set; }
        public List<IPOPLine_Times_WithDayMonthCity> lines { get; set; }

        public IPPage_Month_OfDay(string stringText, string NameOfCity_input, string NameOfMonth_input)
        {
            NameOfCity = NameOfCity_input;
            NameOfMonth = NameOfMonth_input;

            this.stringInputtedTextRaw = stringText.Trim();
            this.stringInputtedTextRaw = this.stringInputtedTextRaw.Replace(((char)18).ToString(), "");
            this.stringInputtedTextRaw = this.stringInputtedTextRaw.Replace(NameOfCity, "");

            this.stringArrayLinesRaw =
                this.stringInputtedTextRaw.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < this.stringArrayLinesRaw.Length; i++)
            {
                this.stringArrayLinesRaw[i] = this.stringArrayLinesRaw[i].Trim();
            }

            this.DeleteFirst3Lines();

            //foreach (var item in stringArrayLinesFirst3LinesDeleted)
            //{
            //    Console.WriteLine("*************************************************************************************");
            //    Console.WriteLine(item);
            //    Console.WriteLine("*************************************************************************************");
            //}

            lines = new List<IPOPLine_Times_WithDayMonthCity>();

            foreach (string item in this.stringArrayLinesFirst3LinesDeleted)
            {
                // hata harun
                //Console.WriteLine(" hata - item -> " + item);

                lines.Add(new IPOPLine_Times_WithDayMonthCity(
                    item,
                    this.NameOfCity,
                    this.NameOfMonth
                    ));
            }
        }

        private void DeleteFirst4Lines()
        {
            int numOfLinesBefore = this.stringArrayLinesRaw.Length;

            this.stringArrayLinesFirst4LinesDeleted = new string[numOfLinesBefore - 4];

            for (int i = 0; i < this.stringArrayLinesRaw.Length - 4; i++)
            {
                this.stringArrayLinesFirst4LinesDeleted[i] = this.stringArrayLinesRaw[i + 4];
            }
        }

        private void DeleteFirst3Lines()
        {
            int numOfLinesBefore = this.stringArrayLinesRaw.Length;

            this.stringArrayLinesFirst3LinesDeleted = new string[numOfLinesBefore - 3];

            for (int i = 0; i < this.stringArrayLinesRaw.Length - 3; i++)
            {
                this.stringArrayLinesFirst3LinesDeleted[i] = this.stringArrayLinesRaw[i + 3];
            }
        }

        public string ToString_ShowMeThePage_WithTimesSeparately()
        {
            string s = "";
            s += "********************************************************\n";
            s += "this.NameOfCity  : " + this.NameOfCity + "\n";
            s += "this.NameOfMonth : " + this.NameOfMonth + "\n";
            s += "********************************************************\n";
            s += "***\n";

            foreach (string item in this.stringArrayLinesFirst3LinesDeleted)
            {
                s += "---> '" + item + "'\n";
            }

            s += "**************\n";

            foreach (IPOPLine_Times_WithDayMonthCity item in this.lines)
            {
                s += item.stringLineTextInputted + "\n";
                s += item.Name_City + "\n";
                s += item.Name_Month + "\n";
                s += item.Name_Day_string + "\n";
                s += item.ToString_ShowTheLine();
                s += "**************\n";
            }

            s += "********************************************************\n\n\n";

            return s;
        }

        public string ToString_ShowMeThePage()
        {
            string s = "";
            s += "********************************************************\n";
            s += "this.NameOfCity  : " + this.NameOfCity + "\n";
            s += "this.NameOfMonth : " + this.NameOfMonth + "\n";
            s += "********************************************************\n";
            s += "***\n";

            foreach (string item in this.stringArrayLinesFirst3LinesDeleted)
            {
                s += "---> '" + item + "'\n";
            }
            s += "********************************************************\n\n\n";

            return s;
        }

        public string ToString_ShowMeThePage_WithChecking_2Times()
        {
            string s = "";
            s += "********************************************************\n";
            s += "this.NameOfCity  : " + this.NameOfCity + "\n";
            s += "this.NameOfMonth : " + this.NameOfMonth + "\n";
            s += "********************************************************\n";
            s += "***\n";
            s += "*** With first 4 lines ***\n";
            s += "***\n";

            //s += this.stringInputtedTextRaw + "\n";

            foreach (string item in this.stringArrayLinesRaw)
            {
                s += "-> '" + item + "'\n";
            }

            s += "***\n";
            s += "*** first 4 lines deleted ***\n";
            s += "***\n";

            foreach (string item in this.stringArrayLinesFirst3LinesDeleted)
            {
                s += "---> '" + item + "'\n";
            }
            s += "********************************************************\n\n\n";

            return s;
        }
    }
}
