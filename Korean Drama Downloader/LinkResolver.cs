using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;
namespace Korean_Drama_Downloader
{
    class LinkResolver
    {
        public string resolver(String Url)
        {
            string pattern = @"sources:\[\{file: '(.*)',label:";

            HtmlWeb web1 = new HtmlWeb();
            web1.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HtmlDocument document1 = web1.Load(Url);

            HtmlNode embedURL = document1.DocumentNode.SelectSingleNode("/html/body/div[1]/div/div[1]/div[2]/div[10]/ul/li[2]");
            string link = embedURL.Attributes["data-video"].Value;

            HtmlWeb web2 = new HtmlWeb();
            web1.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HtmlDocument document2 = web1.Load($"https:{link}");

            HtmlNode jsScriptNode = document2.DocumentNode.SelectSingleNode("/html/body/div/div/script");
            string jsScript = jsScriptNode.InnerText;

            Match m = Regex.Match(jsScript, pattern);
            return m.Groups[1].ToString();
        }
    }
}
