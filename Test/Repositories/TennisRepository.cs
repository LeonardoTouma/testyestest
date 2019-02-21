using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Interface;
using Test.Models;

namespace Test.Repositories
{
    public class TennisRepository : ITennisRepository
    {
        public TennisRepository()
        {

        }
        //DB


        public List<TennisModel> tennisPlayers()
        {
            List<TennisModel> TennisPlayers = new List<TennisModel>()
        {
            new TennisModel(){ Id = 1, Country = "Sweden", Name = "Daniel" },
            new TennisModel(){ Id = 2, Country = "Poland", Name = "Peter" },
            new TennisModel(){ Id = 3, Country = "Canada", Name = "Per" },
            new TennisModel(){ Id = 4, Country = "Denmark", Name = "Carl" },
        };
            return TennisPlayers;
        }
    }
}
