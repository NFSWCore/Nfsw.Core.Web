using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nfsw.Core.Common.Database;
using System.Collections.Generic;
using System.Linq;
using Victory.DataLayer.Serialization;
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
        public UserInfo GetPermanentSession([FromBody]GetPermanentSessionData permanentSessionData)
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
                    {
                        new PersonaCCar()
                        {
                            Ccid = 1,
                            Durability = 100,
                            Heat = 0,
                            IsDefault = true,
                            PersonaId = 1
                        }
                    }
                };
                profiles.Add(profile);
            }

            //uinfo.DefaultPersonaIdx = user.id;
            uinfo.Personas = profiles;
            uinfo.User = new User()
            {
                UserId = user.id,
                RemoteUserId = 1000000000001L,
                SecurityToken = user.security_token,
                Email = user.email,
                FullGameAccess = true,
                StarterPackEntitlementTag = "NFSW_STARTER_PACK_A",
                SubscribeMsg = false,

            };

            return uinfo;
        }

        /// <summary>
        /// POST Engine.svc/User/SecureLoginPersona
        /// </summary>
        /// <returns></returns>
        [HttpPost("SecureLoginPersona")]
        public string SecureLoginPersona(long personaId)
        {
            var securityToken = HttpContext.Request.Headers["securityToken"];
            var userId = long.Parse(HttpContext.Request.Headers["userId"]);

            // todo set active session personaId by userid or securityToken

            return "";
        }

        /// <summary>
        /// POST Engine.svc/User/SecureLogoutPersona
        /// </summary>
        /// <returns></returns>
        [HttpPost("SecureLogoutPersona")]
        public string SecureLogoutPersona()
        {
            // todo delete active session persona

            return "";
        }

        /// <summary>
        /// POST Engine.svc/User/SecureLogout
        /// </summary>
        /// <returns></returns>
        [HttpPost("SecureLogout")]
        public string SecureLogout(long userId, long personaId, int exitCode)
        {
            _logger.LogInformation($"SecureLogout - userId:{userId}, personaId:{personaId},exitCode:{exitCode}");

            // todo delete active session persona

            return "";
        }
    }
}
