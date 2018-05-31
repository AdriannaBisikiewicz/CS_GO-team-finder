using System.Collections.Generic;
using CS_GO.Domain.Model;

namespace CS_GO.Infrastructure.Services.Interfaces {
    public interface IUserService {
        User GetBySurname (string surname);

        void AddUser (User user);

        IList<User> GetAllUsers ();
    }
}