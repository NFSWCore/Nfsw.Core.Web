using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.Service.Objects
{
    [DataContract]
    public class Report
    {
        [DataMember(Name = "chatTranscripts")]
        public ChatTranscripts ChatTranscripts { get; set; }

        [DataMember(Name = "errorReport")]
        public ErrorReport ErrorReport { get; set; }

        [DataMember(Name = "fraudDetectionReport")]
        public List<FraudDetection> FraudDetectionReport { get; set; }

        [DataMember(Name = "shortcutUsage")]
        public ShortcutUsage ShortcutUsage { get; set; }
    }
}
