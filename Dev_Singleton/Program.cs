using Lib_Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dev_Singleton Project!");

            //Singleton singleton = new Singleton();
            Singleton singleton = Singleton.Instance;

            for (int i = 0; i < singleton.MonthNames.Length; i++)
            {
                Console.WriteLine(singleton.MonthNames[i]);
            }
        }
    }
}
