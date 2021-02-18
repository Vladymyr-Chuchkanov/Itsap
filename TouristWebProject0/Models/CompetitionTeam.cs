using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class CompetitionTeam
    {
        public int Id { get; set; }
        public int IdCompetition { get; set; }
        public int IdTeam { get; set; }
        public byte[] Admitted { get; set; }
        public TimeSpan? ResultTime { get; set; }
        public int? Penalty { get; set; }
        public int? Position { get; set; }

        public virtual Competition IdCompetitionNavigation { get; set; }
        public virtual Team IdTeamNavigation { get; set; }
    }
}
