using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class OwnedCarTrans
    {
        [DataMember]
        public List<CustomCar> CustomCar = new List<CustomCar>();

        [DataMember]
        public int Durability { get; set; }

        [DataMember]
        public DateTime? ExpirationDate { get; set; }

        [DataMember]
        public int Heat { get; set; }

        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string OwnershipType { get; set; }
    }
}
