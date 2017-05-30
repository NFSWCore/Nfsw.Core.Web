using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class LoginAnnouncementsDefinition
    {
        [DataMember]
        public List<LoginAnnouncementDefinition> Announcements = new List<LoginAnnouncementDefinition>();

        [DataMember]
        public string ImagesPath { get; set; }
    }
}
