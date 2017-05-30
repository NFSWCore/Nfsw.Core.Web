using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class LoginAnnouncementDefinition
    {
        public string Context { get; set; }

        public int Id { get; set; }

        public int ImageChecksum { get; set; }

        public string ImageUrl { get; set; }

        public AnnouncementType Type { get; set; }
    }
}
