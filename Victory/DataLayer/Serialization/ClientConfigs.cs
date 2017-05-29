using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class ClientConfigs
    {
        [DataMember(Name = "group")]
        public string Group { get; set; }

        [DataMember(Name = "level")]
        public long Level { get; set; }
    }
}
