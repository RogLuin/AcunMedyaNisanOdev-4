using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBlacklistRepository : IRepository<Blacklist> { }
    public class BlacklistRepository : IBlacklistRepository
    {
        public Task<Blacklist> GetByIdAsync(int id) => throw new NotImplementedException();
        public Task<IEnumerable<Blacklist>> GetAllAsync() => throw new NotImplementedException();
        public Task AddAsync(Blacklist entity) => throw new NotImplementedException();
        public Task UpdateAsync(Blacklist entity) => throw new NotImplementedException();
        public Task DeleteAsync(Blacklist entity) => throw new NotImplementedException();
    }
}
