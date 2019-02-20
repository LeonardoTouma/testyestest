using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Library.Interfaces
{
    interface IMapper
    {
        TennisEntity MapModelToEntity(TennisModel tennisModel);
    }
}
