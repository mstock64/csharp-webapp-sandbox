using Super_Advanced_Super_Cool.Models;

namespace Super_Advanced_Super_Cool.Commands
{
    public interface ITodoItemCommands
    {
        List<TodoItem> FilterByOldest();
        List<TodoItem> FilterByLatest();
        List<TodoItem> FilterByCompleted();
    }
}
