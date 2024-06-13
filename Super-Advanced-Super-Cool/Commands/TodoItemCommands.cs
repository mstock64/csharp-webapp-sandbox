using Super_Advanced_Super_Cool.Context;
using Super_Advanced_Super_Cool.Models;

namespace Super_Advanced_Super_Cool.Commands
{
    public class TodoItemCommands: ITodoItemCommands
    {
        private readonly ApplicationContext _context;
        public TodoItemCommands(ApplicationContext context)
        {
            _context = context;
        }

        public List<TodoItem> FilterByOldest()
        {
            return
                (from li in _context.TodoList
                 orderby li.CreatedDate ascending
                 select li).ToList();
        }
        public List<TodoItem> FilterByLatest()
        {
            return
                (from li in _context.TodoList
                 orderby li.CreatedDate descending
                 select li).ToList();
        }
        public List<TodoItem> FilterByCompleted()
        {
            return
                (from li in _context.TodoList
                 where li.Status == status.DONE
                 orderby li.CreatedDate descending
                 select li).ToList();
        }
    }
}
