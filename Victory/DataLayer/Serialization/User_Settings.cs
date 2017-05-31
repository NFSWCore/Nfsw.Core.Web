using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract(Name = "User_Settings")]
    public class User_Settings
    {
        [DataMember]
        public int CarCacheAgeLimit { get; set; }

        [DataMember]
        public bool IsRaceNowEnabled { get; set; }

        [DataMember]
        public int MaxCarCacheSize { get; set; }

        [DataMember]
        public int MinRaceNowLevel { get; set; }

        [DataMember]
        public bool VoipAvailable { get; set; }

        [DataMember()]
        public List<string> activatedHolidaySceneryGroups { get; set; }

        [DataMember()]
        public List<long> activeHolidayIds { get; set; }

        [DataMember()]
        public List<string> disactivatedHolidaySceneryGroups { get; set; }

        [DataMember]
        public bool firstTimeLogin { get; set; }

        [DataMember]
        public int maxLevel { get; set; }

        [DataMember]
        public bool starterPackApplied { get; set; }

        [DataMember]
        public long userId { get; set; }
    }
}
