using System.Runtime.Serialization;

namespace Victory.Service.Objects
{
    [DataContract]
    public class FraudDetection
    {
        [DataMember]
        public long Checksum { get; set; }

        [DataMember]
        public long IntValue1 { get; set; }

        [DataMember]
        public long IntValue2 { get; set; }

        [DataMember]
        public long IntValue3 { get; set; }

        [DataMember]
        public long IntValue4 { get; set; }

        [DataMember]
        public bool IsEncrypted { get; set; }

        [DataMember]
        public string ModuleName { get; set; }

        [DataMember]
        public string ModulePath { get; set; }

        [DataMember]
        public int ModuleValue { get; set; }

        [DataMember]
        public string StringValue1 { get; set; }

        [DataMember]
        public string StringValue2 { get; set; }
    }
}
