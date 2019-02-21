using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Repository104.Interface
{
    public interface ITennisRepository
    {
        List<TennisModel> tennisPlayers();
    }
}
