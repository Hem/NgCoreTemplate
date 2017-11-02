using Repository.Contracts;
using Repository.Contracts.Core;
using Repository.Contracts.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleNet.Standard.Data;

namespace Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(ISimpleDatabaseProvider db) : base(db)
        {
        }

        public Task<User> Create(User dto)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> Find(FindParam filter)
        {
            IEnumerable<User> users = new [] {
                new User { Id = 0, FirstName = "Hem", LastName = "Talreja" },
                new User { Id = 1, FirstName = "Jeff", LastName = "Stansberry" }
            };
            
            return Task.FromResult(users);
        }

        public Task<User> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Update(User dto)
        {
            throw new System.NotImplementedException();
        }
    }
}