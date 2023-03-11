using Microsoft.EntityFrameworkCore;
using TestProjectEF.Data.DbModels;

namespace TestProjectEF.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubjectDbModel>().HasKey(sc => new { sc.StudentId, sc.TeacherId });
        }
        public DbSet<StudentDbModel> Students { get; set; }
        public DbSet<SubjectDbModel> Subjects { get; set; }
        public DbSet<TeacherDbModel> Teachers { get; set; }
    }
}
