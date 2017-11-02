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
        public UserRepository(ISimpleDataAccessLayer database) : base(database)
        {
        }

        public Task<User> Create(User dto)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> Find(FindParam filter)
        {
            throw new System.NotImplementedException();
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