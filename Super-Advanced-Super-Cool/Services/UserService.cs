using Super_Advanced_Super_Cool.Models;
using Super_Advanced_Super_Cool.Pages;
using Super_Advanced_Super_Cool.Repository.Contracts;

namespace Super_Advanced_Super_Cool.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository userRepository) { _repository = userRepository; }
        public UserService(string username) { }
        public User Login(String email, String password)
        {
            return new User();
        }
    }
}
