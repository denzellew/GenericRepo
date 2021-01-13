using GenericRepo.Data.Entities;
using GenericRepo.Data.Interfaces;

namespace GenericRepo.Data.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}