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
            ConfigureSeats(modelBuilder);
            ConfigureHalls(modelBuilder);
            ConfigureReservations(modelBuilder);
        }

        private static void ConfigureHalls(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hall>()
                .Property(h => h.Id)
                .HasColumnOrder(1)
                .IsRequired();

            modelBuilder.Entity<Hall>()
                .Property(h => h.Name)
                .HasColumnOrder(2)
                .HasMaxLength(15)
                .IsRequired();

            modelBuilder.Entity<Hall>()
                .HasMany(h => h.Seats);

            modelBuilder.Entity<Hall>()
                .ToTable(TableNames.HallsTable);
        }

        private static void ConfigureReservations(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .Property(r => r.Id)
                .HasColumnOrder(1)
                .IsRequired();

            modelBuilder.Entity<Reservation>()
                .Property(r => r.CustomerName)
                .HasColumnOrder(2)
                .HasMaxLength(128)
                .IsRequired();

            modelBuilder.Entity<Reservation>()
                .Property(r => r.CustomerEmail)
                .HasColumnOrder(3)
                .HasMaxLength(512)
                .IsOptional();

            modelBuilder.Entity<Reservation>()
                .Property(r => r.CustomerPhone)
                .HasColumnOrder(4)
                .HasMaxLength(64)
                .IsRequired();

            modelBuilder.Entity<Reservation>()
                .Property(r => r.TotalPrice)
                .HasColumnOrder(5)
                .IsRequired();

            modelBuilder.Entity<Reservation>()
                .Property(r => r.SeatReservations)
                .HasColumnOrder(6)
                .HasMaxLength(4096)
                .IsRequired();
        }

        private static void ConfigureSeats(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seat>()
                .Property(s => s.Id)
                .HasColumnOrder(1)
                .IsRequired();

            modelBuilder.Entity<Seat>()
                .Property(s => s.Row)
                .HasColumnOrder(2)
                .IsRequired();

            modelBuilder.Entity<Seat>()
                .Property(s => s.SeatNumber)
                .HasColumnOrder(3)
                .IsRequired();

            modelBuilder.Entity<Seat>()
                .Property(s => s.IsTaken)
                .HasColumnOrder(4)
                .IsRequired();

            modelBuilder.Entity<Seat>()
                .ToTable(TableNames.SeatsTable);
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
    }
}
