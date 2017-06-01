using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization.Social
{
    [DataContract]
    public class SocialSettings
    {
        [DataMember]
        public bool AppearOffline { get; set; }

        [DataMember]
        public int DeclineGroupInvite { get; set; }

        [DataMember]
        public bool DeclineIncommingFriendRequests { get; set; }

        [DataMember]
        public int DeclinePrivateInvite { get; set; }

        [DataMember]
        public bool HideOfflineFriends { get; set; }

        [DataMember]
        public bool ShowNewsOnSignIn { get; set; }

        [DataMember]
        public bool ShowOnlyPlayersInSameChatChannel { get; set; }
    }
}
