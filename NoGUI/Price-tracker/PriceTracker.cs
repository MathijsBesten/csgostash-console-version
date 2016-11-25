using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace NoGUI.Price_tracker
{
    class PriceTracker
    {
        public static string skinURL;
        public static string gunName;
        public static string wear;
        public static decimal lowestMoney;
        public static bool firstRun = true;
        public static DateTime lowestDateTime;

        public static void mainPriceTracker()
        {
            Console.WriteLine("Met deze aplicatie kunt u de prijzen bijhouden van uw favorite CSGO skin");
            Console.WriteLine("Vul aub de csgostash.com skin url in");
            Console.WriteLine("Voorbeeld: https://csgostash.com/skin/680/PP-Bizon-Fuel-Rod");
            Console.WriteLine("Geeft skin url in:");
            skinURL = Console.ReadLine();
            if (skinURL.Contains("https://csgostash.com/skin/"))
            {
                Console.WriteLine("welke versie van het skin wilt u volgen?");
                Console.WriteLine("Voorbeeld: fn,mm,ft,ww,bs");
                wear = Console.ReadLine();
                if (wear == "fn" || wear == "mm" || wear == "ft" || wear == "ww" || wear == "bs")
                {
                    gunName = GetSkinName.SkinName(PriceTracker.skinURL);
                    System.Timers.Timer mainTimer = new System.Timers.Timer();
                    mainTimer.Elapsed += new ElapsedEventHandler(Tracker.getPrice);
                    mainTimer.Interval = 1000;
                    mainTimer.Enabled = true;
                }
                else
                {
                    Console.WriteLine("Dit is geen geldige wear waarde");
                    wear = null;
                    mainPriceTracker();
                }
            }
            else
            {
                Console.WriteLine("Dit is geen geldige skin url");
                skinURL = null;
                mainPriceTracker();
            }

            Console.ReadKey();
        }
    }
}
