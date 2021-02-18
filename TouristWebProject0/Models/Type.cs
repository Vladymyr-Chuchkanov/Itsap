using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Type
    {
        public Type()
        {
            Competitions = new HashSet<Competition>();
        }

        public int IdType { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
