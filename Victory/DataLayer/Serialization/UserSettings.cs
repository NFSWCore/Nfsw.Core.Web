using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class UserSettings
    {
        [DataMember(Name = "userID")]
        public long UserID { get; set; }

        [DataMember(Name = "globalDetailLevel")]
        public int GlobalDetailLevel { get; set; }

        [DataMember(Name = "gameResWidth")]
        public int GameResWidth { get; set; }

        [DataMember(Name = "gameResHeight")]
        public int GameResHeight { get; set; }

        [DataMember(Name = "fullscreen")]
        public bool Fullscreen { get; set; }

        [DataMember(Name = "desktopResWidth")]
        public int DesktopResWidth { get; set; }

        [DataMember(Name = "desktopResHeight")]
        public int DesktopResHeight { get; set; }
    }
}
