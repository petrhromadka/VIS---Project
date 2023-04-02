using System.Data.Entity;
using CinemaApi.Entities.Configuration;
using CinemaApi.Entities.Entities;

namespace CinemaApi.Entities.Context
{
    public class CinemaApiContext : DbContext
    {
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserEvent> UserEvents { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }


        public CinemaApiContext() : base("CinemaApi")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CinemaApiContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelConfiguration.Configure(modelBuilder);
        }
    }
}
