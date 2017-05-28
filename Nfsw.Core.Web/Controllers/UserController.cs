using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nfsw.Core.Common.Database;
using System;
using System.Collections.Generic;
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
        private UserDbContext _UserDB;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="logger"></param>
        public UserController(UserDbContext _dbContext, ILogger<UserController> logger)
        {
            _logger = logger;
            _UserDB = _dbContext;
            _UserDB.Database.EnsureCreated();
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
            uinfo.DefaultPersonaIdx = userId;

            // todo load profiles from database
            var profiles = new List<ProfileData>();
            profiles.Add(new ProfileData() {
                Name = "TEST",
                Cash = 9999999,
                Boost = 99999,
                IconIndex = 1,
                PersonaId = 1,
                Level = 1
            });
            uinfo.Personas = profiles;

            // todo load user data from database
            var user = new User();
            user.UserId = userId;
            user.SecurityToken = Guid.Parse(securityToken);
            user.FullGameAccess = true;
            user.LastAuthDate = DateTime.Now;
            uinfo.User = user;

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
