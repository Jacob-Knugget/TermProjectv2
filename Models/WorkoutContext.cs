using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options) : base(options) { }
        public DbSet<Workouts> Plan {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workouts>().HasData(
                new Workouts
                {
                    ID = 1,
                    Name = "Barbell Bench Press",
                    Sets = 4,
                    Reps = 12,
                    Weight = 200
                },
                new Workouts
                {
                    ID = 2,
                    Name = "Dumbbell Fly",
                    Sets = 4,
                    Reps = 12,
                    Weight = 40
                },
                new Workouts
                {
                    ID = 3,
                    Name = "Skullcrusher",
                    Sets = 4,
                    Reps = 12,
                    Weight = 30
                }
            );
        }
    }
}
