using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.TransferObjects.Session
{
    [DataContract(Name = "chatServer")]
    public class ChatServer
    {
        [DataMember]
        public List<ChatRoom> Rooms = new List<ChatRoom>();

        [DataMember(Name = "ip")]
        public string Ip { get; set; }

        [DataMember(Name = "port")]
        public short Port { get; set; }

        [DataMember(Name = "prefix")]
        public string Prefix { get; set; }
    }
}
