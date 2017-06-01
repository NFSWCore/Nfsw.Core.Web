using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class MatchmakingController : Controller
    {
        [HttpGet("launchevent/{eventId}")]
        public string LaunchEvent(int eventId)
        {
            Console.WriteLine($"LaunchEvent: eventId = {eventId}");

            return "";
        }
    }
}