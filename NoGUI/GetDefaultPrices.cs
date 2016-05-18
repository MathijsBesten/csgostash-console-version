using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NoGUI
{
    public static class GetDefaultPrices
    {
        public static string getPrice(string url, string startString, string endString)
        {
            int Start, End;
            using (WebClient client = new WebClient())
            {
                string fullstring = client.DownloadString(url);
                if (fullstring.Contains(startString) && fullstring.Contains(endString))
                {
                    Start = fullstring.IndexOf(startString, 0) + startString.Length;
                    End = fullstring.IndexOf(endString, Start);
                    String finalString =  fullstring.Substring(Start, End - Start);
                    if (finalString.Contains("No Recent Price" ))
                    {
                        finalString = "No item in the market";
                    }
                    else if (finalString.Contains("Not Possible"))
                    {
                        finalString = "Condition not Possible";
                    }
                    return (finalString);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
