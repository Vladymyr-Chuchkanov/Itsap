using System;
using System.Collections.Generic;

#nullable disable

namespace TouristWebProject0
{
    public partial class TeamPartisipant
    {
        public int Id { get; set; }
        public int IdPartisipant { get; set; }
        public int IdTeam { get; set; }
        public byte[] Participated { get; set; }

        public virtual Partisipant IdPartisipantNavigation { get; set; }
        public virtual Team IdTeamNavigation { get; set; }
    }
}
