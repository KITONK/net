using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBLL.Models
{
    public enum PlayLevel
    {
        bad,
        intermediate,
        advanced,
        proficiency
    }
    public class TeamModel:BaseModel
    {
        public string Name { get; set; }
        public PlayLevel Playlevel { get; set; }

        public virtual MatchModel IdMatch { get; set; }
        public virtual ICollection<PlayerModel> Players { get; set; }
    }
}
