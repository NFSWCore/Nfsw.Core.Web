using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class ProductTrans
    {
        [DataMember]
        public List<ProductTrans> BundleItems { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int DurationMinute { get; set; }

        [DataMember]
        public int Hash { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public string LongDescription { get; set; }

        [DataMember]
        public float Price { get; set; }

        [DataMember]
        public int Priority { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public string ProductTitle { get; set; }

        [DataMember]
        public GameItemType ProductType { get; set; }

        [DataMember]
        public string SecondaryIcon { get; set; }

        [DataMember]
        public int UseCount { get; set; }

        [DataMember]
        public int VisualStyle { get; set; }

        [DataMember]
        public string WebIcon { get; set; }

        [DataMember]
        public string WebLocation { get; set; }
    }
}
