using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class SkillModPartTrans
    {
        [DataMember]
        public bool IsFixed { get; set; }

        [DataMember]
        public int SkillModPartAttribHash { get; set; }
    }
}
