using System.Data.Entity;
using CinemaApi.Entities.Entities;

namespace CinemaApi.Entities.Configuration
{
    public class ModelConfiguration
    {

        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigureEvents(modelBuilder);
            ConfigureMovies(modelBuilder);
            ConfigureUsers(modelBuilder);
            ConfigureUserEvents(modelBuilder);
        }

        private static void ConfigureUsers(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .HasColumnOrder(1)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .HasColumnOrder(2)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.PasswordHash)
                .HasColumnOrder(3)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.PasswordSalt)
                .HasColumnOrder(4)
                .IsRequired();

            modelBuilder.Entity<User>()
                .ToTable(TableNames.UsersTable);
        }

        private static void ConfigureEvents(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Event>()
                .Property(ev => ev.Id)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(ev => ev.DateTime)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(ev => ev.Price)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(ev => ev.Hall)
                .HasMaxLength(15)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .ToTable(TableNames.EventsTable);
        }

        private static void ConfigureMovies(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Id)
                .HasColumnOrder(1)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Title)
                .HasMaxLength(50)
                .HasColumnOrder(2)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Genre)
                .HasColumnOrder(3)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Duration)
                .HasColumnOrder(4)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Rating)
                .HasColumnOrder(5)
                .IsOptional();

            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Director)
                .HasColumnOrder(6)
                .HasMaxLength(50);


            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Description)
                .HasColumnOrder(7)
                .HasMaxLength(3000)
                .IsOptional();

            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Thumbnail)
                .HasColumnOrder(8)
                .HasMaxLength(200)
                .IsOptional();

            modelBuilder.Entity<Movie>()
                .ToTable(TableNames.MoviesTable);
        }

        private static void ConfigureUserEvents(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEvent>()
                .Property(ue => ue.Id)
                .HasColumnOrder(1)
                .IsRequired();

            modelBuilder.Entity<UserEvent>()
                .ToTable(TableNames.UserEventsTable);
        }
    }
}
