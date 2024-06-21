using PokeAPI.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Abstraction.Domain.Interface
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(T entity);
        void Update(T entity);
        Task<T?> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
