using System;
using System.Drawing;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Korean_Drama_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public HtmlNodeCollection searchDramaImage;
        public HtmlNodeCollection searchDramaUrls;
        public HtmlNodeCollection dramaEpisodeUrl;

        public string base_url = "https://www3.dramacool.movie";
        private void searchDrama()
        {
            try
            {
                listView_Search_Results.Items.Clear();
                ImageList images = new ImageList();
                images.ImageSize = new Size(245, 250);
                images.ColorDepth = ColorDepth.Depth32Bit;

                HtmlWeb searchDramaWeb = new HtmlWeb();
                searchDramaWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
                HtmlAgilityPack.HtmlDocument searchDramaResults = searchDramaWeb.Load($"{base_url}/search?type=movies&keyword={textBox_Search_Query.Text}");

                searchDramaImage = searchDramaResults.DocumentNode.SelectNodes("//img[@class='lazy']");
                searchDramaUrls = searchDramaResults.DocumentNode.SelectNodes("//h3[@class='title']");

                if (searchDramaUrls == null)
                    MessageBox.Show($"No results found for {textBox_Search_Query.Text}!", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    for (int i = 0; i < searchDramaUrls.Count; i++)
                    {
                        WebClient w = new WebClient();

                        byte[] imageBytes = w.DownloadData(searchDramaImage[i].Attributes["data-original"].Value);
                        MemoryStream memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length);
                        memoryStream.Write(imageBytes, 0, imageBytes.Length);
                        Image imgs = Image.FromStream(memoryStream, true);
                        images.Images.Add(imgs);

                        listView_Search_Results.Items.Add(searchDramaUrls[i].InnerText, i);

                    }
                    listView_Search_Results.LargeImageList = images;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Check if you have active internet connection or try with VPN!", "Error occurred",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Search_Query.Text != "")
            {
                Thread thread = new Thread(searchDrama);
                thread.Start();
                thread.IsBackground = true;
            }
            else
                MessageBox.Show("Search query cannot be empty!", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void listView_Search_Results_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                string selectedDramaUrl = $"{base_url}{searchDramaUrls[listView_Search_Results.FocusedItem.Index].Attributes["onclick"].Value.Replace("window.location = '", "").Replace("'", "")}";
                label_Selected_Drama_Title.Text = searchDramaUrls[listView_Search_Results.FocusedItem.Index].InnerText;
                PicBox_Selected_Drama.Load(searchDramaImage[listView_Search_Results.FocusedItem.Index].Attributes["data-original"].Value);

                panel_SearchUI.Visible = false;
                Panel_Episodes_List.Visible = true;

                HtmlWeb web = new HtmlWeb();
                web.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
                HtmlAgilityPack.HtmlDocument document = web.Load(selectedDramaUrl);

                dramaEpisodeUrl = document.DocumentNode.SelectNodes("/html/body/div[1]/div/div[1]/div[3]/div/div/ul/li[*]/a/h3");
                var dramaType = document.DocumentNode.SelectNodes("/html/body/div[1]/div/div[1]/div[3]/div/div/ul/li[/]/a/span[1]");

                for (int i = dramaEpisodeUrl.Count - 1; i >= 0; i--)
                {
                    listView_Episodes.Items.Add(dramaEpisodeUrl[i].InnerText + " " + dramaType[i].InnerText);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check if you have active internet connection or try with VPN!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            panel_SearchUI.Visible = true;
            Panel_Episodes_List.Visible = false;
            dramaEpisodeUrl.Clear();
            listView_Episodes.Items.Clear();
        }

        private void listView_Episodes_MouseClick(object sender, MouseEventArgs e)
        {
            int retifier = dramaEpisodeUrl.Count - 1;
            string selectedEpisodeUrl = $"{base_url}{dramaEpisodeUrl[retifier - listView_Episodes.FocusedItem.Index].Attributes["onclick"].Value.Replace("window.location = '", "").Replace("'", "")}";

            LinkResolver linkResolver = new LinkResolver();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            
            string augs = "--referer https://asianload1.com/";

            startInfo.FileName = Environment.CurrentDirectory + @"\\yt-dlp.exe";
            startInfo.Arguments = augs + " " + linkResolver.resolver(selectedEpisodeUrl) + " " + "--external-downloader aria2c --downloader-args aria2c: - x 16 - k 1M" + $" -o {"\""}/Downloads/{listView_Episodes.FocusedItem.Text}.%(ext)s{"\""}";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://henry-richard-tools.ml");
        }

        private void youtubeChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCVGasc5jr45eZUpZNHvbtWQ");
        }

        private void telegramChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/hr_tools");
        }        

        private void donationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cryptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://henry-richard7.github.io/Donation-Page/");
        }

        private void paypalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/paypalme/henryrics");
        }
    }
}
