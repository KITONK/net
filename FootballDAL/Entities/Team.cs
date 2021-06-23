using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDAL.Entities
{
    
    public class Team:BaseEntity
    {
        public string Name { get; set; }
        public int Playlevel { get; set; }

        public virtual Match IdMatch { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
