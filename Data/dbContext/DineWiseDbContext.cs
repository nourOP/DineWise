using DineWise.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DineWise.Data.dbContext
{
	public class DineWiseDbContext : DbContext
	{
        public DineWiseDbContext(DbContextOptions<DineWiseDbContext> options):base(options)
        {
                
        }

        //Relationships + many to many relationship handling
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //many-to-many user + roles
            modelBuilder.Entity<Join_UserRole>()
                .HasOne(x => x.Role)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(x => x.RoleId);
            modelBuilder.Entity<Join_UserRole>()
                .HasOne(x => x.User)
                .WithMany(y=>y.UserRoles)
                .HasForeignKey(x => x.UserId);

            //many to many table + reservation
            modelBuilder.Entity<Join_ReservationRestaurantTable>()
                .HasOne(r => r.Reservation)
                .WithMany(rrt => rrt.ReservationRestaurantTables)
                .HasForeignKey(r => r.ReservationId);
            modelBuilder.Entity<Join_ReservationRestaurantTable>()
               .HasOne(rt => rt.RestaurantTable)
               .WithMany(rrt => rrt.ReservationRestaurantTables)
               .HasForeignKey(rt => rt.RestaurantTableId);

            //many to many table + feature
            modelBuilder.Entity<Join_RestaurantTableFeature>()
               .HasOne(x => x.Feature)
               .WithMany(y => y.RestaurantTableFeatures)
               .HasForeignKey(x => x.FeatureId);
            modelBuilder.Entity<Join_RestaurantTableFeature>()
                .HasOne(x => x.RestaurantTable)
                .WithMany(y => y.RestaurantTableFeatures)
                .HasForeignKey(x => x.RestaurantTableId);


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

            modelBuilder.Entity<OverwrittenSchedule>()
               .Property(s => s.Id)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
               .Property(s => s.Id)
               .ValueGeneratedOnAdd();



            //no key for audit records
            modelBuilder.Entity<AuditRecords>().HasNoKey();

        }



        //Data Models
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Join_ReservationRestaurantTable> ReservationRestaurantTables { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Join_RestaurantTableFeature> RestaurantTableFeatures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Join_UserRole> UserRoles { get; set; }


        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            /* modelBuilder.Entity<Restaurant>()
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
            */
            //ReservationRestaurantTable record belongs to one RestaurantTable + RestaurantTable has many associated ReservationRestaurantTable records
        //} 
        //ily nour<3


    }
}


