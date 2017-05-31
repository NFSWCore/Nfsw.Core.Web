using System;
using System.Runtime.Serialization;

namespace Victory.TransferObjects.User
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "address1")]
        public string Address1 { get; set; }

        [DataMember(Name = "address2")]
        public string Address2 { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "dateCreated")]
        public string DateCreated { get; set; }

        [DataMember(Name = "dob")]
        public string DateOfBirth { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "emailStatus")]
        public string EmailStatus { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "fullGameAccess")]
        public bool FullGameAccess { get; set; }

        [DataMember(Name = "gender")]
        public Gender? Gender { get; set; }

        [DataMember(Name = "idDigits")]
        public string IdDigits { get; set; }

        [DataMember(Name = "isComplete")]
        public bool IsComplete { get; set; }

        [DataMember(Name = "landlinePhone")]
        public string LandlinePhone { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "lastAuthDate")]
        public DateTime? LastAuthDate { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "mobile")]
        public string Mobile { get; set; }

        [DataMember(Name = "nickname")]
        public string Nickname { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "realName")]
        public string RealName { get; set; }

        [DataMember(Name = "reasonCode")]
        public string ReasonCode { get; set; }

        [DataMember(Name = "remoteUserId")]
        public long RemoteUserId { get; set; }

        [DataMember(Name = "securityToken")]
        public Guid SecurityToken { get; set; }

        [DataMember(Name = "starterPackEntitlementTag")]
        public string StarterPackEntitlementTag { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "subscribeMsg")]
        public bool SubscribeMsg { get; set; }

        [DataMember(Name = "tosVersion")]
        public int? TosVersion { get; set; }

        [DataMember(Name = "userId")]
        public long UserId { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}
