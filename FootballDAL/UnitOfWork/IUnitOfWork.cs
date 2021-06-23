using FootballDAL.Entities;
using FootballDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Match> MatchRepository { get; set; }
        IRepository<Team> TeamRepository { get; set; }
        IRepository<Player> PlayerRepository { get; set; }

        void Save();
    }
}
