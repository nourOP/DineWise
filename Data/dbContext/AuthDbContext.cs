using DineWise.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DineWise.Data.dbContext
{
    public class AuthDbContext : IdentityDbContext<User>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //seed roles [admin, user]
            var adminRoleId = "DAB19261-D85D-4FF4-AA0C-38CBAA51EFEF";
            var userRoleId = "17425D33-63BB-4ECC-84F4-28B8EB4DC496";
            var superAdminRoleId = "A26EA08B-F97F-48F1-B4B7-6D209E2493F3";

            var roles = new List<IdentityRole>
            {
               new IdentityRole
               {
                   Name = "Admin",
                   NormalizedName = "Admin",
                   Id = adminRoleId,
                   ConcurrencyStamp = adminRoleId
               },

               new IdentityRole
               {
                   Name = "User",
                   NormalizedName = "User",
                   Id = userRoleId,
                   ConcurrencyStamp = userRoleId
               },

               new IdentityRole
               {
                   Name ="SuperAdmin",
                   NormalizedName = "SuperAdmin",
                   Id = superAdminRoleId,
                   ConcurrencyStamp = superAdminRoleId
               }
            };

            //sending roles to database
            builder.Entity<IdentityRole>().HasData(roles);


            //super admin to manage everything : those creds come with the website source code
            var superAdminId = "547D384E-EE3D-4053-AB1B-D0F524B77707";
            var superAdminUser = new IdentityUser
            {
                UserName = "DineWiseSuperAdmin@gmail.com",
                Email = "DineWiseSuperAdmin@gmail.com",
                NormalizedEmail = "DineWiseSuperAdmin@gmail.com".ToUpper(),
                NormalizedUserName = "DineWiseSuperAdmin@gmail.com".ToUpper(),
                Id= superAdminId
            };

            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(superAdminUser, "SuperAdmin@DineWise123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);


            // Add All roles to SuperAdminUser
            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = superAdminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = superAdminId
                }
            };

            //send to db
            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);
        }

    }
}
