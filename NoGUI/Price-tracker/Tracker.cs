﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NoGUI.Price_tracker
{
    class Tracker
    {
        public static void getPrice(object source, ElapsedEventArgs e)
        {
            if (DateTime.Now.Second == 00)
            {
                string priceString = GetDefaultPrices.getPrice(PriceTracker.skinURL, PublicValues.fn, PublicValues.defaultEndPrice);
                if (priceString.Contains("--"))
                {
                    priceString = priceString.Replace("--", "00");
                }
                decimal price = decimal.Parse(priceString);
                var dateTimeNow = DateTime.Now;
                if (!File.Exists(PublicValues.priceFile))
                {
                    FileStream fs = File.Create(PublicValues.priceFile);
                    fs.Close();
                }
                List<string> existingLines = File.ReadAllLines(PublicValues.priceFile).ToList();
                TextWriter tw = new StreamWriter(PublicValues.priceFile);
                if (existingLines.Count != 0 )
                {
                    if (existingLines[0] == PriceTracker.gunName)
                    {
                        foreach (var line in existingLines)
                        {
                            tw.WriteLine(line);
                        }
                    }
                }
                else
                {
                    tw.WriteLine(PriceTracker.gunName);
                }
               
                bool itIsLess = price < PriceTracker.lowestMoney;
                if (itIsLess == true || PriceTracker.firstRun == true)
                {
                    PriceTracker.lowestMoney = price;
                    PriceTracker.lowestDateTime = dateTimeNow;
                    Console.WriteLine("$"+PriceTracker.lowestMoney);
                    Console.WriteLine(PriceTracker.lowestDateTime);
                    tw.WriteLine("€" + PriceTracker.lowestMoney + " -Lowest Recorded-");
                    tw.WriteLine(PriceTracker.lowestDateTime + " -Lowest Recorded-");
                    tw.Close();
                    PriceTracker.firstRun = false;
                }
                else
                {
                    tw.WriteLine(price.ToString());
                    tw.WriteLine(DateTime.Now);
                    tw.Close();
                }
            }
        }
    }
}
