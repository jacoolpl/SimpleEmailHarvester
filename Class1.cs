using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEmailHarvester
{
    public class WebSiteHtmlLoader : IDisposable
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        public WebSiteHtmlLoader(RemoteWebDriver remoteWebDriver)
        {
            if (remoteWebDriver == null) throw new ArgumentNullException("remoteWebDriver");
            _remoteWebDriver = remoteWebDriver;
        }

        public string GetRenderedHtml(Uri webSiteUri)
        {
            if (webSiteUri == null) throw new ArgumentNullException("webSiteUri");
            _remoteWebDriver.Navigate().GoToUrl(webSiteUri);

            return _remoteWebDriver.PageSource;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_remoteWebDriver != null)
                {
                    _remoteWebDriver.Quit();
                }
            }
        }
    }
}
