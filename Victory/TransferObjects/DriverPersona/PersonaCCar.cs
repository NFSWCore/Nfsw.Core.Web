using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Victory.TransferObjects.DriverPersona
{
    [DataContract]
    public class PersonaCCar
    {
        [DataMember(Name = "PersonaId")]
        public long PersonaId { get; set; }

        [DataMember(Name = "CCID")]
        public int Ccid { get; set; }

        [DataMember(Name = "Durability")]
        public int Durability { get; set; }

        [DataMember(Name = "Heat")]
        public float Heat { get; set; }

        [DataMember(Name = "IsDefault")]
        public bool IsDefault { get; set; }
    }
}
