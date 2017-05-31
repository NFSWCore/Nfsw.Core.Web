using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class ReportingController : Controller
    {
        [HttpPost("SendHardwareInfo")]
        public string SendHardwareInfo([FromBody]HardwareInfo hardwareInfo)
        {
            // todo log user hardware
            // for banning or each other
            return "";
        }

        [HttpPost("SendUserSettings")]
        public string SendUserSettings([FromBody]UserSettings userSettings)
        {
            // todo store user setting in database
            return "";
        }
    }
}