
using System.Net;
using System.Diagnostics;

namespace testssl
{


		public class testssl
		{


			public static void Main()
			{
			    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
			    Process.Start("powershell", "wget https://uk.sans.org/");
// Comment Fastly IP address start browsing
                Process.Start("powershell", "wget https://151.101.1.57/");
                Process.Start("iexplore", "https://www.microsoft.com/");
// Barclays IP address start browsing
                Process.Start("iexplore", "https://147.63.166.62/");
			    using (WebClient client = new WebClient())
			    {
				    string htmlCode = client.DownloadString("https://www.example.com");
// www.wormly.com IP address start browsing
                    string htmlCode2 = client.DownloadString("https://54.204.20.123");
			    }
			}
		}

}
