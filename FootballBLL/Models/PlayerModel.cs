using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBLL.Models
{
    public class PlayerModel:BaseModel
    {
        public string Name { get; set; }
        public int? Playlevel { get; set; }

        public virtual TeamModel IdTeam { get; set; }
    }
}
