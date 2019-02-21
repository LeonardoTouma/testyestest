using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository103.Interface
{
    public interface ITennisRepository
    {
        List<TennisModel> tennisPlayers();
    }
}
