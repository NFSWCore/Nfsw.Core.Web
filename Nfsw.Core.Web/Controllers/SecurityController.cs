using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class SecurityController : Controller
    {
        /// <summary>
        /// GET http://localhost:7331/Engine.svc/security/fraudConfig
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("fraudConfig")]
        public FraudConfig FraudConfig(long userId)
        {
            return new FraudConfig()
            {
                EnabledBitField = 12,
                GameFileFreq = 1000000,
                ModuleFreq = 360000,
                StartUpFreq = 1000000,
                UserID = userId
            };
        }
    }
}