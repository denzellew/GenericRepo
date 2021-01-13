using System;
using System.Collections.Generic;
using System.Text;
using GenericRepo.Data.Entities;

namespace GenericRepo.Data.Interfaces
{
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
