using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages
{
    public class AboutModel : PageModel
    {
        public string OperatingSystem{get;set;}
        public string FrameworkDescription {get;set;}
        public string Architecture{get;set;}
        public string Hostname{get;set;}
        public List<string> IpAddresses{get;set;}
        public void OnGet()
        {
            FrameworkDescription = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            OperatingSystem = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            Architecture = System.Runtime.InteropServices.RuntimeInformation.OSArchitecture.ToString();
            Hostname = System.Net.Dns.GetHostName();
            IpAddresses = new List<string>();
            foreach(var ipAddress in System.Net.Dns.GetHostAddresses(Hostname))
            {
                IpAddresses.Add(ipAddress.ToString());
            }
        }
    }
}
