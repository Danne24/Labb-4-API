using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Models
{
    public class Labb4DbContext : DbContext
    {
        public Labb4DbContext(DbContextOptions<Labb4DbContext> options) : base(options)
        {

        }

        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Website> Websites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User { UserID = 1, UserFirstName = "Paul", UserLastName = "Foster", UserAge = 55, UserPhoneNumber = 4608000 });
            modelBuilder.Entity<User>().HasData(new User { UserID = 2, UserFirstName = "Daniel", UserLastName = "Gyrén", UserAge = 25, UserPhoneNumber = 939314 });
            modelBuilder.Entity<User>().HasData(new User { UserID = 3, UserFirstName = "Tobias", UserLastName = "L", UserAge = 36, UserPhoneNumber = 3827202 });
            modelBuilder.Entity<User>().HasData(new User { UserID = 4, UserFirstName = "Anas", UserLastName = "A", UserAge = 32, UserPhoneNumber = 18456759 });
            modelBuilder.Entity<User>().HasData(new User { UserID = 5, UserFirstName = "Alexandra", UserLastName = "Anderson", UserAge = 39, UserPhoneNumber = 69438204 });

            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 1, HobbyName = "Cooking", HobbyDescription = "Cooking and preparing food." });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 2, HobbyName = "Movies", HobbyDescription = "Watching and analysing movies." });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 3, HobbyName = "Programming", HobbyDescription = "Creating and modifying computer programs." });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 4, HobbyName = "Chess", HobbyDescription = "Playing chess." });

            modelBuilder.Entity<Website>().HasData(new Website { WebsiteID = 1, WebsiteLink = "https://www.Food.com/", HobbyID = 1, UserID = 1 });
            modelBuilder.Entity<Website>().HasData(new Website { WebsiteID = 2, WebsiteLink = "https://www.imdb.com/", HobbyID = 2, UserID = 2 });
            modelBuilder.Entity<Website>().HasData(new Website { WebsiteID = 3, WebsiteLink = "https://docs.microsoft.com/en-us/dotnet/csharp/", HobbyID = 3, UserID = 3 });
            modelBuilder.Entity<Website>().HasData(new Website { WebsiteID = 4, WebsiteLink = "https://docs.microsoft.com/en-us/dotnet/csharp/", HobbyID = 3, UserID = 4 });
            modelBuilder.Entity<Website>().HasData(new Website { WebsiteID = 5, WebsiteLink = "https://www.chess.com/", HobbyID = 4, UserID = 5 });
        }
    }
}
