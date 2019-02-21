using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Library.Interfaces
{
    interface ITennisService
    {
        string Game();
        void CreatePlayer(TennisModel tennisplayer);
        void Remove(int id);
        void update(TennisEntity tennisPlayer);
    }
}
