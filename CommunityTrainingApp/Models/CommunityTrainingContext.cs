using CommunityTrainingAPI.Models.Authentication;
using CommunityTrainingAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityTrainingAPI.Models
{
    public class CommunityTrainingContext : IdentityDbContext<ApplicationUser>
    {
        public CommunityTrainingContext(DbContextOptions<CommunityTrainingContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrainingPlan>().HasData(
                new TrainingPlan { Id = 1, Name = "Easier", CategoryId = 1, RunningInKms = 5, PushUps = 50, PullUps = 25, LegLifts = 50 },
                new TrainingPlan { Id = 2, Name = "Medium", CategoryId = 2, RunningInKms = 10, PushUps = 100, PullUps = 50, LegLifts = 100 }
                );
            modelBuilder.Entity<ResultsTable>().HasData(
                new ResultsTable {Id = 11, Name = "Adam's result", TrainingPlanId = 1, RuninngResult = 35, PushUpsResult = 4, PullUpsResult = 10, LegLiftsResult = 10 },
                new ResultsTable {Id = 12, Name = "Eve's result", TrainingPlanId = 1, RuninngResult = 30, PushUpsResult = 4, PullUpsResult = 15, LegLiftsResult = 5 },
                new ResultsTable {Id = 21, Name = "Peter's result", TrainingPlanId = 2, RuninngResult = 60, PushUpsResult = 10, PullUpsResult = 20, LegLiftsResult = 15 }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "beginner"},
                new Category { Id = 2, Name = "medium"},
                new Category { Id = 3, Name = "advanced"}
                );
        }

        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<ResultsTable> ResultsTables { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
