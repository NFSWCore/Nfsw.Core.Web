using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.TransferObjects.User
{
    [DataContract]
    public class UserInfo
    {
        [DataMember(Name = "defaultPersonaIdx")]
        public long DefaultPersonaIdx { get; set; }

        [DataMember(Name = "personas")]
        public List<ProfileData> Personas { get; set; }

        [DataMember(Name = "user")]
        public User User { get; set; }
    }
}
