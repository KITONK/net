using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBLL.Interfaces
{
    public interface IPlayerService
    {
        void AddPlayer(int idteam, string name, int playlevel);
        void DeletePlayer(int id);

    }
}
