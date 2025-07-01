using Microsoft.EntityFrameworkCore;
using System.Threading;
using TaskManagerAPI.Models;
using Task = TaskManagerAPI.Models.Task;

namespace TaskManagerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}
