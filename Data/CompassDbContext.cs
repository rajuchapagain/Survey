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

            modelBuilder.Entity<SurveyQuestion>().HasMany(u => u.Questions);
            modelBuilder.Entity<Question>().HasMany(u => u.Options);
            modelBuilder.Entity<SurveyAnswer>().HasOne(u => u.SelectedOption);
            modelBuilder.Entity<SurveyAnswer>().HasMany(u => u.Options);


        }


        public DbSet<Option> Option { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestion { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswer { get; set; }
    }
}
