using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Interface
{
    public interface ITennisRepository
    {
        List<TennisModel> tennisPlayers();
    }
}
