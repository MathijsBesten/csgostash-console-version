using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NoGUI
{
    public class GetSkinName
    {
        public static string SkinName(string url)
        {
            int Start, End;
            using (WebClient client = new WebClient())
            {
                string urlData = client.DownloadString(url);
                if (urlData.Contains(PublicValues.defaultStartName) && urlData.Contains(PublicValues.defaultEndName))
                {
                    Start = urlData.IndexOf(PublicValues.defaultStartName, 0) + PublicValues.defaultStartName.Length;
                    End = urlData.IndexOf(PublicValues.defaultEndName, Start);
                    return urlData.Substring(Start, End - Start);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
