using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Role
    {
        public Role()
        {
            Partisipants = new HashSet<Partisipant>();
        }

        public int IdRoles { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Partisipant> Partisipants { get; set; }
    }
}
