using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBLL.Models
{
    public class MatchModel:BaseModel
    {
        public int? FirstTeamId { get; set; }
        public int? SecondTeamId { get; set; }
        public DateTime? DateHeld { get; set; }

        public virtual TeamModel Team { get; set; }
    }
}
