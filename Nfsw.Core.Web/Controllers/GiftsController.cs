using Microsoft.AspNetCore.Mvc;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class GiftsController : Controller
    {
        [HttpPost("GetAndTriggerAvailableLevelGifts")]
        public string GetAndTriggerAvailableLevelGifts()
        {
            return "";
        }
    }
}