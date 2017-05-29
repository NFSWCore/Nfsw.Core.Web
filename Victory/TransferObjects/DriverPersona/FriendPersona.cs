using System.Runtime.Serialization;

namespace Victory.TransferObjects.DriverPersona
{
    [DataContract]
    public class FriendPersona
    {
        [DataMember(Name = "iconIndex")]
        public int IconIndex { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "originalName")]
        public string OriginalName { get; set; }

        [DataMember(Name = "personaId")]
        public int PersonaId { get; set; }

        [DataMember(Name = "presence")]
        public int Presence { get; set; }

        [DataMember(Name = "socialNetwork")]
        public string SocialNetwork { get; set; }

        [DataMember(Name = "userId")]
        public int UserId { get; set; }
    }
}
