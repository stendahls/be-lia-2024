using Microsoft.EntityFrameworkCore;

namespace lia_backend.Storage
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public string DbPath { get; }

        public TodoDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "lia-backend.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public bool IsDone { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}