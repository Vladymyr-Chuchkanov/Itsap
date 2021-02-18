using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Competition
    {
        public Competition()
        {
            CompetitionTeams = new HashSet<CompetitionTeam>();
            ObstacleCompetitions = new HashSet<ObstacleCompetition>();
        }

        public int IdCompetition { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public decimal StartTax { get; set; }
        public DateTime StartTime { get; set; }
        public int IdComplexity { get; set; }
        public int IdType { get; set; }

        public virtual Complexity IdComplexityNavigation { get; set; }
        public virtual Type IdTypeNavigation { get; set; }
        public virtual ICollection<CompetitionTeam> CompetitionTeams { get; set; }
        public virtual ICollection<ObstacleCompetition> ObstacleCompetitions { get; set; }
    }
}
