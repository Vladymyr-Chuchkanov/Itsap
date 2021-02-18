using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Complexity
    {
        public Complexity()
        {
            Competitions = new HashSet<Competition>();
        }

        public int IdComplexity { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
