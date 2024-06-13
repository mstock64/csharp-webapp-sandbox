using Super_Advanced_Super_Cool.Models;

namespace Super_Advanced_Super_Cool.Repository.Contracts
{
    public interface ITodoRepo
    {
        void Insert();
        List<TodoItem> Get();
        TodoItem Get(int targetId);
        void Update(TodoItem item);
        void Add(TodoItem item);
    }

}
