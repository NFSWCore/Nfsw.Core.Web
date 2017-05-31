using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class HeartBeat
    {
        [DataMember(Name = "MetagameFlags")]
        public int MetagameFlags { get; set; }

        [DataMember(Name = "enabledBitField")]
        public int EnabledBitField { get; set; }
    }
}
