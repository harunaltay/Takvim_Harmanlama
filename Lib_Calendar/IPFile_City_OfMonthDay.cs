using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calendar
{
    public class IPFile_City_OfMonthDay
    {
        public string Name_City { get; set; }
        public FileInfo fi_City { get; set; }
        public string stringInputtedRaw { get; set; }
        public string[] stringArraySplittedRaw { get; set; }
        public List<IPPage_Month_OfDay> listMonths { get; set; }
        public Singleton singleton { get; set; }
        public int noOfMonthNow { get; set; }

        public IPFile_City_OfMonthDay(FileInfo fi_City_in)
        {
            singleton = Singleton.Instance;
            noOfMonthNow = 0;

            fi_City = fi_City_in;
            Name_City = fi_City.Name.Replace(".txt", "");

            stringInputtedRaw = File.ReadAllText(fi_City.FullName);
            stringInputtedRaw = stringInputtedRaw.Trim();



            this.stringArraySplittedRaw =
                this.stringInputtedRaw.Split(new char[] { (char)18 }, StringSplitOptions.RemoveEmptyEntries);



            for (int i = 0; i < this.stringArraySplittedRaw.Length; i++)
            {
                this.stringArraySplittedRaw[i] = this.stringArraySplittedRaw[i].Trim();
            }

            listMonths = new List<IPPage_Month_OfDay>();

            foreach (string item in this.stringArraySplittedRaw)
            {
                listMonths.Add
                    (new IPPage_Month_OfDay(item, this.Name_City, singleton.MonthNames[noOfMonthNow]));
                noOfMonthNow++;
            }
        }

        public IPFile_City_OfMonthDay(FileInfo fi_City_in, string Dummy2018)
        {
            singleton = Singleton.Instance;
            noOfMonthNow = 0;

            fi_City = fi_City_in;
            Name_City = fi_City.Name.Replace(".txt", "");

            stringInputtedRaw = File.ReadAllText(fi_City.FullName);
            stringInputtedRaw = stringInputtedRaw.Trim();


            this.stringArraySplittedRaw = 
                stringInputtedRaw.Split(new string[] { Name_City }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < this.stringArraySplittedRaw.Length; i++)
            {
                this.stringArraySplittedRaw[i] = this.stringArraySplittedRaw[i].Trim();
            }

            listMonths = new List<IPPage_Month_OfDay>();

            foreach (string item in this.stringArraySplittedRaw)
            {
                //Console.WriteLine("*************************************************************************************");
                //Console.WriteLine(item);
                //Console.WriteLine("*************************************************************************************");

                listMonths.Add
                    (new IPPage_Month_OfDay(item, this.Name_City, singleton.MonthNames[noOfMonthNow]));
                noOfMonthNow++;
            }
        }

        public string ToString_ShowTheCity_MonthByMonth_WithLineDetails()
        {
            string s = "";
            s += "********************************************************************\n";
            s += "********************************************************************\n";
            s += "********************************************************************\n";
            s += "Name_City : " + Name_City + "... One Year Times...\n";
            s += "\n";
            s += "fi_City.FullName : " + fi_City.FullName + "\n";
            s += "fi_City.Name     : " + fi_City.Name + "\n";
            s += "fi_City.Name.Replace(\".txt\", \"\") : " + fi_City.Name.Replace(".txt", "") + "\n";
            s += "********************************************************************\n";
            s += "********************************************************************\n";
            s += "********************************************************************\n\n\n\n";

            foreach (IPPage_Month_OfDay month in this.listMonths)
            {
                //s += month.ToString_ShowMeThePage() + "\n";
                s += month.ToString_ShowMeThePage_WithTimesSeparately() + "\n";
            }
            s += "********************************************************************\n";
            s += "\n";
            s += "\n";
            s += "\n";

            return s;
        }

        public string ToString_ShowTheCity_MonthByMonth()
        {
            string s = "";
            s += "********************************************************************\n";
            s += "********************************************************************\n";
            s += "********************************************************************\n";
            s += "Name_City : " + Name_City + "... One Year Times...\n";
            s += "\n";
            s += "fi_City.FullName : " + fi_City.FullName + "\n";
            s += "fi_City.Name     : " + fi_City.Name + "\n";
            s += "fi_City.Name.Replace(\".txt\", \"\") : " + fi_City.Name.Replace(".txt", "") + "\n";
            s += "********************************************************************\n";
            s += "********************************************************************\n";
            s += "********************************************************************\n\n\n\n";

            foreach (IPPage_Month_OfDay month in this.listMonths)
            {
                s += month.ToString_ShowMeThePage() + "\n";
            }
            s += "********************************************************************\n";
            s += "\n";
            s += "\n";
            s += "\n";

            return s;
        }
    }
}
