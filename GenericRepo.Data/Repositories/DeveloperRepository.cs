using System.Collections.Generic;
using System.Linq;
using GenericRepo.Data.Entities;
using GenericRepo.Data.Interfaces;

namespace GenericRepo.Data.Repositories
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}