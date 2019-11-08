using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data {
    public class DatingRepository : IDatingRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAll()
        {
            throw new System.NotImplementedException();
        }
    }
}