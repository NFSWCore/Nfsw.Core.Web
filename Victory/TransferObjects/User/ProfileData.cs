using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Victory.TransferObjects.DriverPersona;

namespace Victory.TransferObjects.User
{
    [DataContract]
    public class ProfileData
    {
        [DataMember()]
        public long PersonaId { get; set; }

        [DataMember()]
        public int Boost { get; set; }

        [DataMember()]
        public int Cash { get; set; }

        [DataMember()]
        public int IconIndex { get; set; }

        [DataMember()]
        public int Level { get; set; }

        [DataMember()]
        public string Motto { get; set; }

        [DataMember()]
        public string Name { get; set; }

        [DataMember()]
        public int PercentToLevel { get; set; }

        [DataMember()]
        public float Rating { get; set; }

        [DataMember()]
        public int Rep { get; set; }

        [DataMember()]
        public int RepAtCurrentLevel { get; set; }

        [DataMember()]
        public List<PersonaCCar> ccar { get; set; }
    }
}
