using Library.Entities;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;
using Test.Repositories;
using Test.Interface;
using System.Linq;

namespace Library.Service
{
    public class TennisService : ITennisService
    {
        private readonly ITennisRepository _ITennisRepository;
        public TennisService(ITennisRepository tennisRepository)
        {
            _ITennisRepository = tennisRepository;
        }
        public string Game()
        {
            List<string> n = new List<string>() { "häst", "get", "apa", "ko", "tiger", "Fredrik", "guldfisk", "ozelot" };
            var WhatToRemove = 0;
            int number = 0;
            while (n.Count > 0)
            {
                number = n.Count;
                var calc = n.Count % 2;
                switch (calc)
                {
                    case 0:
                        number--;
                        //NumberOfPlayers.RemoveAt(WhatToRemove);
                        return "";
                    case 1:
                        var olik = WhatToRemove = (n.Count - 1) / 2;
                        if (olik % 2 != 0)
                        {
                            number++;//temp
                        }
                        //NumberOfPlayers.RemoveAt(WhatToRemove);
                        return $"Removed: {n[0]}";
                    default:
                        //not possible
                        //if (kill yourself)
                        //else if(kill someone else)
                        //else
                        return "kill yourself";
                }
            }
            if (n.Count == 0)
            {
                return $"No one left: {n.Select(x => x).ToString()}";
            }
            else if (n.Count == 2 && n[1] == "temp")
            {
                var finalNumber = number - 1;
            }
            return $"Left is: {n[0].ToString()}";
        }
        public void CreatePlayer(TennisModel tennisplayer)
        {
            var tenPlayer = new TennisModel()
            { Id = tennisplayer.Id, Country = tennisplayer.Country, Name = tennisplayer.Name };
            _ITennisRepository.tennisPlayers().Add((tenPlayer));
        }
        public void Remove(int id)
        {
            var itemToRemove = _ITennisRepository.tennisPlayers().Where(x => x.Id == id).FirstOrDefault();
            _ITennisRepository.tennisPlayers().Remove(itemToRemove);
        }
        public void update(TennisEntity tennisPlayer)
        {
            var updatedTennisPlayer = new TennisModel()
            { Id = tennisPlayer.Id, Country = tennisPlayer.Country, Name = tennisPlayer.Name };
        }
    }
}
