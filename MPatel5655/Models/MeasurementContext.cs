using Microsoft.EntityFrameworkCore;

namespace MPatel5655.Models
{
    public class MeasurementContext : DbContext
    {
        public MeasurementContext(DbContextOptions<MeasurementContext> options) : base(options) { }

        public DbSet<Measurement> Measurements { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Measurement>().HasData(

                new Measurement
                {
                    Id = 1,
                    Systolic = 122,
                    Diastolic = 79,
                    Date = new DateTime(2003, 9, 30),
                    PositionId = "2"

                },
                new Measurement
                {
                    Id = 2,
                    Systolic = 142,
                    Diastolic = 92,
                    Date = new DateTime(1923, 6, 04),
                    PositionId = "3"
                },
                new Measurement
                {
                    Id = 3,
                    Systolic = 181,
                    Diastolic = 121,
                    Date = new DateTime(2013, 2, 02),
                    PositionId = "1"
                }
            );

            modelBuilder.Entity<Position>().HasData(
                    new Position { PositionId = "1", Name = "Standing" },
                    new Position { PositionId = "2", Name = "Sitting" },
                    new Position { PositionId = "3", Name = "Lying down" }
             );

        }

    }
}
