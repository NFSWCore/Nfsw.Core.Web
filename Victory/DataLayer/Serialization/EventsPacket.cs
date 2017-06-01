using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class EventsPacket
    {
        [DataMember]
        public List<EventDefinition> Events { get; set; }
    }
}
