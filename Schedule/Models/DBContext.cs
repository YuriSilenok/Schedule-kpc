using Microsoft.EntityFrameworkCore;

namespace Schedule.Models
{
    internal class DBContext : DbContext
    {
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Load> Loads { get; set; }
        public DbSet<LessonType> LessonTypes { get; set; }
        public DbSet<IssuingHours> IssuingHours { get; set; }
        public DbSet<SubGroup> SubGroups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=products.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
