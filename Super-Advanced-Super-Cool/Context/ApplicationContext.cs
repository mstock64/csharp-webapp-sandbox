using Microsoft.EntityFrameworkCore;
using Super_Advanced_Super_Cool.Models;
using Super_Advanced_Super_Cool.Utils;

namespace Super_Advanced_Super_Cool.Context
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
        }

        public DbSet<TodoItem> TodoList { get; set; }
        public DbSet<User> UserList { get; set; }

        public async void Insert()
        {
            foreach (var item in TodoSeeder.GetSeeds())
            {
                TodoList.Add(item);
            }
            await SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>();
            modelBuilder.Entity<User>();
        }

        public TodoItem Get(int targetId)
        {
            return TodoList.FirstOrDefault(obj => obj.Id == targetId);
        }
        public List<TodoItem> Get()
        {
            return TodoList.ToList();
        }

        public async void Update(TodoItem item)
        {

            TodoList.Update(item);
            await SaveChangesAsync();
        }

        public User Get(Guid targetId)
        {
            return UserList.FirstOrDefault(item => item.Id == targetId);

        }
        public List<User> GetUsers()
        {
            return UserList.ToList();
        }

        public async void Update(User item)
        {

            UserList.Update(item);
            await SaveChangesAsync();
        }
        public async void Add(TodoItem item)
        {

            TodoList.Add(item);
            SaveChanges();
        }
    }
}
