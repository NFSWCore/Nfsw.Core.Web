using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class CarSlotInfoTrans
    {
        [DataMember]
        public List<OwnedCarTrans> CarsOwnedByPersona { get; set; }

        [DataMember]
        public int DefaultOwnedCarIndex { get; set; }

        [DataMember]
        public List<ProductTrans> ObtainableSlots { get; set; }

        [DataMember]
        public int OwnedCarSlotsCount { get; set; }
    }
}
