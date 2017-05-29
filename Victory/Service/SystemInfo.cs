using System;
using System.Runtime.Serialization;

namespace Victory.Service
{
    [DataContract]
    public class SystemInfo
    {
        [DataMember]
        public Branchs Branch { get; set; }

        [DataMember]
        public int ChangeList { get; set; }

        [DataMember]
        public int ClientVersion { get; set; }

        [DataMember]
        public bool ClientVersionCheck { get; set; }

        [DataMember]
        public string Deployed { get; set; }

        [DataMember]
        public bool EntitlementsToDownload { get; set; }

        [DataMember]
        public bool ForcePermanentSession { get; set; }

        [DataMember]
        public string JidPrepender { get; set; }

        [DataMember]
        public string LauncherServiceUrl { get; set; }

        [DataMember]
        public string NucleusNamespace { get; set; }

        [DataMember]
        public string NucleusNamespaceWeb { get; set; }

        [DataMember]
        public int PersonaCacheTimeout { get; set; }

        [DataMember]
        public string PortalDomain { get; set; }

        [DataMember]
        public string PortalSecureDomain { get; set; }

        [DataMember]
        public string PortalStoreFailurePage { get; set; }

        [DataMember]
        public int PortalTimeOut { get; set; }

        [DataMember]
        public string ShardName { get; set; }

        [DataMember]
        public DateTime Time { get; set; }

        [DataMember]
        public int Version { get; set; }
    }
}
