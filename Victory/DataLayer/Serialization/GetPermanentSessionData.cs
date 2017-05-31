using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class GetPermanentSessionData
    {
        [DataMember(Name = "machineID")]
        public long MachineID { get; set; }

        [DataMember(Name = "version")]
        public int Version { get; set; }
    }
}
