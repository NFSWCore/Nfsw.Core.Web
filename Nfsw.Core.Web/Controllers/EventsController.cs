using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Victory.DataLayer.Serialization;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class EventsController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("availableatlevel")]
        public EventsPacket AvailableAtLevel()
        {
            return new EventsPacket()
            {
                Events = new List<EventDefinition>()
            };
        }
    }
}