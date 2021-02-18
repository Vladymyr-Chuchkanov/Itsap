using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Obstacle
    {
        public Obstacle()
        {
            ObstacleCompetitions = new HashSet<ObstacleCompetition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptiom { get; set; }

        public virtual ICollection<ObstacleCompetition> ObstacleCompetitions { get; set; }
    }
}
