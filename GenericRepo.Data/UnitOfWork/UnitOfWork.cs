using System;
using System.Collections.Generic;
using System.Text;
using GenericRepo.Data.Interfaces;
using GenericRepo.Data.Repositories;

namespace GenericRepo.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public IDeveloperRepository Developers { get; }
        public IProjectRepository Projects { get; }
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Developers = new DeveloperRepository(_context);
            Projects = new ProjectRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
