using CompassSurvey.Models;
using Microsoft.EntityFrameworkCore;

namespace CompassSurvey.Data
{
    public class CompassDbContext : DbContext
    {

        public CompassDbContext(DbContextOptions<CompassDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Survey>().HasMany(q => q.Questions).WithOne(sq => sq.Survey).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Question>().HasMany(o => o.Options).WithOne(q => q.Question).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Survey>().Property(x => x.Id).UseIdentityColumn(seed: 100, increment: 1);
            modelBuilder.Entity<Option>().Property(x => x.Id).UseIdentityColumn(seed: 1, increment: 1);
            modelBuilder.Entity<Question>().Property(x => x.Id).UseIdentityColumn(seed: 1000, increment: 1);
        }


        public DbSet<Option> Option { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Survey> Survey { get; set; }
    }
}
