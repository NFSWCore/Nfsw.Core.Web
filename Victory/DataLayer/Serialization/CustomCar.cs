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
        public List<CustomPaintTrans> Paints = new List<CustomPaintTrans>();

        [DataMember]
        public List<PerformancePartTrans> PerformanceParts = new List<PerformancePartTrans>();

        [DataMember]
        public int PhysicsProfileHash { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public int ResalePrice { get; set; }

        [DataMember]
        public int RideHeightDrop { get; set; }

        [DataMember]
        public List<SkillModPartTrans> SkillModParts = new List<SkillModPartTrans>();

        [DataMember]
        public int SkillModSlotCount { get; set; }

        [DataMember]
        public int Version { get; set; }

        [DataMember]
        public List<CustomVinylTrans> Vinyls = new List<CustomVinylTrans>();

        [DataMember]
        public List<VisualPartTrans> VisualParts = new List<VisualPartTrans>();
    }
}
