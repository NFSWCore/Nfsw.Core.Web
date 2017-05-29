using System;

namespace Nfsw.Core.Common.Structures
{
    public class Profile
    {
        public long id { get; set; }
        public long userid { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public int percent_to_level { get; set; }
        public int icon_index { get; set; }
        public float rating { get; set; }
        public int reputation { get; set; }
        public int rep_atcurrent_level { get; set; }
        public int cash { get; set; }
        public int boost { get; set; }
        public string motto { get; set; }
        public DateTime create_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
