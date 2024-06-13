using Microsoft.Identity.Client;
using Super_Advanced_Super_Cool.Context;
using Super_Advanced_Super_Cool.Models;
using Super_Advanced_Super_Cool.Repository.Contracts;

namespace Super_Advanced_Super_Cool.Repository { 
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public User GetUserById(Guid id)
        {
            return _context.Get(id);

        }

        public void Insert(User user)
        {
            _context.Add(user);
        }

        public void Update(User user)
        {
            _context.Update(user);
        }
        public void Remove(User user)
        {
            _context.Remove(user);
        }
    }
}
