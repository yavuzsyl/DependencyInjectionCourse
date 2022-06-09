using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDependencyProblem.Data;

namespace TheDependencyProblem.Tests.Unit
{

    //implement in memory or use code based data structure
    public class FakeUserRepository : IUserRepository
    {
        private readonly Dictionary<Guid, User> users = new();

        public FakeUserRepository()
        {
            
        }
        public Task<bool> CreateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return Task.FromResult(users.Values.AsEnumerable());
        }

        public Task<User?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
