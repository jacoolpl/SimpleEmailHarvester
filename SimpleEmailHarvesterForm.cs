

using Google.Apis.CustomSearchAPI.v1;
using Google.Apis.CustomSearchAPI.v1.Data;
using Google.Apis.Services;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System.Configuration;
using System.Text.RegularExpressions;

using Microsoft.Extensions.Configuration.Json;

using System.Windows;
using System.Windows.Forms;



namespace SimpleEmailHarvester
{
    public partial class SimpleEmailHarvesterForm : Form, IDisposable
    {
        //IWebDriver driver1 = null;//new EdgeDriver();
        //EdgeOptions options = new EdgeOptions();


        //IWebDriver driver2 = new EdgeDriver();// { get; set; }
        string ApiKeyJson { get; set; }
        string SearchEngineIdJson { get; set; }

        Przegladarka przegladarka { get; set; }

        public static IConfiguration Config { get; private set; }


        const string MatchEmailPattern = @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}";
        const string URLPattern = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w-./?%&=])?$";



        string html = null;




        public SimpleEmailHarvesterForm()
        {
            InitializeComponent();
            przegladarka = new(URLsListBox, emailsListBox);

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            ApiKeyJson = config.GetSection("AppConfig:ApiKey").Value;
            SearchEngineIdJson = config.GetSection("AppConfig:searchEngineId").Value;
            //options.AddArgument("--whitelisted-ips=''");
        }

         private void scanButton_Click(object sender, EventArgs e)
        {
            przegladarka.scanGoogleForUrls(queryText.Text + "+email", URLsListBox);

            przegladarka.ScanURLsListBox(queryText.Text + "+email", URLsListBox);

            przegladarka.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //driver2.Navigate().GoToUrl("https://www.google.com/search?q=" + queryText.Text + "+emial");
            //driver.Navigate().GoToUrl(queryText.Text);
            //html = driver2.PageSource;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Create a StreamWriter to write to the CSV file (named "Myfile.csv")
            using (StreamWriter myOutputStream = new StreamWriter("Myfile.csv"))
            {
                foreach (var item in emailsListBox.Items)
                {
                    // Write each item to the CSV file
                    myOutputStream.WriteLine(item.ToString());
                }
            }
        }

        
    }
}
