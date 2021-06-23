using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDAL.Entities
{
    public class Player:BaseEntity
    {
        public string Name { get; set; }
        public int Playlevel { get; set; }

        public virtual Team IdTeam { get; set; }

        public Player()
        {

        }
    }
}
