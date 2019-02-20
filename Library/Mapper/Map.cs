using Library.Entities;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Library.Mapper
{
    public class Map:IMapper
    {
        public TennisEntity MapModelToEntity(TennisModel tennisModel)
        {
            var TennisEntity = new TennisEntity()
            {
                Id = tennisModel.Id,
                Country = tennisModel.Country,
                Name = tennisModel.Name
            };
            return TennisEntity;
        }
    }
}
