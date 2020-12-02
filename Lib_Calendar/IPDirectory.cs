using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calendar
{
    public class IPDirectory
    {
        public string pathDirectory { get; set; }
        public string[] stringArrayFilesPath { get; set; }
        public int numberOfFiles { get; set; }
        public List<FileInfo> list_fi { get; set; }
        public List<IPFile_City_OfMonthDay> list_City { get; set; }

        public IPDirectory(string pathDirectoryForInput)
        {
            this.pathDirectory = pathDirectoryForInput;
            this.stringArrayFilesPath = Directory.GetFiles(pathDirectory);
            this.numberOfFiles = this.stringArrayFilesPath.Length;

            Array.Sort<string>(this.stringArrayFilesPath);

            list_fi = new List<FileInfo>();
            list_City = new List<IPFile_City_OfMonthDay>();

            FileInfo fi_Temp = null;
            IPFile_City_OfMonthDay city_temp = null;

            foreach (string item in stringArrayFilesPath)
            {
                fi_Temp = new FileInfo(item);
                list_fi.Add(fi_Temp);

                city_temp = new IPFile_City_OfMonthDay(fi_Temp);
                list_City.Add(city_temp);
            }
        }

        public IPDirectory(string pathDirectoryForInput, string Dummy2018)
        {
            this.pathDirectory = pathDirectoryForInput;
            this.stringArrayFilesPath = Directory.GetFiles(pathDirectory);
            this.numberOfFiles = this.stringArrayFilesPath.Length;

            Array.Sort<string>(this.stringArrayFilesPath);

            list_fi = new List<FileInfo>();
            list_City = new List<IPFile_City_OfMonthDay>();

            FileInfo fi_Temp = null;
            IPFile_City_OfMonthDay city_temp = null;

            foreach (string item in stringArrayFilesPath)
            {
                fi_Temp = new FileInfo(item);
                list_fi.Add(fi_Temp);

                city_temp = new IPFile_City_OfMonthDay(fi_Temp, "2018 hoş geldiniz!");
                list_City.Add(city_temp);
            }
        }

        public string ToString_ShowTheCities_ShowArraySplittedRaw()
        {
            string s = "ToString_ShowTheCities_ShowArraySplittedRaw!\n\n";

            s += "\n" + "numberOfFiles : " + this.numberOfFiles + "\n\n";

            foreach (var item in list_fi)
            {
                s += item.Name + "\n";
            }

            s += "\n\n";

            s += "\n\nYear ***************************************************************\n\n";

            foreach (IPFile_City_OfMonthDay city in this.list_City)
            {
                s += "\n\ncity ***************************\n\n";
                s += "-> " + city.fi_City.Name.ToString() + "\n";

                //s += city.stringInputtedRaw + "\n\n";

                foreach (string month in city.stringArraySplittedRaw)
                {
                    s += month + "\n\n***\n\n";
                }

            }

            return s;
        }
        public string ToString_ShowMeTheDirectory_Summary()
        {
            string s = "ToString_ShowMeTheDirectory_Summary!\n\n";

            foreach (var item in this.stringArrayFilesPath)
            {
                s += item + "\n";
            }

            s += "\n";
            s += "numberOfFiles : " + this.numberOfFiles + "\n\n";

            foreach (var item in list_fi)
            {
                s += item.Name + "\n";
            }

            s += "\n\n";

            foreach (var item in list_fi)
            {
                s += item.Name.Replace(".txt", "") + "\n";
            }

            s += "\n\n";

            foreach (var item in list_fi)
            {
                s += item.FullName + "\n";
            }

            s += "\n\n***\n\n";

            foreach (IPFile_City_OfMonthDay city in this.list_City)
            {
                s += "-> " + city.fi_City.Name + "\n";
            }

            return s;
        }
        public string ToString_ShowMeTheDirectory_Detailed_Processed()
        {
            string s = "";

            foreach (IPFile_City_OfMonthDay city in this.list_City)
            {
                s += city.ToString_ShowTheCity_MonthByMonth();
            }

            return s;
        }
        public string ToString_ShowMeTheDirectory_Detailed_Processed_WithTimes()
        {
            string s = "";

            foreach (IPFile_City_OfMonthDay city in this.list_City)
            {
                s += city.ToString_ShowTheCity_MonthByMonth_WithLineDetails();
            }

            return s;
        }

    }
}
