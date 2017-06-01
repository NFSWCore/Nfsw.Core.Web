using System.Runtime.Serialization;

namespace Victory.Service.Objects
{
    [DataContract]
    public class BadgePacket
    {
        [DataMember]
        public int AchievementRankId { get; set; }

        [DataMember]
        public int BadgeDefinitionId { get; set; }

        [DataMember]
        public bool IsRare { get; set; }

        [DataMember]
        public float Rarity { get; set; }

        [DataMember]
        public short SlotId { get; set; }
    }
}
