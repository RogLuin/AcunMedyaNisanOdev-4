using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IApplicationRepository : IRepository<Application> { }
    public class ApplicationRepository : IApplicationRepository
    {
        // EF Core DbContext dependency injection yapılmalı (örnek):
        // private readonly AppDbContext _context;
        // public ApplicationRepository(AppDbContext context) => _context = context;

        public Task<Application> GetByIdAsync(int id) => throw new NotImplementedException();
        public Task<IEnumerable<Application>> GetAllAsync() => throw new NotImplementedException();
        public Task AddAsync(Application entity) => throw new NotImplementedException();
        public Task UpdateAsync(Application entity) => throw new NotImplementedException();
        public Task DeleteAsync(Application entity) => throw new NotImplementedException();
    }
}
