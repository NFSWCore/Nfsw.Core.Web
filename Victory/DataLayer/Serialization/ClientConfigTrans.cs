using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class ClientConfigTrans
    {
        [DataMember]
        public ClientConfigs clientConfigs { get; set; }
    }
}
