using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class ObstacleCompetition
    {
        public ObstacleCompetition()
        {
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }
        public int IdObstacle { get; set; }
        public int IdCompetition { get; set; }

        public virtual Competition IdCompetitionNavigation { get; set; }
        public virtual Obstacle IdObstacleNavigation { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
