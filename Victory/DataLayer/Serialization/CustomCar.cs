using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class CustomCar
    {
        [DataMember]
        public int BaseCar { get; set; }

        [DataMember]
        public int CarClassHash { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool IsPreset { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<CustomPaintTrans> Paints { get; set; }

        [DataMember]
        public List<PerformancePartTrans> PerformanceParts { get; set; }

        [DataMember]
        public int PhysicsProfileHash { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public int ResalePrice { get; set; }

        [DataMember]
        public int RideHeightDrop { get; set; }

        [DataMember]
        public List<SkillModPartTrans> SkillModParts { get; set; }

        [DataMember]
        public int SkillModSlotCount { get; set; }

        [DataMember]
        public int Version { get; set; }

        [DataMember]
        public List<CustomVinylTrans> Vinyls { get; set; }

        [DataMember]
        public List<VisualPartTrans> VisualParts { get; set; }
    }
}
