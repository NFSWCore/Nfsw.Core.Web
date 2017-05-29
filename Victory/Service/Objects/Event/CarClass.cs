using System.Runtime.Serialization;

namespace Victory.Service.Objects.Event
{
    [DataContract]
    public class CarClass
    {
        [DataMember]
        public int CarClassHash { get; set; }

        [DataMember]
        public int MaxRating { get; set; }

        [DataMember]
        public int MinRating { get; set; }
    }
}
