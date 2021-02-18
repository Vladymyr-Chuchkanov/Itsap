using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class RankPartisipant
    {
        public int Id { get; set; }
        public int IdRank { get; set; }
        public int IdPartisipant { get; set; }
        public DateTime DateOfAchievement { get; set; }

        public virtual Partisipant IdPartisipantNavigation { get; set; }
        public virtual Rank IdRankNavigation { get; set; }
    }
}
