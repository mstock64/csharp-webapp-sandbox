using Super_Advanced_Super_Cool.Models;
using Super_Advanced_Super_Cool.Repository.Contracts;

namespace Super_Advanced_Super_Cool.Services
{
    public class TodoService: ITodoService
    {
        private readonly ITodoRepo _todoRepo;
        public TodoService(ITodoRepo todoRepo) { _todoRepo = todoRepo; }
        public List<TodoItem> GetTodos()
        {
            return _todoRepo.Get();
        }
        public void DeleteTodo(string id) { }
        public void CreateTodo(TodoItem id) { }

        public void AddTodo(TodoItem item) {
            _todoRepo.Add(item);
        }
    }
}
