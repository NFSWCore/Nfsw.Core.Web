using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class CarSlotInfoTrans
    {
        [DataMember]
        public List<OwnedCarTrans> CarsOwnedByPersona = new List<OwnedCarTrans>();

        [DataMember]
        public int DefaultOwnedCarIndex { get; set; }

        [DataMember]
        public List<ProductTrans> ObtainableSlots = new List<ProductTrans>();

        [DataMember]
        public int OwnedCarSlotsCount { get; set; }
    }
}
