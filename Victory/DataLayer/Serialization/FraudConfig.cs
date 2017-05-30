using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class FraudConfig
    {
        [DataMember(Name = "enabledBitField")]
        public int EnabledBitField { get; set; }

        [DataMember(Name = "gameFileFreq")]
        public int GameFileFreq { get; set; }

        [DataMember(Name = "moduleFreq")]
        public int ModuleFreq { get; set; }

        [DataMember(Name = "startUpFreq")]
        public int StartUpFreq { get; set; }

        [DataMember(Name = "userID")]
        public long UserID { get; set; }
    }
}
