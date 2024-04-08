

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Text.RegularExpressions;

namespace SimpleEmailHarvester
{
    public partial class SimpleEmailHarvesterForm : Form
    {
        public SimpleEmailHarvesterForm()
        {
            InitializeComponent();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/search?q=" + queryText.Text + "+emial");
            var html = driver.PageSource;

            Regex extractEmailsRegex = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)");
            emailsListBox.Items.Clear();
            var emialsArray =   extractEmailsRegex.Matches(html)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
            foreach ( var emial in emialsArray )
            {
                emailsListBox.Items.Add( emial);
            }
        }
    }
}
