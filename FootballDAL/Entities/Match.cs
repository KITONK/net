using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDAL.Entities
{
    public class Match:BaseEntity
    {
        public int? FirstTeamId { get; set; }
        public int? SecondTeamId { get; set; }
        public DateTime? DateHeld { get; set; }

        public virtual Team Team { get; set; }

        public Match()
        {
        }
    }
}
