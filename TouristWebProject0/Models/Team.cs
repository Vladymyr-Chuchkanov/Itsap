using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Team
    {
        public Team()
        {
            CompetitionTeams = new HashSet<CompetitionTeam>();
            TeamPartisipants = new HashSet<TeamPartisipant>();
        }

        public int IdTeam { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<CompetitionTeam> CompetitionTeams { get; set; }
        public virtual ICollection<TeamPartisipant> TeamPartisipants { get; set; }
    }
}
