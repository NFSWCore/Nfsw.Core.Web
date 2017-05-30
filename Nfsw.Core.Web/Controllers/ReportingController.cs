using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class ReportingController : Controller
    {
        [HttpPost("SendHardwareInfo")]
        public string SendHardwareInfo()
        {
            var input = new StreamReader(Request.Body).ReadToEnd();

            Console.WriteLine(input);

            return "";
        }

        [HttpPost("SendUserSettings")]
        public string SendUserSettings()
        {
            var input = new StreamReader(Request.Body).ReadToEnd();

            Console.WriteLine(input);

            return "";
        }
    }
}