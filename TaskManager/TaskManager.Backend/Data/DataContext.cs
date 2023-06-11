using Microsoft.EntityFrameworkCore;
using TaskManager.Shared.Entities;

namespace TaskManager.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<PcTask> PcTasks { get; set; }
    }
}
