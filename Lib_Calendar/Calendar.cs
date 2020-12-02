using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calendar
{
    public class Calendar
    {
        public IPDirectory ipDirectory { get; set; }
        public string stringIPDirectoryPath { get; set; }
        public string stringOPDirectoryPath { get; set; }
        public Singleton singleton { get; set; }

        HashSet<string> set4City_of_string { get; set; }
        HashSet<string> set3City_of_string { get; set; }
        HashSet<string> set2City_of_string { get; set; }

        HashSet<IPOPLine_Times_WithDayMonthCity> set4City_of_IPOPLine { get; set; }
        HashSet<IPOPLine_Times_WithDayMonthCity> set3City_of_IPOPLine { get; set; }
        HashSet<IPOPLine_Times_WithDayMonthCity> set2City_of_IPOPLine { get; set; }

        IPOPLine_Times_WithDayMonthCity istanbul { get; set; }
        IPOPLine_Times_WithDayMonthCity ankara { get; set; }
        IPOPLine_Times_WithDayMonthCity izmir { get; set; }
        IPOPLine_Times_WithDayMonthCity adana { get; set; }

        TextInfo textInfo { get; set; }

        public IPOPLine_Times_WithDayMonthCity[,,] array { get; set; }

        public Calendar() // Bu Gazete Takvimi içindir!
        {
            singleton = Singleton.Instance;

            this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Gazete_24_Vilayet\";
            this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\Gazete_24_Vilayet\";

            this.ipDirectory = new IPDirectory(stringIPDirectoryPath, "2021 oldu!");

            textInfo = new CultureInfo("tr-TR", false).TextInfo;
        }

        public Calendar(string DuvarTakvimi) // Bu Duvar Takvimi içindir!
        {
            singleton = Singleton.Instance;

            set4City_of_string = new HashSet<string>();

            //// 1.inci Bölge
            //set4City_of_string.Add("İSTANBUL");
            //set4City_of_string.Add("ANKARA");
            //set4City_of_string.Add("İZMİR");
            //set4City_of_string.Add("BURSA");
            //this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Duvar_2021_Bölge_1\";
            //this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\2021.2_Normal_Duvar_Takvimi_3_Adet_Bölgeler(hep_izmirli)\Duvar_Bolge_1\";

            //// 2.inci Bölge
            //set4City_of_string.Add("İSTANBUL");
            //set4City_of_string.Add("ANKARA");
            //set4City_of_string.Add("İZMİR");
            //set4City_of_string.Add("SAMSUN");
            //this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Duvar_2021_Bölge_2\";
            //this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\2021.2_Normal_Duvar_Takvimi_3_Adet_Bölgeler(hep_izmirli)\Duvar_Bolge_2\";

            // 3.inci Bölge
            set4City_of_string.Add("İSTANBUL");
            set4City_of_string.Add("ANKARA");
            set4City_of_string.Add("İZMİR");
            set4City_of_string.Add("DİYARBAKIR");
            this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Duvar_2021_Bölge_3\";
            this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\2021.2_Normal_Duvar_Takvimi_3_Adet_Bölgeler(hep_izmirli)\Duvar_Bolge_3\";

            this.ipDirectory = new IPDirectory(stringIPDirectoryPath, "2021 olsun mu?!");

            textInfo = new CultureInfo("tr-TR", false).TextInfo;
        }

        public Calendar(string Almanya, int i) // Bu Almanya Duvar Takvimi içindir!
        {
            singleton = Singleton.Instance;

            set4City_of_string = new HashSet<string>();

            set4City_of_string.Add("AHLEN");
            set4City_of_string.Add("DÜSSELDORF");
            set4City_of_string.Add("KÖLN");
            set4City_of_string.Add("MÜNCHEN");

            this.stringIPDirectoryPath = "D:\\Takvim_2020_Faal\\Dosyalar_Input_2020\\Almanya\\";
            this.stringOPDirectoryPath = "D:\\Takvim_2020_Faal\\Dosyalar_Output_2020\\Almanya\\";

            this.ipDirectory = new IPDirectory(stringIPDirectoryPath, "2019 oldu! 2020 olacak!");

            textInfo = new CultureInfo("tr-TR", false).TextInfo;
        }

        public Calendar(string Avustralya, int i, int j) // Bu Avustralya Duvar Takvimi içindir!
        {
            singleton = Singleton.Instance;

            set4City_of_string = new HashSet<string>();

            set4City_of_string.Add("ADELAIDE");
            set4City_of_string.Add("BRISBANE");
            set4City_of_string.Add("CANBERRA");
            set4City_of_string.Add("DARWIN");
            set4City_of_string.Add("HOBART");
            set4City_of_string.Add("MELBOURNE");
            set4City_of_string.Add("PERTH");
            set4City_of_string.Add("SYDNEY");

            this.stringIPDirectoryPath = "D:\\Takvim_2019_Faal\\Dosyalar_Input_2019\\Avustralya\\";
            this.stringOPDirectoryPath = "D:\\Takvim_2019_Faal\\Dosyalar_Output_2019\\Avustralya\\";

            this.ipDirectory = new IPDirectory(stringIPDirectoryPath, "2019 oldu!");

            textInfo = new CultureInfo("tr-TR", false).TextInfo;
        }

        public Calendar(string DuvarTakvimi, string BediuzzamanTakvimi) // Bu Duvar Takvimi içindir!
        {
            singleton = Singleton.Instance;

            set3City_of_string = new HashSet<string>();
            set2City_of_string = new HashSet<string>();

            //// 1.inci Bölge
            set3City_of_string.Add("İSTANBUL");
            set3City_of_string.Add("ANKARA");
            set3City_of_string.Add("İZMİR");
            // 1.inci Bölge
            this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Bediuzzaman_1\";
            this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\2021 Takvim Bediüzzaman 1 ve 2\Bediuzzaman_1\";

            //// 2.inci Bölge
            set2City_of_string.Add("İSTANBUL");
            set2City_of_string.Add("ANKARA");
            //// 2.inci Bölge
            //this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Bediuzzaman_2\";
            //this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\2021 Takvim Bediüzzaman 1 ve 2\Bediuzzaman_2\";

            this.ipDirectory = new IPDirectory(stringIPDirectoryPath, "2018 oldu!");

            textInfo = new CultureInfo("tr-TR", false).TextInfo;
        }

        public Calendar(string DuvarTakvimi, string BediuzzamanTakvimi, int year_2019) // Bu Duvar Takvimi içindir!
            // 2020 için kullanmıştık
            // şimdi 2021 için kullanacağız!
        {
            singleton = Singleton.Instance;

            set4City_of_string = new HashSet<string>();

            set4City_of_string.Add("İSTANBUL");
            set4City_of_string.Add("ANKARA");
            set4City_of_string.Add("İZMİR");
            set4City_of_string.Add("ADANA");

            // 1.inci Bölge
            this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Bediuzzaman_1\";
            this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\2021 Takvim Bediüzzaman 1 ve 2\Bediuzzaman_1\";

            //// 2.inci Bölge
            //this.stringIPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Input_2021\Bediuzzaman_2\";
            //this.stringOPDirectoryPath = @"D:\Takvim_2021_Faal\Dosyalar_Output_2021\2021 Takvim Bediüzzaman 1 ve 2\Bediuzzaman_2\";

            this.ipDirectory = new IPDirectory
                (stringIPDirectoryPath, "2019 oldu! 2020 de de olmuştu! Şimdi 2020 de olacak mı?");

            textInfo = new CultureInfo("tr-TR", false).TextInfo;
        }

        // ---

        public void PopulateTheArray()
        {
            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;
            array = new IPOPLine_Times_WithDayMonthCity[numberOfCities, 12, 31];

            int i = 0;
            int j = 0;
            int k = 0;

            foreach (var city in this.ipDirectory.list_City)
            {
                j = 0;
                //Console.WriteLine(city.Name_City);
                foreach (var month in city.listMonths)
                {
                    //Console.Write(month.NameOfMonth + "\n");

                    k = 0;
                    foreach (IPOPLine_Times_WithDayMonthCity liness in month.lines)
                    {
                        //Console.Write(liness.Name_Day_string + " " + k + ", ");
                        this.array[i, j, k] = liness;
                        k++;
                    }
                    //Console.WriteLine("\n");
                    //Console.WriteLine("j = " + j);
                    //Console.WriteLine("\n-------------");
                    //Console.WriteLine();
                    j++;
                }
                //Console.WriteLine("\n-----------------------------------------------------------");
                //Console.WriteLine();
                //Console.WriteLine();
                i++;
            }
        }

        // ---

        public void FinalResult_WriteAYear_MonthDayCity_Gazete()
        {
            TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;

            // input for array   : city -> month -> day (i, j, k)
            // output from array : month -> day -> city

            // iç içe 3 tane for
            // if (null) continue veya break!

            string s = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2021" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;
                    //--------------------------------------------------------------------------------------------------

                    // Harun - yeni ekleme başladı!

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    // Harun : Uzun - Kısa değiştir!

                    // burada exception verdi
                    //string dumpOfDay =
                    //singleton.year.listOf_HRM_Page_Month[NoOfMonth_int].listOf_HRM_Line_Day[NoOfDay_int].ToString_Dump_All_Gets_Kisa_ve_Uzun();
                    
                    //singleton.year.listOf_HRM_Page_Month[NoOfMonth_int].listOf_HRM_Line_Day[NoOfDay_int].ToString_Dump_All_Gets_Kisa();
                    //singleton.year.listOf_HRM_Page_Month[NoOfMonth_int].listOf_HRM_Line_Day[NoOfDay_int].ToString_Dump_All_Gets_Uzun();

                    // Harun

                    //singleton.year.listOf_HRM_Page_Month[11].listOf_HRM_Line_Day[0].ToString_Dump_All_Gets();

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    //s += Environment.NewLine;
                    //s += NoOfMonth_int + " - " + NameOfMonth_string + Environment.NewLine;
                    //s += NoOfDay_int + Environment.NewLine;
                    s += Environment.NewLine;
                    //s += dumpOfDay; // burayı kaldırdım, geçen senenin hicri rumi si geliyordu
                    s += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2021";
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    // Harun - yeni ekleme bitti!

                    //s += this.array[0, j, k].Name_Day_string + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu değiştirdim. 01 olmasın.
                    //s += this.array[0, j, k].Name_Day_int + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu da kapatıyorum, artık fazla


                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Şanlıurfa":
                                cityNameTitleCase = "Şanlı Urfa";
                                break;

                            case "Kahramanmaraş":
                                cityNameTitleCase = "K.Maraş";
                                break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        s += cityNameTitleCase + "\t";
                        s += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                    }

                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                }
                s += Environment.NewLine;
                s += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;
                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";
            }
            s += Environment.NewLine;
        } // Gazete için

        // --- Bediüzzaman Takvimi

        public void FinalResult_WriteAYear_MonthDayCity_Duvar_Bediuzzaman1_ve_2_4OzelSehir() // 2019! Bediüzzaman 1 ve 2 Bölgeler
        {
            string s = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2021" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s += Environment.NewLine;
                    s += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2021";
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    string sTablo = "";

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Şanlıurfa":
                                cityNameTitleCase = "Şanlı Urfa";
                                break;

                            case "Kahramanmaraş":
                                cityNameTitleCase = "K.Maraş";
                                break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        //if (this.set3City_of_string.Contains(cityName)) // İSTANBUL, ANKARA, İZMİR -> 1.inci Bölge
                        if (this.set4City_of_string.Contains(cityName)) // İSTANBUL, ANKARA, İZMİR, ADANA -> 1 ve 2 .inci Bölgeler
                        {
                            // Buraya 4 il girecek

                            switch (cityName)
                            {
                                case "İSTANBUL":
                                    istanbul = array[i, j, k];
                                    break;

                                case "ANKARA":
                                    ankara = array[i, j, k];
                                    break;

                                case "İZMİR":
                                    izmir = array[i, j, k];
                                    break;

                                case "ADANA":
                                    adana = array[i, j, k];
                                    break;

                                default:
                                    break;
                            }

                        }
                        else
                        {
                            // Buraya 36 il girecek

                            sTablo += cityNameTitleCase + "\t";
                            sTablo += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                        }
                    }

                    sTablo += Environment.NewLine;

                    s += "İstanbul" + "\t" + istanbul.ToString_Times_WithoutKible() + Environment.NewLine;
                    s += "Ankara" + "\t" + ankara.ToString_Times_WithoutKible() + Environment.NewLine;
                    s += "İzmir" + "\t" + izmir.ToString_Times_WithoutKible() + Environment.NewLine;
                    s += "Adana" + "\t" + adana.ToString_Times_WithoutKible() + Environment.NewLine;

                    s += sTablo;

                    s += Environment.NewLine;

                    s += "*************   gün sonu   *************" + Environment.NewLine;

                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;
                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";
            }
            s += Environment.NewLine;
        }

        public void FinalResult_WriteAYear_MonthDayCity_Duvar_Bediuzzaman1_3OzelSehir() // 2018 Bediüzzaman 1 Bölge
        {
            string s = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2018" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    // Harun - yeni ekleme başladı!

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    // Harun

                    //singleton.year.listOf_HRM_Page_Month[11].listOf_HRM_Line_Day[0].ToString_Dump_All_Gets();

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    //s += Environment.NewLine;
                    //s += NoOfMonth_int + " - " + NameOfMonth_string + Environment.NewLine;
                    //s += NoOfDay_int + Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    // Harun - yeni ekleme bitti!

                    //s += this.array[0, j, k].Name_Day_string + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu değiştirdim. 01 olmasın.
                    //s += this.array[0, j, k].Name_Day_int + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu da kapatıyorum, artık fazla

                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    string sTablo = "";

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Şanlıurfa":
                                cityNameTitleCase = "Şanlı Urfa";
                                break;

                            case "Kahramanmaraş":
                                cityNameTitleCase = "K.Maraş";
                                break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        if (this.set3City_of_string.Contains(cityName)) // İSTANBUL, ANKARA, İZMİR -> 1.inci Bölge
                        {
                            // Buraya 3 il girecek

                            switch (cityName)
                            {
                                case "İSTANBUL":
                                    istanbul = array[i, j, k];
                                    break;

                                case "ANKARA":
                                    ankara = array[i, j, k];
                                    break;

                                case "İZMİR":
                                    izmir = array[i, j, k];
                                    break;

                                default:
                                    break;
                            }

                        }
                        else
                        {
                            // Buraya 37 il girecek

                            sTablo += cityNameTitleCase + "\t";
                            sTablo += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                        }
                    }

                    sTablo += Environment.NewLine;

                    s += "İstanbul" + "\t" + istanbul.ToString_Times_WithoutKible() + Environment.NewLine;
                    s += "Ankara" + "\t" + ankara.ToString_Times_WithoutKible() + Environment.NewLine;
                    s += "İzmir" + "\t" + izmir.ToString_Times_WithoutKible() + Environment.NewLine;

                    s += sTablo;

                    s += Environment.NewLine;

                    s += "*************   gün sonu   *************" + Environment.NewLine;

                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;
                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";
            }
            s += Environment.NewLine;
        }

        public void FinalResult_WriteAYear_MonthDayCity_Duvar_Bediuzzaman2_2OzelSehir() // 2018 Bediüzzaman 2 Bölge 
        {
            string s = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2018" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    // Harun - yeni ekleme başladı!

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    // Harun

                    //singleton.year.listOf_HRM_Page_Month[11].listOf_HRM_Line_Day[0].ToString_Dump_All_Gets();

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    //s += Environment.NewLine;
                    //s += NoOfMonth_int + " - " + NameOfMonth_string + Environment.NewLine;
                    //s += NoOfDay_int + Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    // Harun - yeni ekleme bitti!

                    //s += this.array[0, j, k].Name_Day_string + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu değiştirdim. 01 olmasın.
                    //s += this.array[0, j, k].Name_Day_int + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu da kapatıyorum, artık fazla

                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    string sTablo = "";

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Şanlıurfa":
                                cityNameTitleCase = "Şanlı Urfa";
                                break;

                            case "Kahramanmaraş":
                                cityNameTitleCase = "K.Maraş";
                                break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        if (this.set2City_of_string.Contains(cityName)) // İSTANBUL, ANKARA -> 2.inci Bölge
                        {
                            // Buraya 2 il girecek

                            switch (cityName)
                            {
                                case "İSTANBUL":
                                    istanbul = array[i, j, k];
                                    break;

                                case "ANKARA":
                                    ankara = array[i, j, k];
                                    break;

                                default:
                                    break;
                            }
                        }
                        else
                        {
                            // Buraya 37 il girecek

                            sTablo += cityNameTitleCase + "\t";
                            sTablo += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                        }
                    }

                    sTablo += Environment.NewLine;

                    s += "İstanbul" + "\t" + istanbul.ToString_Times_WithoutKible() + Environment.NewLine;
                    s += "Ankara" + "\t" + ankara.ToString_Times_WithoutKible() + Environment.NewLine;

                    s += sTablo;

                    s += Environment.NewLine;

                    s += "*************   gün sonu   *************" + Environment.NewLine;

                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;
                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";
            }
            s += Environment.NewLine;
        }



        // --- Duvar, normal -----------------------------------------------------------------------------------------------

        public void FinalResult_WriteAYear_MonthDayCity_Duvar() // Duvar için
        {
            string s = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2021" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    // Harun - yeni ekleme başladı!

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    // Harun : Uzun - Kısa değiştir!

                    // Altay - aşağıyı kapattım
                    //string dumpOfDay =
                    ////singleton.year.listOf_HRM_Page_Month[NoOfMonth_int].listOf_HRM_Line_Day[NoOfDay_int].ToString_Dump_All_Gets_Kisa();
                    ////singleton.year.listOf_HRM_Page_Month[NoOfMonth_int].listOf_HRM_Line_Day[NoOfDay_int].ToString_Dump_All_Gets_Uzun();
                    //singleton.year.listOf_HRM_Page_Month[NoOfMonth_int].listOf_HRM_Line_Day[NoOfDay_int].ToString_Dump_All_Gets_Kisa_ve_Uzun();

                    // Harun

                    //singleton.year.listOf_HRM_Page_Month[11].listOf_HRM_Line_Day[0].ToString_Dump_All_Gets();

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    //s += Environment.NewLine;
                    //s += NoOfMonth_int + " - " + NameOfMonth_string + Environment.NewLine;
                    //s += NoOfDay_int + Environment.NewLine;
                    s += Environment.NewLine;
                    //s += dumpOfDay; // burayı kaldırdım, geçen senenin hicri rumi si geliyordu
                    s += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2021";
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    // Harun - yeni ekleme bitti!

                    //s += this.array[0, j, k].Name_Day_string + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu değiştirdim. 01 olmasın.
                    //s += this.array[0, j, k].Name_Day_int + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu da kapatıyorum, artık fazla

                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    set4City_of_IPOPLine = new HashSet<IPOPLine_Times_WithDayMonthCity>();

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Şanlıurfa":
                                cityNameTitleCase = "Şanlı Urfa";
                                break;

                            case "Kahramanmaraş":
                                cityNameTitleCase = "K.Maraş";
                                break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        if (this.set4City_of_string.Contains(cityName)) // ANKARA, İZMİR, BURSA -> 1.inci Bölge
                        {
                            // Buraya 4 il girecek

                            set4City_of_IPOPLine.Add(array[i, j, k]);

                        }
                        else
                        {
                            // Buraya 25 il girecek

                            s += cityNameTitleCase + "\t";
                            s += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                        }
                    }

                    s += Environment.NewLine;
                    //s += Environment.NewLine;

                    s += ToTableString_4City_DuzDeneme() + Environment.NewLine;

                    s += Environment.NewLine;

                    s += "*************   gün sonu   *************" + Environment.NewLine;

                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;
                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";
            }
            s += Environment.NewLine;
        }

        public void FinalResult_WriteAYear_MonthDayCity_Duvar_4_24_ayri() // Duvar için
        {
            string s = "";
            string s_4_sehir = "";
            string s_24_sehir = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2020" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                s_4_sehir += "*******************************************************" + Environment.NewLine;
                s_4_sehir += this.array[0, j, 0].Name_Month + " 2020" + Environment.NewLine;
                s_4_sehir += "*******************************************************" + Environment.NewLine;
                s_4_sehir += Environment.NewLine;
                s_4_sehir += Environment.NewLine;

                s_24_sehir += "*******************************************************" + Environment.NewLine;
                s_24_sehir += this.array[0, j, 0].Name_Month + " 2020" + Environment.NewLine;
                s_24_sehir += "*******************************************************" + Environment.NewLine;
                s_24_sehir += Environment.NewLine;
                s_24_sehir += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s += Environment.NewLine;
                    s += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2020";
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2020";
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;

                    s_24_sehir += Environment.NewLine;
                    s_24_sehir += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s_24_sehir += Environment.NewLine;
                    s_24_sehir += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2020";
                    s_24_sehir += Environment.NewLine;
                    s_24_sehir += Environment.NewLine;

                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    s_24_sehir += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s_24_sehir += "-----------------------------------------------------" + Environment.NewLine;

                    set4City_of_IPOPLine = new HashSet<IPOPLine_Times_WithDayMonthCity>();

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Şanlıurfa":
                                cityNameTitleCase = "Şanlı Urfa";
                                break;

                            case "Kahramanmaraş":
                                cityNameTitleCase = "K.Maraş";
                                break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        if (this.set4City_of_string.Contains(cityName)) // ANKARA, İZMİR, BURSA -> 1.inci Bölge
                        {
                            // Buraya 4 il girecek

                            set4City_of_IPOPLine.Add(array[i, j, k]);

                        }
                        else
                        {
                            // Buraya 24 il girecek

                            s += cityNameTitleCase + "\t";
                            s += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;

                            s_24_sehir += cityNameTitleCase + "\t";
                            s_24_sehir += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;

                        }
                    }

                    s += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_24_sehir += Environment.NewLine;

                    s += ToTableString_4City_DuzDeneme() + Environment.NewLine;
                    s += Environment.NewLine;

                    s_4_sehir += ToTableString_4City_DuzDeneme() + Environment.NewLine;
                    s_4_sehir += Environment.NewLine;

                    s += "*************   gün sonu   *************" + Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    s_4_sehir += "*************   gün sonu   *************" + Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;

                    s_24_sehir += "*************   gün sonu   *************" + Environment.NewLine;
                    s_24_sehir += Environment.NewLine;
                    s_24_sehir += Environment.NewLine;
                    s_24_sehir += Environment.NewLine;

                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                s_4_sehir += Environment.NewLine;
                s_4_sehir += Environment.NewLine;

                s_24_sehir += Environment.NewLine;
                s_24_sehir += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;

                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";

                File.WriteAllText(this.stringOPDirectoryPath + monthName + "_4_sehir" + ".txt", s_4_sehir);
                s_4_sehir = "";

                File.WriteAllText(this.stringOPDirectoryPath + monthName + "_24_sehir" + ".txt", s_24_sehir);
                s_24_sehir = "";

            }
            // bu aşağıdaki tek satır ne işe yarıyordu? Methon sonu! Döngü sonu değil!
            s += Environment.NewLine;
            s_4_sehir += Environment.NewLine;
            s_24_sehir += Environment.NewLine;

        }

        private string ToTableString_4City_DuzDeneme()
        {
            string s = "";
            string cityName;
            string cityNameTitleCase;




            // --------------------------------------------------------------------------------
            // 1. Alfabetik sıralamada.. Bir şehir, bir satıra..
            // --------------------------------------------------------------------------------

            bool write_AlphabeticalOrder_OneCity_OneLine = false;
            if (write_AlphabeticalOrder_OneCity_OneLine)
            {
                s += Environment.NewLine;
                s += "*** 1. Alfabetik sıralamada.. Bir şehir, bir satıra.. ***" + Environment.NewLine;

                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                    s += cityNameTitleCase + "\t";
                    s += item.ToString_Times_WithoutKible() + Environment.NewLine;
                }
                s += "*** 1. Alfabetik sıralamada.. Bir şehir, bir satıra.. son.. ***" + Environment.NewLine;
                s += Environment.NewLine;
            }





            // --------------------------------------------------------------------------------
            // 2. Alfabetik sıralamada.. Bir şehir, bir sütuna..
            // --------------------------------------------------------------------------------

            bool write_AlphabeticalOrder_OneCity_OneColumn = false;
            if (write_AlphabeticalOrder_OneCity_OneColumn)
            {
                s += Environment.NewLine;
                s += "*** 2. Alfabetik sıralamada.. Bir şehir, bir sütuna.. ***" + Environment.NewLine;
                s += Environment.NewLine;

                //Şehir isimlerini bastır            
                s += "\t\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                    s += cityNameTitleCase + "\t";
                }
                s += Environment.NewLine;

                s += "İmsak" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x1_imsak + "\t";
                }
                s += Environment.NewLine;

                s += "Güneş" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x2_gunes + "\t";
                }
                s += Environment.NewLine;

                s += "Öğle" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x3_oylen + "\t";
                }
                s += Environment.NewLine;

                s += "İkindi" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x4_ikindi + "\t";
                }
                s += Environment.NewLine;

                s += "Akşam" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x5_aksam + "\t";
                }
                s += Environment.NewLine;

                s += "Yatsı" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x6_yatsi + "\t";
                }
                s += Environment.NewLine;

                s += Environment.NewLine;
                s += "*** 2. Alfabetik sıralamada.. Bir şehir, bir sütuna.. son..***" + Environment.NewLine;
                s += Environment.NewLine;
            }





            //--- şimdi istenilen sıralamada olacak 4 elemanlı array'ı doldur ------------------

            IPOPLine_Times_WithDayMonthCity[] arr_IPOPLine4 = new IPOPLine_Times_WithDayMonthCity[4];

            foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
            {
                // bölge 1 değil! Her 3 bölge için de bu çalışıyor, yetiyor! 2019 dan kalma, 2020 ye de tam oldu, çok şükür!
                switch (item.Name_City)
                {
                    case "İSTANBUL":
                        arr_IPOPLine4[0] = item;
                        break;
                    case "ANKARA":
                        arr_IPOPLine4[1] = item;
                        break;
                    case "İZMİR":
                        arr_IPOPLine4[2] = item;
                        break;
                    case "BURSA":
                    case "SAMSUN":
                    case "DİYARBAKIR":
                        arr_IPOPLine4[3] = item;
                        break;
                    default:
                        //Console.WriteLine("Other");
                        break;
                }


                //// bölge 2 - SİL artık ihtiyaç kalmadı. zaten bunu istememişler
                //switch (item.Name_City)
                //{
                //    case "İSTANBUL":
                //        arr_IPOPLine4[0] = item;
                //        break;
                //    case "ANKARA":
                //        arr_IPOPLine4[1] = item;
                //        break;
                //    case "SAMSUN":
                //        arr_IPOPLine4[2] = item;
                //        break;
                //    case "KAYSERİ":
                //        arr_IPOPLine4[3] = item;
                //        break;
                //    default:
                //        //Console.WriteLine("Other");
                //        break;
                //}


                //// bölge 3 - SİL artık ihtiyaç kalmadı. zaten bunu istememişler
                //switch (item.Name_City)
                //{
                //    case "İSTANBUL":
                //        arr_IPOPLine4[0] = item;
                //        break;
                //    case "ANKARA":
                //        arr_IPOPLine4[1] = item;
                //        break;
                //    case "ADANA":
                //        arr_IPOPLine4[2] = item;
                //        break;
                //    case "DİYARBAKIR":
                //        arr_IPOPLine4[3] = item;
                //        break;
                //    default:
                //        //Console.WriteLine("Other");
                //        break;
                //}



            }



            // --------------------------------------------------------------------------------
            // 3. İstenilen sıralamada.. Bir şehir, bir satıra..
            // --------------------------------------------------------------------------------

            bool write_RequestedOrder_OneCity_OneColumn = true;
            if (write_RequestedOrder_OneCity_OneColumn)
            {
                // Bu çıktı istedikleri çıktı.. Yanlış çalışıyor. 
                // Fakat onların programı da yanlış istediği için, bu uyuyor! garip!

                //s += Environment.NewLine + "versiyon 4 - 3. İstenilen sıralamada.. Bir şehir, bir satıra..";
                s += Environment.NewLine + Environment.NewLine;

                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                    s += cityNameTitleCase + "\t";
                    s += item.ToString_Times_WithoutKible() + Environment.NewLine;
                }

                s += Environment.NewLine;
                //s += "versiyon 4 - son" + Environment.NewLine;


            }





            // --------------------------------------------------------------------------------
            // 4. İstenilen sıralamada.. Bir şehir, bir sütuna..
            // --------------------------------------------------------------------------------

            bool write_RequestedOrder_OneCity_OneLine = false;
            if (write_RequestedOrder_OneCity_OneLine)
            {
                s += Environment.NewLine;
                s += "*** 4. İstenilen sıralamada.. Bir şehir, bir sütuna.. ***" + Environment.NewLine;
                s += Environment.NewLine;

                //Şehir isimlerini bastır            
                //s += "\t\t";
                s += "Vakitler\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                    s += cityNameTitleCase + "\t";
                }
                s += Environment.NewLine;

                s += "İmsak" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    s += item.x1_imsak + "\t";
                }
                s += Environment.NewLine;

                s += "Güneş" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    s += item.x2_gunes + "\t";
                }
                s += Environment.NewLine;

                s += "Öğle" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    s += item.x3_oylen + "\t";
                }
                s += Environment.NewLine;

                s += "İkindi" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    s += item.x4_ikindi + "\t";
                }
                s += Environment.NewLine;

                s += "Akşam" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    s += item.x5_aksam + "\t";
                }
                s += Environment.NewLine;

                s += "Yatsı" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    s += item.x6_yatsi + "\t";
                }
                s += Environment.NewLine;

                s += Environment.NewLine;
                s += "*** 4. İstenilen sıralamada.. Bir şehir, bir sütuna.. ***" + Environment.NewLine;
                s += Environment.NewLine;
            }



            return s;
        }



        // --- Almanya -----------------------------------------------------------------------------------------------

        public void FinalResult_WriteAYear_MonthDayCity_Duvar_Almanya() // Duvar için
        {
            string s = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2020" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s += Environment.NewLine;
                    s += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2020";
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    set4City_of_IPOPLine = new HashSet<IPOPLine_Times_WithDayMonthCity>();

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Bıelefeld":
                                cityNameTitleCase = "Bielefeld";
                                break;

                            case "Duısburg":
                                cityNameTitleCase = "Duisburg";
                                break;

                            case "Freıburg":
                                cityNameTitleCase = "Freiburg";
                                break;

                            case "Gelsenkırchen":
                                cityNameTitleCase = "Gelsenkirchen";
                                break;

                            case "Lınz":
                                cityNameTitleCase = "Linz";
                                break;

                            case "Ludenscheıd":
                                cityNameTitleCase = "Ludenscheid";
                                break;

                            case "Maınz":
                                cityNameTitleCase = "Mainz";
                                break;

                            case "Mannheım":
                                cityNameTitleCase = "Mannheim";
                                break;

                            case "Montbelıard":
                                cityNameTitleCase = "Montbeliard";
                                break;

                            case "Osnabruck":
                                cityNameTitleCase = "Osnabrück";
                                break;

                            case "Parıs":
                                cityNameTitleCase = "Paris";
                                break;

                            case "Dusseldorf":
                                cityNameTitleCase = "Düsseldorf";
                                break;

                            case "Koln":
                                cityNameTitleCase = "Köln";
                                break;

                            case "Munchen":
                                cityNameTitleCase = "München";
                                break;

                            //case "Wuppertal":
                            //    cityNameTitleCase = "Wüppertal";
                            //    break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        if (this.set4City_of_string.Contains(cityName)) // ANKARA, İZMİR, BURSA -> 1.inci Bölge
                        {
                            // Buraya 4 il girecek

                            set4City_of_IPOPLine.Add(array[i, j, k]);

                        }
                        else
                        {
                            // Buraya 25 il girecek

                            s += cityNameTitleCase + "\t";
                            s += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                        }
                    }

                    s += Environment.NewLine;
                    //s += Environment.NewLine;

                    s += ToTableString_4City_DuzDeneme_Almanya() + Environment.NewLine;

                    s += Environment.NewLine;

                    s += "*************   gün sonu   *************" + Environment.NewLine;

                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;
                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";
            }
            s += Environment.NewLine;
        }

        public void FinalResult_WriteAYear_MonthDayCity_Duvar_Almanya_4_27_sehirler() // Duvar için
        {
            string s = "";
            string s_4_sehir = "";
            string s_27_sehir = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2020" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                s_4_sehir += "*******************************************************" + Environment.NewLine;
                s_4_sehir += this.array[0, j, 0].Name_Month + " 2020" + Environment.NewLine;
                s_4_sehir += "*******************************************************" + Environment.NewLine;
                s_4_sehir += Environment.NewLine;
                s_4_sehir += Environment.NewLine;

                s_27_sehir += "*******************************************************" + Environment.NewLine;
                s_27_sehir += this.array[0, j, 0].Name_Month + " 2020" + Environment.NewLine;
                s_27_sehir += "*******************************************************" + Environment.NewLine;
                s_27_sehir += Environment.NewLine;
                s_27_sehir += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    s += Environment.NewLine;
                    s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s += Environment.NewLine;
                    s += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2020";
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2020";
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;

                    s_27_sehir += Environment.NewLine;
                    s_27_sehir += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    s_27_sehir += Environment.NewLine;
                    s_27_sehir += (NoOfDay_int + 1) + " " + NameOfMonth_string + " 2020";
                    s_27_sehir += Environment.NewLine;
                    s_27_sehir += Environment.NewLine;


                    s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s += "-----------------------------------------------------" + Environment.NewLine;

                    s_27_sehir += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    s_27_sehir += "-----------------------------------------------------" + Environment.NewLine;

                    set4City_of_IPOPLine = new HashSet<IPOPLine_Times_WithDayMonthCity>();

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                        switch (cityNameTitleCase)
                        {
                            case "Bıelefeld":
                                cityNameTitleCase = "Bielefeld";
                                break;

                            case "Duısburg":
                                cityNameTitleCase = "Duisburg";
                                break;

                            case "Freıburg":
                                cityNameTitleCase = "Freiburg";
                                break;

                            case "Gelsenkırchen":
                                cityNameTitleCase = "Gelsenkirchen";
                                break;

                            case "Lınz":
                                cityNameTitleCase = "Linz";
                                break;

                            case "Ludenscheıd":
                                cityNameTitleCase = "Ludenscheid";
                                break;

                            case "Maınz":
                                cityNameTitleCase = "Mainz";
                                break;

                            case "Mannheım":
                                cityNameTitleCase = "Mannheim";
                                break;

                            case "Montbelıard":
                                cityNameTitleCase = "Montbeliard";
                                break;

                            case "Osnabruck":
                                cityNameTitleCase = "Osnabrück";
                                break;

                            case "Parıs":
                                cityNameTitleCase = "Paris";
                                break;

                            case "Dusseldorf":
                                cityNameTitleCase = "Düsseldorf";
                                break;

                            case "Koln":
                                cityNameTitleCase = "Köln";
                                break;

                            case "Munchen":
                                cityNameTitleCase = "München";
                                break;

                            //case "Wuppertal":
                            //    cityNameTitleCase = "Wüppertal";
                            //    break;

                            default:
                                break;
                        }
                        //*********************************************************************

                        if (this.set4City_of_string.Contains(cityName)) // ANKARA, İZMİR, BURSA -> 1.inci Bölge
                        {
                            // Buraya 4 il girecek

                            set4City_of_IPOPLine.Add(array[i, j, k]);

                        }
                        else
                        {
                            // Buraya 27 il girecek

                            s += cityNameTitleCase + "\t";
                            s += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;

                            s_27_sehir += cityNameTitleCase + "\t";
                            s_27_sehir += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                        }
                    }

                    s += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_27_sehir += Environment.NewLine;

                    s += ToTableString_4City_DuzDeneme_Almanya() + Environment.NewLine;
                    s_4_sehir += ToTableString_4City_DuzDeneme_Almanya() + Environment.NewLine;

                    s += Environment.NewLine;
                    s += "*************   gün sonu   *************" + Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;

                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += "*************   gün sonu   *************" + Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;
                    s_4_sehir += Environment.NewLine;

                    s_27_sehir += Environment.NewLine;
                    s_27_sehir += "*************   gün sonu   *************" + Environment.NewLine;
                    s_27_sehir += Environment.NewLine;
                    s_27_sehir += Environment.NewLine;
                    s_27_sehir += Environment.NewLine;
                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                s_4_sehir += Environment.NewLine;
                s_4_sehir += Environment.NewLine;

                s_27_sehir += Environment.NewLine;
                s_27_sehir += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;

                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";

                File.WriteAllText(this.stringOPDirectoryPath + monthName + "_4_sehir" + ".txt", s_4_sehir);
                s_4_sehir = "";

                File.WriteAllText(this.stringOPDirectoryPath + monthName + "_27_sehir" + ".txt", s_27_sehir);
                s_27_sehir = "";
            }
            s += Environment.NewLine;
            s_4_sehir += Environment.NewLine;
            s_27_sehir += Environment.NewLine;
        }

        private string ToTableString_4City_DuzDeneme_Almanya()
        {
            string s = "";
            string cityName;
            string cityNameTitleCase;




            // --------------------------------------------------------------------------------
            // 1. Alfabetik sıralamada.. Bir şehir, bir satıra..
            // --------------------------------------------------------------------------------

            bool write_AlphabeticalOrder_OneCity_OneLine = true;
            if (write_AlphabeticalOrder_OneCity_OneLine)
            {
                s += Environment.NewLine;
                //s += "*** 1. Alfabetik sıralamada.. Bir şehir, bir satıra.. ***" + Environment.NewLine;

                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);


                    switch (cityNameTitleCase)
                    {

                        case "Dusseldorf":
                            cityNameTitleCase = "Düsseldorf";
                            break;

                        case "Koln":
                            cityNameTitleCase = "Köln";
                            break;

                        case "Munchen":
                            cityNameTitleCase = "München";
                            break;

                        default:
                            break;
                    }




                    s += cityNameTitleCase + "\t";
                    s += item.ToString_Times_WithoutKible() + Environment.NewLine;
                }
                //s += "*** 1. Alfabetik sıralamada.. Bir şehir, bir satıra.. son.. ***" + Environment.NewLine;
                s += Environment.NewLine;
            }





            // --------------------------------------------------------------------------------
            // 2. Alfabetik sıralamada.. Bir şehir, bir sütuna..
            // --------------------------------------------------------------------------------

            bool write_AlphabeticalOrder_OneCity_OneColumn = false;
            if (write_AlphabeticalOrder_OneCity_OneColumn)
            {
                s += Environment.NewLine;
                s += "*** 2. Alfabetik sıralamada.. Bir şehir, bir sütuna.. ***" + Environment.NewLine;

                //Şehir isimlerini bastır            
                s += "\t\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);


                    switch (cityNameTitleCase)
                    {

                        case "Dusseldorf":
                            cityNameTitleCase = "Düsseldorf";
                            break;

                        case "Koln":
                            cityNameTitleCase = "Köln";
                            break;

                        case "Munchen":
                            cityNameTitleCase = "München";
                            break;

                        default:
                            break;
                    }


                    s += cityNameTitleCase + "\t";
                }
                s += Environment.NewLine;

                s += "İmsak" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x1_imsak + "\t";
                }
                s += Environment.NewLine;

                s += "Güneş" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x2_gunes + "\t";
                }
                s += Environment.NewLine;

                s += "Öğle" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x3_oylen + "\t";
                }
                s += Environment.NewLine;

                s += "İkindi" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x4_ikindi + "\t";
                }
                s += Environment.NewLine;

                s += "Akşam" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x5_aksam + "\t";
                }
                s += Environment.NewLine;

                s += "Yatsı" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x6_yatsi + "\t";
                }

                s += Environment.NewLine;
                s += "*** 2. Alfabetik sıralamada.. Bir şehir, bir sütuna.. son..***" + Environment.NewLine;
                s += Environment.NewLine;
            }

            return s;
        }



        // --- Avustralya

        public void FinalResult_WriteAYear_MonthDayCity_Duvar_Avustralya() // Duvar için
        {
            string s = "";

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            int j = 0;
            int k = 0;
            int i = 0;

            for (j = 0; j < 12; j++)
            {
                s += "*******************************************************" + Environment.NewLine;
                s += this.array[0, j, 0].Name_Month + " 2019" + Environment.NewLine;
                s += "*******************************************************" + Environment.NewLine;
                s += Environment.NewLine;
                s += Environment.NewLine;

                for (k = 0; k < 31; k++)
                {
                    if (this.array[0, j, k] == null) break;

                    // Harun - yeni ekleme başladı!

                    string NameOfMonth_string = this.array[0, j, k].Name_Month;
                    int NoOfMonth_int = singleton.getMonthNumber_int(NameOfMonth_string);

                    int NoOfDay_int = this.array[0, j, k].Name_Day_int - 1;

                    // Harun

                    //singleton.year.listOf_HRM_Page_Month[11].listOf_HRM_Line_Day[0].ToString_Dump_All_Gets();

                    s += Environment.NewLine;
                    //s += "*** ------------------- GÜN BAŞI ------------------------------ ***" + Environment.NewLine;
                    //s += Environment.NewLine;
                    //s += NoOfMonth_int + " - " + NameOfMonth_string + Environment.NewLine;
                    //s += NoOfDay_int + Environment.NewLine;
                    s += Environment.NewLine;
                    // burada bu satırı sildim: s += singleton.year.listOf_HRM_Page_Month[NoOfMonth_int].listOf_HRM_Line_Day[NoOfDay_int].get_Miladi_without_Miladi();
                    //s += Environment.NewLine;

                    // Harun - yeni ekleme bitti!

                    //s += this.array[0, j, k].Name_Day_string + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu değiştirdim. 01 olmasın.
                    //s += this.array[0, j, k].Name_Day_int + " " + this.array[0, j, k].Name_Month + Environment.NewLine + Environment.NewLine; // bunu da kapatıyorum, artık fazla

                    //s += "Şehir\tİmsak\tGüneş\tÖğlen\tİkindi\tAkşam\tYatsı" + Environment.NewLine;
                    //s += "-----------------------------------------------------" + Environment.NewLine;

                    set4City_of_IPOPLine = new HashSet<IPOPLine_Times_WithDayMonthCity>();

                    for (i = 0; i < numberOfCities; i++)
                    {
                        //*********************************************************************
                        string cityName = this.array[i, j, k].Name_City;
                        string cityNameTitleCase;

                        cityNameTitleCase = textInfo.ToLower(cityName);
                        cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);


                        //*********************************************************************

                        if (this.set4City_of_string.Contains(cityName)) // ANKARA, İZMİR, BURSA -> 1.inci Bölge
                        {
                            // Buraya 8 il girecek

                            set4City_of_IPOPLine.Add(array[i, j, k]);

                        }
                        else
                        {
                            // Buraya 25 il girecek

                            s += cityNameTitleCase + "\t";
                            s += this.array[i, j, k].ToString_Times_WithoutKible() + Environment.NewLine;
                        }
                    }

                    s += Environment.NewLine;
                    //s += Environment.NewLine;

                    s += ToTableString_4City_DuzDeneme_Avustralya() + Environment.NewLine;

                    s += Environment.NewLine;

                    //s += "*************   gün sonu   *************" + Environment.NewLine;

                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                }

                s += Environment.NewLine;
                s += Environment.NewLine;

                string monthName = this.array[0, j, 0].Name_Month;
                File.WriteAllText(this.stringOPDirectoryPath + monthName + ".txt", s);
                s = "";
            }
            s += Environment.NewLine;
        }

        private string ToTableString_4City_DuzDeneme_Avustralya()
        {
            string s = "";
            string cityName;
            string cityNameTitleCase;




            // --------------------------------------------------------------------------------
            // 1. Alfabetik sıralamada.. Bir şehir, bir satıra..
            // --------------------------------------------------------------------------------

            bool write_AlphabeticalOrder_OneCity_OneLine = false;
            if (write_AlphabeticalOrder_OneCity_OneLine)
            {
                s += Environment.NewLine;
                s += "*** 1. Alfabetik sıralamada.. Bir şehir, bir satıra.. ***" + Environment.NewLine;

                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);


                    switch (item.Name_City.Trim())
                    {

                        case "ADELAIDE":
                            cityNameTitleCase = "Adelaide";
                            break;

                        case "BRISBANE":
                            cityNameTitleCase = "Brisbane";
                            break;

                        case "DARWIN":
                            cityNameTitleCase = "Darwin";
                            break;

                        default:
                            break;
                    }




                    s += cityNameTitleCase + "\t";
                    s += item.ToString_Times_WithoutKible() + Environment.NewLine;
                }
                s += "*** 1. Alfabetik sıralamada.. Bir şehir, bir satıra.. son.. ***" + Environment.NewLine;
                s += Environment.NewLine;
            }





            // --------------------------------------------------------------------------------
            // 2. Alfabetik sıralamada.. Bir şehir, bir sütuna..
            // --------------------------------------------------------------------------------

            bool write_AlphabeticalOrder_OneCity_OneColumn = false;
            if (write_AlphabeticalOrder_OneCity_OneColumn)
            {
                s += Environment.NewLine;
                s += "*** 2. Alfabetik sıralamada.. Bir şehir, bir sütuna.. ***" + Environment.NewLine;

                //Şehir isimlerini bastır            
                s += "\t\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);


                    switch (item.Name_City.Trim())
                    {

                        case "ADELAIDE":
                            cityNameTitleCase = "Adelaide";
                            break;

                        case "BRISBANE":
                            cityNameTitleCase = "Brisbane";
                            break;

                        case "DARWIN":
                            cityNameTitleCase = "Darwin";
                            break;

                        default:
                            break;
                    }


                    s += cityNameTitleCase + "\t";
                }
                s += Environment.NewLine;

                s += "İmsak" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x1_imsak + "\t";
                }
                s += Environment.NewLine;

                s += "Güneş" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x2_gunes + "\t";
                }
                s += Environment.NewLine;

                s += "Öğle" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x3_oylen + "\t";
                }
                s += Environment.NewLine;

                s += "İkindi" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x4_ikindi + "\t";
                }
                s += Environment.NewLine;

                s += "Akşam" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x5_aksam + "\t";
                }
                s += Environment.NewLine;

                s += "Yatsı" + "\t";
                foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
                {
                    s += item.x6_yatsi + "\t";
                }

                s += Environment.NewLine;
                s += "*** 2. Alfabetik sıralamada.. Bir şehir, bir sütuna.. son..***" + Environment.NewLine;
                s += Environment.NewLine;
            }




            //--- şimdi istenilen sıralamada olacak 4 elemanlı array'ı doldur ------------------

            IPOPLine_Times_WithDayMonthCity[] arr_IPOPLine4 = new IPOPLine_Times_WithDayMonthCity[8];

            foreach (IPOPLine_Times_WithDayMonthCity item in set4City_of_IPOPLine)
            {
                switch (item.Name_City)
                {
                    case "MELBOURNE":
                        arr_IPOPLine4[0] = item;
                        break;
                    case "SYDNEY":
                        arr_IPOPLine4[1] = item;
                        break;
                    case "ADELAIDE":
                        arr_IPOPLine4[2] = item;
                        break;
                    case "BRISBANE":
                        arr_IPOPLine4[3] = item;
                        break;
                    case "PERTH":
                        arr_IPOPLine4[4] = item;
                        break;
                    case "DARWIN":
                        arr_IPOPLine4[5] = item;
                        break;
                    case "CANBERRA":
                        arr_IPOPLine4[6] = item;
                        break;
                    case "HOBART":
                        arr_IPOPLine4[7] = item;
                        break;

                    default:
                        throw new Exception("Bu şehir de nereden çıktı: " + item.Name_City);
                        //break;
                }
            }





            // --------------------------------------------------------------------------------
            // 3. İstenilen sıralamada.. Bir şehir, bir satıra..
            // --------------------------------------------------------------------------------

            bool write_RequestedOrder_OneCity_OneColumn = true;
            if (write_RequestedOrder_OneCity_OneColumn)
            {
                // Bu çıktı istedikleri çıktı.. Yanlış çalışıyor. 
                // Fakat onların programı da yanlış istediği için, bu uyuyor! garip!

                //s += Environment.NewLine + "versiyon 4 - 3. İstenilen sıralamada.. Bir şehir, bir satıra.." +
                //    Environment.NewLine + Environment.NewLine;

                foreach (IPOPLine_Times_WithDayMonthCity item in arr_IPOPLine4)
                {
                    cityName = item.Name_City;
                    cityNameTitleCase = textInfo.ToLower(cityName);
                    cityNameTitleCase = textInfo.ToTitleCase(cityNameTitleCase);

                    switch (item.Name_City.Trim())
                    {

                        case "ADELAIDE":
                            cityNameTitleCase = "Adelaide";
                            break;

                        case "BRISBANE":
                            cityNameTitleCase = "Brisbane";
                            break;

                        case "DARWIN":
                            cityNameTitleCase = "Darwin";
                            break;

                        default:
                            break;
                    }

                    s += cityNameTitleCase + "\t";
                    s += item.ToString_Times_WithoutKible() + Environment.NewLine;
                }

                //s += Environment.NewLine + "versiyon 4 - son" + Environment.NewLine;
            }








            return s;
        }

        // ---

        public void JustDisplayTheArrayForOutput()
        {

            // input for array   : city -> month -> day (i, j, k)
            // output from array : month -> day -> city

            // iç içe 3 tane for
            // if (null) continue veya break!

            int j = 0;
            int k = 0;
            int i = 0;

            Console.WriteLine();

            for (j = 0; j < 12; j++)
            {
                Console.WriteLine(this.array[0, j, 0].Name_Month);
            }
            Console.WriteLine();

            for (k = 0; k < 31; k++)
            {
                Console.WriteLine(this.array[0, 0, k].Name_Day_string);
            }
            Console.WriteLine();

            int numberOfCities;
            numberOfCities = this.ipDirectory.numberOfFiles;

            //for (i = 0; i < 22; i++)
            for (i = 0; i < numberOfCities; i++)
            {
                Console.WriteLine(this.array[i, 0, 0].Name_City);
            }
        }
    }
}