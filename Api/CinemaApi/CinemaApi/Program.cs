using CinemaApi.Entities.Context;
using CinemaApi.Entities.Mock;
using CinemaApi.Repository.Movie;
using CinemaApi.Repository.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var context = new CinemaApiContext())
{
    // Temporary mocking of movies
    if (!context.Database.Exists())
    {
        context.Movies.AddRange(Mocker.GetMovies());
        context.SaveChanges();
    }
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
