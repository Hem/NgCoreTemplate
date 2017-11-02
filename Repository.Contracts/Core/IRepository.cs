using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Contracts.Core
{
    public interface IRepository
    {
         
    }

    public interface IRepositoryAsync<T> : IRepository where T:new()
    {
        Task<IEnumerable<T>> Find(FindParam filter);
        Task<T> GetById(int id);  
        Task<T> Create(T dto);
        Task<T> Update(T dto);
    }


}