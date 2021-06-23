using FootballBLL.Models;
using FootballDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBLL.Interfaces
{
    public interface IMatchService
    {
        IEnumerable<MatchModel> GetAllMatches();
        void AddNewMatch(Team team1, Team team2, DateTime launchdate);
        TeamModel PredictResults(Team team1, Team team2);
        TeamModel PredictResults(List<Player> players1, List<Player> players2);

    }
}
