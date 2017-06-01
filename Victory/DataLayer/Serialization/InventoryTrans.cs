using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class InventoryTrans
    {
        [DataMember]
        public List<InventoryItemTrans> InventoryItems { get; set; }

        [DataMember]
        public long PerformancePartsCapacity { get; set; }

        [DataMember]
        public long PerformancePartsUsedSlotCount { get; set; }

        [DataMember]
        public long SkillModPartsCapacity { get; set; }

        [DataMember]
        public long SkillModPartsUsedSlotCount { get; set; }

        [DataMember]
        public long VisualPartsCapacity { get; set; }

        [DataMember]
        public long VisualPartsUsedSlotCount { get; set; }
    }
}
