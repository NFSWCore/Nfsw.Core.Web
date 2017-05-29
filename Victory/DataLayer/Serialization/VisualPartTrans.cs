using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class VisualPartTrans
    {
        [DataMember]
        public int PartHash { get; set; }

        [DataMember]
        public int SlotHash { get; set; }
    }
}
