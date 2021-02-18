using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Rank
    {
        public Rank()
        {
            RankPartisipants = new HashSet<RankPartisipant>();
        }

        public int IdRank { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RankPartisipant> RankPartisipants { get; set; }
    }
}
