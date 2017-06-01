using System;
using System.Runtime.Serialization;

namespace Victory.DataLayer
{
    [DataContract(Namespace = "")]
    public class InventoryItemTrans
    {
        [DataMember]
        public string EntitlementTag { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }

        [DataMember]
        public int Hash { get; set; }

        [DataMember]
        public long InventoryId { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public long RemainingUseCount { get; set; }

        [DataMember]
        public double ResellPrice { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string StringHash { get; set; }

        [DataMember]
        public string VirtualItemType { get; set; }
    }
}
