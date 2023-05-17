using Microsoft.EntityFrameworkCore;

namespace Schedule.Models
{
    internal class DBContext : DbContext
    {
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Load> Loads { get; set; } = null!;
        public DbSet<LessonType> LessonTypes { get; set; } = null!;
        public DbSet<IssuingHours> IssuingHours { get; set; } = null!;
        public DbSet<SubGroup> SubGroups { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.db");
        }
    }
}
