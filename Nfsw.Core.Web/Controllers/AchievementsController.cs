using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nfsw.Core.Common.Database;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class AchievementsController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger _logger;
        /// <summary>
        /// 
        /// </summary>
        private NfswDbContext _DB;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="logger"></param>
        public AchievementsController(NfswDbContext _dbContext, ILogger<UserController> logger)
        {
            _logger = logger;
            _DB = _dbContext;
            _DB.Database.EnsureCreated();
        }

        [HttpGet("loadall")]
        public string LoadAll()
        {
            //todo Load Achievements from database

            return "";
        }
    }
}