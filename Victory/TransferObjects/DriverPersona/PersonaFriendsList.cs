using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Victory.TransferObjects.DriverPersona
{
    [DataContract]
    public class PersonaFriendsList
    {
        [DataMember(Name = "friendPersona")]
        public List<FriendPersona> friendPersonas = new List<FriendPersona>();
    }
}
