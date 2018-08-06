

namespace LearningSystem.Data
{
    using LearningSystem.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;


    public class LearningSystemDbContext : IdentityDbContext
    {
        public LearningSystemDbContext(DbContextOptions<LearningSystemDbContext> options)
             : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public  DbSet<Article>Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder
            //    .Entity<User>()
            //    .HasMany(u => u.Courses)
            //    .WithOne(c=>c.Student)
            //    .HasForeignKey(c => c.StudentId);

            builder.Entity<StudentCourse>()
                .HasKey(st => new { st.CourseId, st.StudentId });

            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Courses)
                .HasForeignKey(sc => sc.StudentId);

            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(sc => sc.CourseId);

            builder.Entity<Course>()
                .HasOne(c => c.Trainer)
                .WithMany(u => u.Trainigns)
                .HasForeignKey(c => c.TrainerId);

            builder.Entity<Article>()
                .HasOne(a => a.Author)
                .WithMany(u => u.Articles)
                .HasForeignKey(a => a.AuthorId);

            base.OnModelCreating(builder);
        }

        


    }
}
