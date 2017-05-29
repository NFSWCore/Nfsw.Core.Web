using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Victory.TransferObjects.Session;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class SessionController : Controller
    {
        [HttpGet("GetChatInfo")]
        public ChatServer GetChatInfo()
        {
            var chatRooms = new List<ChatRoom>();

            chatRooms.Add(new ChatRoom()
            {
                ChannelCount = 10,
                LongName = "TXT_CHAT_LANG_THAI",
                ShortName = "TH"
            });

            ChatServer chatServer = new ChatServer()
            {
                Ip = "127.0.0.1",
                Port = 5222,
                Prefix = "pnfs",
                Rooms = chatRooms
            };

            return chatServer;
        }
    }
}