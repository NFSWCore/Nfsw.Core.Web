using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using Victory;
using Victory.DataLayer.Serialization;
using Victory.DataLayer.Serialization.Social;
using Victory.Service;
using Victory.Service.Objects;
using Victory.Service.Objects.Event;
using Victory.TransferObjects.DriverPersona;
using Victory.TransferObjects.News;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc")]
    public class DefaultController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public DefaultController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/getfriendlistfromuserid
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("getfriendlistfromuserid")]
        public PersonaFriendsList GetFriendListFromUserId(long userId)
        {
            _logger.LogDebug($"USER ID: {userId}");

            // todo load friend list

            return new PersonaFriendsList()
            {
                friendPersonas = new List<FriendPersona>()
            };
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/getusersettings
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("getusersettings")]
        public User_Settings GetUserSettings(long userId)
        {
            List<string> _activatedHolidaySceneryGroups = new List<string>();
            _activatedHolidaySceneryGroups.Add("SCENERY_GROUP_NORMAL");
            _activatedHolidaySceneryGroups.Add("PLACEHOLDER");

            List<string> _disactivatedHolidaySceneryGroups = new List<string>();
            _disactivatedHolidaySceneryGroups.Add("SCENERY_GROUP_NORMAL_DISABLE");
            _disactivatedHolidaySceneryGroups.Add("PLACEHOLDER");

            return new User_Settings()
            {
                CarCacheAgeLimit = 600,
                IsRaceNowEnabled = true,
                MaxCarCacheSize = 250,
                MinRaceNowLevel = 2,
                VoipAvailable = false,
                activatedHolidaySceneryGroups = _activatedHolidaySceneryGroups,
                disactivatedHolidaySceneryGroups = _disactivatedHolidaySceneryGroups,
                firstTimeLogin = false,
                maxLevel = 60,
                starterPackApplied = false,
                userId = userId
            };
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/systeminfo
        /// </summary>
        /// <returns></returns>
        [HttpGet("systeminfo")]
        public SystemInfo SystemInfo()
        {
            SystemInfo sys = new SystemInfo()
            {
                Branch = Branchs.production,
                ChangeList = 620384,
                ClientVersion = 637,
                ClientVersionCheck = true,
                Deployed = "08/20/2013 11:24:40",
                EntitlementsToDownload = true,
                ForcePermanentSession = true,
                JidPrepender = "pnfs",
                LauncherServiceUrl = "http://127.0.0.1",
                NucleusNamespace = "pnfs-live",
                NucleusNamespaceWeb = "pnfs_web",
                PersonaCacheTimeout = 900,
                PortalDomain = "playnfs.com",
                PortalSecureDomain = "playnfs.com",
                PortalStoreFailurePage = "playnfs.com/fail",
                PortalTimeOut = 6000,
                ShardName = "CORE",
                Time = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Local),
                Version = 1599,
            };

            return sys;
        }

        /// <summary>
        /// http://localhost:7331/Engine.svc/carclasses
        /// </summary>
        /// <returns></returns>
        [HttpGet("carclasses")]
        public List<CarClass> CarClasses()
        {
            List<CarClass> carClass = new List<CarClass>();

            carClass.Add(new CarClass()
            {
                CarClassHash = -2142411446,
                MaxRating = 999,
                MinRating = 750
            });
            carClass.Add(new CarClass()
            {
                CarClassHash = -406473455,
                MaxRating = 599,
                MinRating = 500
            });
            carClass.Add(new CarClass()
            {
                CarClassHash = -405837480,
                MaxRating = 749,
                MinRating = 600
            });
            carClass.Add(new CarClass()
            {
                CarClassHash = 415909161,
                MaxRating = 399,
                MinRating = 250
            });
            carClass.Add(new CarClass()
            {
                CarClassHash = 872416321,
                MaxRating = 249,
                MinRating = 0
            });
            carClass.Add(new CarClass()
            {
                CarClassHash = 1866825865,
                MaxRating = 499,
                MinRating = 400
            });

            return carClass;
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/getrebroadcasters
        /// </summary>
        /// <returns></returns>
        [HttpGet("getrebroadcasters")]
        public List<UdpRelayInfo> GetReBroadCasters()
        {
            List<UdpRelayInfo> udpRelayInfos = new List<UdpRelayInfo>();

            udpRelayInfos.Add(new UdpRelayInfo()
            {
                Host = "127.0.0.1",
                Port = 9999
            });

            return udpRelayInfos;
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/getregioninfo
        /// </summary>
        /// <returns></returns>
        [HttpGet("getregioninfo")]
        public RegionInfo GetRegionInfo()
        {
            return new RegionInfo()
            {
                CountdownProposalInMilliseconds = 3000,
                DirectConnectTimeoutInMilliseconds = 1000,
                DropOutTimeInMilliseconds = 15000,
                EventLoadTimeoutInMilliseconds = 30000,
                HeartbeatIntervalInMilliseconds = 1000,
                UdpRelayBandwidthInBps = 9600,
                UdpRelayTimeoutInMilliseconds = 60000
            };
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/LoginAnnouncements
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        [HttpGet("LoginAnnouncements")]
        public LoginAnnouncementsDefinition LoginAnnouncements(string language)
        {
            return new LoginAnnouncementsDefinition()
            {
                Announcements = new List<LoginAnnouncementDefinition>()
                {
                    new LoginAnnouncementDefinition()
                    {
                        Context = "NotApplicable",
                        Id = 1,
                        ImageChecksum = -1,
                        ImageUrl = "0.png",
                        Type = AnnouncementType.ImageOnly
                    }
                },
                ImagesPath = "http://localhost/announcements"
            };
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/heartbeat
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        [HttpPost("heartbeat")]
        public HeartBeat HeartBeat([FromBody]Report report)
        {
            return new HeartBeat()
            {
                EnabledBitField = 0,
                MetagameFlags = 2
            };
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/setusersettings
        /// </summary>
        /// <param name="userSettings"></param>
        /// <returns></returns>
        [HttpPut("setusersettings")]
        public User_Settings SetUserSettings([FromBody]User_Settings userSettings)
        {
            return userSettings;
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/getsocialsettings
        /// </summary>
        /// <returns></returns>
        [HttpGet("getsocialsettings")]
        public SocialSettings GetSocialSettings()
        {
            return new SocialSettings()
            {
                AppearOffline = false,
                DeclineGroupInvite = 0,
                DeclineIncommingFriendRequests = false,
                DeclinePrivateInvite = 0,
                HideOfflineFriends = false,
                ShowNewsOnSignIn = true,
                ShowOnlyPlayersInSameChatChannel = false
            };
        }

        /// <summary>
        /// PUT http://localhost:7331/Engine.svc/setsocialsettings text/xml;charset=utf-8
        /// </summary>
        /// <returns></returns>
        [HttpPut("setsocialsettings")]
        public SocialSettings SetSocialSettings([FromBody]SocialSettings socialSettings)
        {
            //todo social setting to database

            return socialSettings;
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/getblockeduserlist?userId={ID}
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("getblockeduserlist")]
        public List<long> GetBlockedUserList(long userId)
        {
            //todo get blocked user list from database

            return new List<long>();
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/getblockersbyusers?personaId={ID}
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("getblockersbyusers")]
        public List<long> GetBlockersByUsers(long personaId)
        {
            //todo get user blocked me list from database

            return new List<long>();
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/NewsArticles?personaId=1
        /// </summary>
        /// <param name="personaId"></param>
        /// <returns></returns>
        [HttpGet("NewsArticles")]
        public List<NewsArticleTrans> NewsArticles(long personaId)
        {
            return new List<NewsArticleTrans>()
            {
                new NewsArticleTrans()
                {
                    ExpiryTime = DateTime.Now.AddMonths(1),
                    Filters = 0,
                    IconType = 1,
                    LongText_HALId = "∑¥ Õ∫¢ÈÕ§«“¡·∫∫¬“««««««««««««««««««««««««",
                    NewsId = 1,
                    Parameters = "#1111111",
                    PersonaId = 1,
                    ShortText_HALId = "∑¥ Õ∫¢ÈÕ§«“¡ —ÈπÊ",
                    Sticky = 0,
                    Timestamp = DateTime.Now.Millisecond,
                    Type = 1
                },
                new NewsArticleTrans()
                {
                    ExpiryTime = DateTime.Now.AddMonths(1),
                    Filters = 0,
                    IconType = 2,
                    LongText_HALId = "∑¥ Õ∫¢ÈÕ§«“¡·∫∫¬“««««««««««««««««««««««««",
                    NewsId = 2,
                    Parameters = "#2222222",
                    PersonaId = 1,
                    ShortText_HALId = "∑¥ Õ∫¢ÈÕ§«“¡ —ÈπÊ",
                    Sticky = 1,
                    Timestamp = DateTime.Now.Millisecond,
                    Type = 2
                }
            };
        }
    }
}