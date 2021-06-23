using FootballBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWeb.Models
{
    public class MatchesModel
    {
        public List<MatchModel> matches;
        public MatchesModel(List<MatchModel> _matches)
        {
            matches = _matches;
        }
    }
}
