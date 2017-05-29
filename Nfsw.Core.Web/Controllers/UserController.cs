using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nfsw.Core.Common.Database;
using System.Collections.Generic;
using System.Linq;
using Victory.TransferObjects.DriverPersona;
using Victory.TransferObjects.User;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class UserController : Controller
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
        public UserController(NfswDbContext _dbContext, ILogger<UserController> logger)
        {
            _logger = logger;
            _DB = _dbContext;
            _DB.Database.EnsureCreated();
        }

        /// <summary>
        /// POST Engine.svc/User/GetPermanentSession
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetPermanentSession")]
        public UserInfo GetPermanentSession()
        {
            var securityToken = HttpContext.Request.Headers["securityToken"];
            var userId = long.Parse(HttpContext.Request.Headers["userId"]);

            UserInfo uinfo = new UserInfo();

            var user = _DB
                        .Users
                        .Where(x => x.id == userId)
                        .SingleOrDefault();

            if (user == null)
                return new UserInfo();

            var _profiles = _DB
                             .Profiles
                             .Where(x => x.userid == user.id)
                             .ToList();

            var profiles = new List<ProfileData>();

            foreach(var p in _profiles)
            {
                var profile = new ProfileData()
                {
                    Name = p.name,
                    Cash = p.cash,
                    Boost = p.boost,
                    IconIndex = p.icon_index,
                    PersonaId = p.id,
                    Level = p.level,
                    PercentToLevel = p.percent_to_level,
                    Rating = p.rating,
                    Rep = p.reputation,
                    RepAtCurrentLevel = p.rep_atcurrent_level,
                    Motto = p.motto,
                    ccar = new List<PersonaCCar>()
                };
                profiles.Add(profile);
            }

            uinfo.DefaultPersonaIdx = user.id;
            uinfo.Personas = profiles;
            uinfo.User = new User()
            {
                UserId = user.id,
                SecurityToken = user.security_token,
                Email = user.email,
                LastAuthDate = user.updated_at,
                Gender = (Gender)user.gender,
                FullGameAccess = true
            };

            return uinfo;
        }

        /// <summary>
        /// POST Engine.svc/User/SecureLoginPersona
        /// </summary>
        /// <returns></returns>
        [HttpPost("SecureLoginPersona")]
        public string SecureLoginPersona()
        {
            return string.Empty;
        }

        /// <summary>
        /// POST Engine.svc/User/SecureLogoutPersona
        /// </summary>
        /// <returns></returns>
        [HttpPost("SecureLogoutPersona")]
        public string SecureLogoutPersona()
        {
            return string.Empty;
        }

        /// <summary>
        /// POST Engine.svc/User/SecureLogout
        /// </summary>
        /// <returns></returns>
        [HttpPost("SecureLogout")]
        public string SecureLogout()
        {
            return string.Empty;
        }
    }
}
