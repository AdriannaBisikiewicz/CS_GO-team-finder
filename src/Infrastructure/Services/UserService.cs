using System.Collections.Generic;
using System.Linq;
using CS_GO.Domain.Model;
using CS_GO.Infrastructure.Services.Interfaces;
using CS_GO.Repositories.Interfaces;

namespace CS_GO.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void AddUser(User user)
        {
            _repository.Add(user);
        }

        public User GetBySurname(string surname)
        {
            return _repository.GetAll().Where(x=>x.Login.Equals(surname)).FirstOrDefault();
        }

        public IList<User> GetAllUsers ()
        {
            return _repository.GetAll().ToList();
        }
    }
}