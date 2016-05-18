using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NoGUI
{
    public class GetAllSkins
    {
        public static List<string> allSkins(string subURL)
        {
            int id = 0;
            string url = "https://csgostash.com/weapon/" + subURL;
            var allSkinsList = new List<int>();
            using (WebClient client = new WebClient())
            {
                int Start, End;
                string urlData = client.DownloadString(url);
                Console.WriteLine("");
                foreach (Match m in Regex.Matches(urlData, PublicValues.defaultStartSkinInCategorie))
                {
                    allSkinsList.Add(m.Index);
                    Start = m.Index + m.Value.Length;
                    End = urlData.IndexOf("\"", Start);

                    var skinURL = urlData.Substring(Start, End-Start);
                    Console.WriteLine(skinURL + " - " + id);
                    PublicValues.skinURLs.Add(skinURL);
                    id++;
                }
            }
            return null;
        }
    }
}
