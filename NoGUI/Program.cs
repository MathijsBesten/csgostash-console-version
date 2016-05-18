using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using NoGUI.Price_tracker;

namespace NoGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom op de CS:GO Stash helper");
            Console.WriteLine("Welke Funtie wilt u gebruiken?");
            Console.WriteLine("Vul \"C\" in voor de klassieke CS:GO Stash website");
            Console.WriteLine("Vul \"T\" in voor de Real-time Price Tracker");
            Console.WriteLine("");
            string keuze = Console.ReadLine();
            if (keuze == "c" || keuze == "C")
            {
                SkinFunction.searchSkin();
            }
            else if(keuze == "t" || keuze == "T")
            {
                PriceTracker.mainPriceTracker();
            }
        }
    }
}
