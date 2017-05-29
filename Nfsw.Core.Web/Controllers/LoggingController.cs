using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Victory.DataLayer.Serialization;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class LoggingController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public LoggingController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet("client")]
        public ClientConfigTrans ClientConfigTrans()
        {
            return new ClientConfigTrans();
        }
    }
}