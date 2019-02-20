using Library.Entities;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;
using Test.Repositories;
using Test.Interface;

namespace Library.Service
{
    public class TennisService : ITennisService
    {
        private readonly ITennisRepository _ITennisRepository;
        public TennisService(ITennisRepository tennisRepository)
        {
            _ITennisRepository = tennisRepository;
        }

        public void CreatePlayer()
        {

        }
        public void Remove()
        {

        }
        public void update()
        {

        }
    }
}
