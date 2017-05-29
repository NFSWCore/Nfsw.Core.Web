using System;

namespace Nfsw.Core.Common.Structures
{
    public class User
    {
        public long id { get; set; }
        public string email { get; set; }
        public string md5password { get; set; }
        public Guid security_token { get; set; }
        public byte gender { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        
    }
}
