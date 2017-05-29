using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class CustomPaintTrans
    {
        [DataMember]
        public int Group { get; set; }

        [DataMember]
        public int Hue { get; set; }

        [DataMember]
        public int Sat { get; set; }

        [DataMember]
        public int Slot { get; set; }

        [DataMember]
        public int Var { get; set; }
    }
}
