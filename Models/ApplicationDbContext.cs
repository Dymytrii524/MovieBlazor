using Microsoft.EntityFrameworkCore;

namespace MoviesBlazor.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Desc { get; set; }
        public string? Poster { get; set; }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Poster = "C://Users//Dymytrii//Downloads/saw.jpeg",
                    Title = "Saw",
                    Genre = "Body Horror",
                    ReleaseYear = 2004,
                    Director = "James Wan",
                    Desc = "Two men awaken to find themselves on the opposite sides of a dead body, each with specific instructions to kill the other, escape or face the consequences. These two are the latest contestants in Jigsaw's games."
                },
                new Movie
                {
                    Poster = "/images/now-you-see-me.jpeg",
                    Id = 2,
                    Title = "Now You See Me",
                    Genre = "Heist",
                    ReleaseYear = 2013,
                    Director = "Louis Leterrier",
                    Desc = "An FBI agent and an Interpol detective track a team of illusionists..."
                },
                new Movie
                {
                    Poster = "C://Users//Dymytrii//Downloads/avengers.jpeg",
                    Id = 3,
                    Title = "Avengers",
                    Genre = "Superhero fiction",
                    ReleaseYear = 2012,
                    Director = "Joss Whedon",
                    Desc = "In the film, Nick Fury and the spy agency S.H.I.E.L.D. recruit Tony Stark, Steve Rogers, Bruce Banner, Thor, Natasha Romanoff, and Clint Barton to form a team capable of stopping Thor's brother Loki from subjugating Earth."
                }
            );
        }
    }
}
