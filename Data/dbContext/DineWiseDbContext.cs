using DineWise.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DineWise.Data.dbContext
{
	public class DineWiseDbContext : DbContext
	{
        //Data Models
		public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationRestaurantTable> ReservationRestaurantTables { get; set; }

        

        //Relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //automatic ID Generation
            modelBuilder.Entity<Restaurant>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<RestaurantTable>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Reservation>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Schedule>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Schedules)
                .WithOne(s => s.Restaurant)
                .HasForeignKey(s => s.RestaurantId);

            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.RestaurantTables)
                .WithOne(t => t.Restaurant)
                .HasForeignKey(t => t.RestaurantId);

            modelBuilder.Entity<Reservation>()
                .HasMany(r => r.RestaurantTables)
                .WithMany()
                .UsingEntity<ReservationRestaurantTable>(
                    j => j.HasOne(rrt => rrt.Reservation).WithMany(r => r.RestaurantTables),
                    //ReservationRestaurantTable record belongs to one Reservation + Reservation might have many associated ReservationRestaurantTable records
                    j => j.HasOne(rrt => rrt.RestaurantTable).WithMany());
                    //ReservationRestaurantTable record belongs to one RestaurantTable + RestaurantTable has many associated ReservationRestaurantTable records
        }


    }
}
