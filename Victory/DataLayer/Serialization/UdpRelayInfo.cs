using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class UdpRelayInfo
    {
        [DataMember]
        public string Host { get; set; }

        [DataMember]
        public short Port { get; set; }
    }
}
