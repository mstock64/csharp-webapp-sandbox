using Super_Advanced_Super_Cool.Models;

namespace Super_Advanced_Super_Cool.Services
{
    public interface ITodoService
    {
        void AddTodo(TodoItem item);
        void CreateTodo(TodoItem id);
        List<TodoItem> GetTodos();
    }
}
