using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.Service.Objects
{
    [DataContract]
    public class PersonaBase
    {
        [DataMember]
        public List<BadgePacket> Badges { get; set; }

        [DataMember]
        public int IconIndex { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public string Motto { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public long PersonaId { get; set; }

        [DataMember]
        public int Presence { get; set; }

        [DataMember]
        public int Score { get; set; }

        [DataMember]
        public long UserId { get; set; }
    }
}
