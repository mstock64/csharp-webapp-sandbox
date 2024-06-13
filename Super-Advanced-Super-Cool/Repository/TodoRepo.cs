using Super_Advanced_Super_Cool.Repository.Contracts;
using Super_Advanced_Super_Cool.Context;
using Super_Advanced_Super_Cool.Models;

namespace Super_Advanced_Super_Cool.Repository
{
    public class TodoRepo : ITodoRepo
    {
        private readonly Context.ApplicationContext Context;
        public TodoRepo(Context.ApplicationContext context)
        {
            Context = context;
        }

        public async void Insert()
        {
            Context.Insert();
        }

        public TodoItem Get(int targetId)
        {
            return Context.Get(targetId);
        }
        public List<TodoItem> Get()
        {
            return Context.Get();
        }
        public void Update(TodoItem item)
        {

            Context.Update(item);

        }
        public void Add(TodoItem item)
        {
            Context.Add(item);
        }

    }
}
