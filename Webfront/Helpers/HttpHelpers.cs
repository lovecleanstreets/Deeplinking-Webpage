using System;
using System.Net;
using System.Text;

namespace Webfront.Helpers
{
    public static class HttpHelpers
    {
        public static string DownloadData(string url)
        {
            using(WebClient myWebClient = new WebClient())
            {
                return Encoding.ASCII.GetString(myWebClient.DownloadData(url));
            }
        }
    }
}