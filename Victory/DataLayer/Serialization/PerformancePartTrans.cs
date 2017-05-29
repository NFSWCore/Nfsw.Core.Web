using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class PerformancePartTrans
    {
        [DataMember]
        public int PerformancePartAttribHash { get; set; }
    }
}
