using FootballDAL.Entities;
using FootballDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FootbalDBContext _context;

        public UnitOfWork(FootbalDBContext context, IRepository<Match> matchRepository, 
            IRepository<Team> teamRepository, IRepository<Player> playerRepository)
        {
            _context = context;
            MatchRepository = matchRepository;
            TeamRepository = teamRepository;
            PlayerRepository = playerRepository;
        }

        public IRepository<Match> MatchRepository { get ; set ; }
        public IRepository<Team> TeamRepository { get; set; }
        public IRepository<Player> PlayerRepository { get ; set ; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
