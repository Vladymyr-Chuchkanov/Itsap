using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Partisipant
    {
        public Partisipant()
        {
            RankPartisipants = new HashSet<RankPartisipant>();
            Results = new HashSet<Result>();
            TeamPartisipants = new HashSet<TeamPartisipant>();
        }

        public int IdParticipant { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int IdSex { get; set; }
        public int? PhoneNumber { get; set; }
        public int IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual Sex IdSexNavigation { get; set; }
        public virtual ICollection<RankPartisipant> RankPartisipants { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<TeamPartisipant> TeamPartisipants { get; set; }
    }
}
