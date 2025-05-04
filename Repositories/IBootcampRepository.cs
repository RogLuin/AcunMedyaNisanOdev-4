using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBootcampRepository : IRepository<Bootcamp> { }
    public class BootcampRepository : IBootcampRepository
    {
        public Task<Bootcamp> GetByIdAsync(int id) => throw new NotImplementedException();
        public Task<IEnumerable<Bootcamp>> GetAllAsync() => throw new NotImplementedException();
        public Task AddAsync(Bootcamp entity) => throw new NotImplementedException();
        public Task UpdateAsync(Bootcamp entity) => throw new NotImplementedException();
        public Task DeleteAsync(Bootcamp entity) => throw new NotImplementedException();
    }
}
