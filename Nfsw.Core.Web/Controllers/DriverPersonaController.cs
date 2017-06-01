using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nfsw.Core.Common.Database;
using Nfsw.Core.Common.Structures;
using System;
using System.Collections.Generic;
using System.IO;
using Victory.Service.Objects;
using Victory.TransferObjects.DriverPersona;
using Victory.TransferObjects.User;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class DriverPersonaController : Controller
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
        public DriverPersonaController(NfswDbContext _dbContext, ILogger<UserController> logger)
        {
            _logger = logger;
            _DB = _dbContext;
            _DB.Database.EnsureCreated();
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/DriverPersona/GetExpLevelPointsMap
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetExpLevelPointsMap")]
        public List<int> GetExpLevelPointsMap()
        {
            // todo load from file

            List<int> maps = new List<int>()
            {
                100,
                975,
                2025,
                3625,
                5875,
                8875,
                12725,
                17525,
                23375,
                30375,
                39375,
                50575,
                64175,
                80375,
                99375,
                121375,
                146575,
                175175,
                207375,
                243375,
                283375,
                327575,
                376175,
                429375,
                487375,
                550375,
                618575,
                692175,
                771375,
                856375,
                950875,
                1055275,
                1169975,
                1295375,
                1431875,
                1579875,
                1739775,
                1911975,
                2096875,
                2294875,
                2506375,
                2731775,
                2971475,
                3225875,
                3495375,
                3780375,
                4081275,
                4398475,
                4732375,
                5083375,
                5481355,
                5898805,
                6336165,
                6793875,
                7272375,
                7772105,
                8293505,
                8837015,
                9403075,
                9992125
            };

            return maps;
        }

        /// <summary>
        /// POST http://localhost:7331/Engine.svc/DriverPersona/DeletePersona?personaId=1 text/xml;charset=utf-8
        /// </summary>
        /// <param name="personaId"></param>
        /// <returns></returns>
        [HttpPost("DeletePersona")]
        public long DeletePersona(long personaId)
        {
            return 0;
        }

        /// <summary>
        /// POST http://localhost:7331/Engine.svc/DriverPersona/ReserveName?userId=1&name=TEST text/xml;charset=utf-8
        /// </summary>
        /// <returns></returns>
        [HttpPost("ReserveName")]
        public List<string> ReserveName(long userId, string name)
        {
            //todo check exists persona name from database
            //todo if exists suggest new name by generate random name

            return new List<string>()
            {
                
            };
        }

        /// <summary>
        /// POST http://localhost:7331/Engine.svc/DriverPersona/CreatePersona?userId=1&name=DEMO&iconIndex=0&clan=1&clanIcon=clanIcon text/xml;charset=utf-8
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <param name="iconIndex"></param>
        /// <param name="clan"></param>
        /// <param name="clanIcon"></param>
        /// <returns></returns>
        [HttpPost("CreatePersona")]
        public ProfileData CreatePersona(long userId, string name, int iconIndex, int clan, string clanIcon)
        {
            Profile p = new Profile()
            {
                userid = userId,
                name = name,
                level = 1,
                percent_to_level = 0,
                icon_index = iconIndex,
                rating = 0,
                reputation = 0,
                rep_atcurrent_level = 0,
                cash = 0,
                boost = 0,
                motto = "",
                create_at = DateTime.Now,
                updated_at = DateTime.Now
            };

            _DB.Profiles.Add(p);
            p.id = _DB.SaveChanges();

            return new ProfileData()
            {
                PersonaId = p.id,
                Name = p.name,
                Level = p.level,
                PercentToLevel = p.percent_to_level,
                IconIndex = p.icon_index,
                Rating = p.rating,
                Rep = p.reputation,
                RepAtCurrentLevel = p.rep_atcurrent_level,
                Cash = p.cash,
                Boost = p.boost,
                Motto = p.motto,
                ccar = new List<PersonaCCar>()
            };
        }

        /// <summary>
        /// POST http://localhost:7331/Engine.svc/DriverPersona/GetPersonaBaseFromList text/xml;charset=utf-8
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetPersonaBaseFromList")]
        public List<PersonaBase> GetPersonaBaseFromList()
        {
            string input = new StreamReader(HttpContext.Request.Body).ReadToEnd();

            Console.WriteLine();
            Console.WriteLine(input);
            Console.WriteLine();

            return new List<PersonaBase>()
            {
                new PersonaBase()
                {
                    Badges = new List<BadgePacket>()
                    {
                        new BadgePacket()
                        {
                            AchievementRankId = 143,
                            BadgeDefinitionId = 59,
                            IsRare = true,
                            Rarity = 2578,
                            SlotId = 0
                        }
                    },
                    IconIndex = 26,
                    Level = 60,
                    Motto = "Newbie",
                    Name = "new player",
                    PersonaId = 1,
                    Presence = 1,
                    Score = 2815,
                    UserId = 1
                }
            };
        }

        /// <summary>
        /// POST http://localhost:7331/Engine.svc/DriverPersona/UpdatePersonaPresence?personaId=1&presence=1 text/xml;charset=utf-8
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="presence"></param>
        /// <returns></returns>
        [HttpPost("UpdatePersonaPresence")]
        public string UpdatePersonaPresence(long personaId, int presence)
        {
            return "";
        }
    }
}