using System.Collections.Generic;
using System.Linq;
using CS_GO.Domain.Model;
using Microsoft.EntityFrameworkCore;
using CS_GO.DataAccess;

namespace CS_GO.Repositories
{
    public class UserRepository
    {
        private LibraryContext _context;
        public UserRepository(LibraryContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public void Add(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public IList<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}