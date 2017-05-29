using System.Runtime.Serialization;

namespace Victory.TransferObjects.Session
{
    [DataContract(Name = "chatRoom")]
    public class ChatRoom
    {
        [DataMember(Name = "channelCount")]
        public int ChannelCount { get; set; }

        [DataMember(Name = "longName")]
        public string LongName { get; set; }

        [DataMember(Name = "shortName")]
        public string ShortName { get; set; }
    }
}
