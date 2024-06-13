using Super_Advanced_Super_Cool.Models;

namespace Super_Advanced_Super_Cool.Repository.Contracts
{
    public interface IUserRepository
    {
        void Update(User user);
        void Insert(User user);
        User GetUserById(Guid id);
        void Remove(User user);
    }
}
