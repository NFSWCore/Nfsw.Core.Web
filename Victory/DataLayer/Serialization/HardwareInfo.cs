using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract]
    public class HardwareInfo
    {
        [DataMember(Name = "availableMem")]
        public long AvailableMemory { get; set; }

        [DataMember(Name = "cpuBrand")]
        public string CpuBrand { get; set; }

        [DataMember(Name = "cpuid0")]
        public string CpuId0 { get; set; }

        [DataMember(Name = "cpuid1_0")]
        public string CpuId1_0 { get; set; }

        [DataMember(Name = "cpuid1_1")]
        public string CpuId1_1 { get; set; }

        [DataMember(Name = "cpuid1_2")]
        public string CpuId1_2 { get; set; }

        [DataMember(Name = "cpuid1_3")]
        public string CpuId1_3 { get; set; }

        [DataMember(Name = "deviceID")]
        public long DeviceId { get; set; }

        [DataMember(Name = "excpuid1_0")]
        public string ExCpuId1_0 { get; set; }

        [DataMember(Name = "excpuid1_1")]
        public string ExCpuId1_1 { get; set; }

        [DataMember(Name = "excpuid1_2")]
        public string ExCpuId1_2 { get; set; }

        [DataMember(Name = "excpuid1_3")]
        public string ExCpuId1_3 { get; set; }

        [DataMember(Name = "gpuDescription")]
        public string GpuDescription { get; set; }

        [DataMember(Name = "gpuDriverBuild")]
        public int GpuDriverBuild { get; set; }

        [DataMember(Name = "gpuDriverSubversion")]
        public int GpuDriverSubversion { get; set; }

        [DataMember(Name = "gpuDriverVersion")]
        public int GpuDriverVersion { get; set; }

        [DataMember(Name = "gpuMemory")]
        public long GpuMemory { get; set; }

        [DataMember(Name = "gpuProduct")]
        public int GpuProduct { get; set; }

        [DataMember(Name = "osBuildNumber")]
        public int OsBuildNumber { get; set; }

        [DataMember(Name = "osMajorVersion")]
        public int OsMajorVersion { get; set; }

        [DataMember(Name = "osMinorVersion")]
        public int OsMinorVersion { get; set; }

        [DataMember(Name = "physicalCores")]
        public int PhysicalCores { get; set; }

        [DataMember(Name = "platformID")]
        public int PlatformID { get; set; }

        [DataMember(Name = "processAffinityMask")]
        public int ProcessAffinityMask { get; set; }

        [DataMember(Name = "servicePack")]
        public string SservicePack { get; set; }

        [DataMember(Name = "systemAffinityMask")]
        public int SystemAffinityMask { get; set; }

        [DataMember(Name = "totalMemory")]
        public long TtotalMemory { get; set; }

        [DataMember(Name = "userID")]
        public long UserID { get; set; }

        [DataMember(Name = "vendorID")]
        public int VendorID { get; set; }
    }
}
