using Google.Apis.CustomSearchAPI.v1.Data;
using Google.Apis.Services;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Text.RegularExpressions;

namespace SimpleEmailHarvester
{
    internal class Przegladarka
    {
        const string MatchEmailPattern = @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}";
        const string URLPattern = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w-./?%&=])?$";
        string html { get; set; }
        string ApiKeyJson { get; set; }
        string SearchEngineIdJson { get; set; }
        ListBox URLsListBox { get; set; }
        ListBox emailsListBox {  get; set; } 

        EdgeOptions options = new EdgeOptions();

        IWebDriver driver2;
        public Przegladarka() 
        {

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            ApiKeyJson = config.GetSection("AppConfig:ApiKey").Value;
            SearchEngineIdJson = config.GetSection("AppConfig:searchEngineId").Value;
            //options.AddArgument("--whitelisted-ips=''");


            ////IWebDriver driver2;
            //var chromeDriverService = EdgeDriverService.CreateDefaultService();
            //chromeDriverService.HideCommandPromptWindow = true;
            //var options = new EdgeOptions();
            //options.AddArgument("--whitelisted-ips=''");
            ////options.UseChromium = true;

            //driver2 = new EdgeDriver(chromeDriverService, options);
        }

        private void OpenDriver()
        {

            //IWebDriver driver2;
            var chromeDriverService = EdgeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var options = new EdgeOptions();
            options.AddArgument("--whitelisted-ips=''");
            //options.UseChromium = true;

            driver2 = new EdgeDriver(chromeDriverService, options);

        }

        public Przegladarka(ListBox url, ListBox emailsListBox)
        {
            this.URLsListBox = url;
            this.emailsListBox = emailsListBox;

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            ApiKeyJson = config.GetSection("AppConfig:ApiKey").Value;
            SearchEngineIdJson = config.GetSection("AppConfig:searchEngineId").Value;
            //options.AddArgument("--whitelisted-ips=''");


            //IWebDriver driver2;
            var chromeDriverService = EdgeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var options = new EdgeOptions();
            options.AddArgument("--whitelisted-ips=''");
            //options.UseChromium = true;

            driver2 = new EdgeDriver(chromeDriverService, options);
        }

        public void scanGoogleForUrls(string query, ListBox listBox)
        {
            var customSearchService = new Google.Apis.CustomSearchAPI.v1.CustomSearchAPIService(new BaseClientService.Initializer { ApiKey = ApiKeyJson });
            var listRequest = customSearchService.Cse.List();
            listRequest.Q = query;
            listRequest.Cx = SearchEngineIdJson;

            IList<Result> paging = new List<Result>();
            var count = 0;
            while (paging != null && count < 10)
            {
                listRequest.Start = count * 10 + 1;
                paging = listRequest.Execute().Items;
                if (paging != null)
                    foreach (var item in paging)
                    {
                        listBox.Items.Add(item.Link);
                        //URLsListBox.Items.Add(item.Link);
                    }
                count++;
            }
        }

        public void ScanURLsListBox(string query, ListBox listBox) 
        {
            OpenDriver();
            foreach (string url in URLsListBox.Items)
            {
                try
                {
                    driver2.Navigate().GoToUrl(url);

                    html = driver2.PageSource;

                    foreach (var emial in scanRegEx(MatchEmailPattern))
                    {
                        if (!emailsListBox.Items.Contains(emial))
                            emailsListBox.Items.Insert(0,emial);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            driver2.Quit();
        }

        private List<string> scanRegEx(string regexp)
        {
            // Create a regex object
            Regex urlRegex = new Regex(regexp, RegexOptions.IgnoreCase);

            // Find all email matches
            MatchCollection matchesCollection = urlRegex.Matches(html);

            List<string> result = new List<string>();

            if (matchesCollection.Count > 0)
            {
                foreach (var emial in matchesCollection)
                {
                    result.Add(emial.ToString());
                }
            }
            return result;
        }

        internal void stop()
        {
            //throw new NotImplementedException();
            //driver2.Quit();
        }
    }
}
