using System;
using System.Runtime.Serialization;

namespace Victory.TransferObjects.News
{
    [DataContract]
    public class NewsArticleTrans
    {
        [DataMember]
        public DateTime ExpiryTime { get; set; }

        [DataMember]
        public int Filters { get; set; }

        [DataMember]
        public int IconType { get; set; }

        [DataMember]
        public string LongText_HALId { get; set; }

        [DataMember]
        public long NewsId { get; set; }

        [DataMember]
        public string Parameters { get; set; }

        [DataMember]
        public long PersonaId { get; set; }

        [DataMember]
        public string ShortText_HALId { get; set; }

        [DataMember]
        public int Sticky { get; set; }

        [DataMember]
        public long Timestamp { get; set; }

        [DataMember]
        public int Type { get; set; }
    }
}
