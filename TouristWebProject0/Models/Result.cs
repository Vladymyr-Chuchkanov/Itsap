using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class Result
    {
        public int Id { get; set; }
        public int IdPartisipant { get; set; }
        public int IdObstacleCompetition { get; set; }
        public TimeSpan Time { get; set; }
        public int Penalty { get; set; }

        public virtual ObstacleCompetition IdObstacleCompetitionNavigation { get; set; }
        public virtual Partisipant IdPartisipantNavigation { get; set; }
    }
}
