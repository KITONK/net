using FootballBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBLL.Interfaces
{
    public interface ITeamService
    {
        IEnumerable<PlayerModel> GetAllPlayersFromTeam(int idTeam);
    }
}
