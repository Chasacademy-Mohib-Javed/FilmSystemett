using FilmAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PersonGenre> PersonGenres { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2TAA998; Initial Catalog=MovieAPI2;Integrated Security=true; TrustServerCertificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonGenre>()
                .HasOne(pg => pg.Persons)
                .WithMany(pg => pg.PersonGenres)
                .HasForeignKey(fkp => fkp.FkPersonId);
            modelBuilder.Entity<PersonGenre>()
                .HasOne(persg => persg.Genres)
                .WithMany(persg => persg.PersonGenres)
                .HasForeignKey(persfk => persfk.FkGenreId);
            modelBuilder.Entity<Rating>()
                .HasOne(pr => pr.Persons)
                .WithMany(pr => pr.Ratings)
                .HasForeignKey(pr => pr.FkPersonId);
            modelBuilder.Entity<Rating>()
                .HasOne(pm => pm.Movies)
                .WithMany(pm => pm.Ratings)
                .HasForeignKey(pmfk => pmfk.FkMovieId);
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movies)
                .WithMany(mg => mg.MovieGenres)
                .HasForeignKey(mg => mg.FkMovieid);
            modelBuilder.Entity<MovieGenre>()
                .HasOne(gmg => gmg.Genres)
                .WithMany(gmg => gmg.MovieGenres)
                .HasForeignKey(gmg => gmg.FkGenreId);
            modelBuilder.Entity<Movie>()
                .HasOne(p => p.Persons)
                .WithMany(p => p.Movies)
                .HasForeignKey(p => p.FkPersonId);

            modelBuilder.Entity<Genre>().HasData(new Genre[] {
                new Genre{GenreId=28,Title="Action", Description="Explosions"},
                new Genre{GenreId=12,Title="Adventure", Description="Adventuretime"},
                new Genre{GenreId=16,Title="Animation", Description="Graphic Beauty!"},
                new Genre{GenreId=35,Title="Comedy", Description="Will make you laugh"},
                new Genre{GenreId=80,Title="Crime", Description="Watch out!"},
                new Genre{GenreId=99,Title="Documentary", Description="about the world"},
                new Genre{GenreId=18,Title="Drama", Description="dramatic"},
                new Genre{GenreId=10751,Title="Family", Description="fun for everyone"},
                new Genre{GenreId=14,Title="Fantasy", Description="Fantastic"},
                new Genre{GenreId=36,Title="History", Description="Historical epicness"},
                new Genre{GenreId=27,Title="Horror", Description="Horrific"},
                new Genre{GenreId=10402,Title="Music", Description="Musical magic"},
                new Genre{GenreId=9648,Title="Mystery", Description="Mysterical"},
                new Genre{GenreId=10749,Title="Romance", Description="Lovely"},
                new Genre{GenreId=878,Title="Science Fiction", Description="Lasers"},
                new Genre{GenreId=10770,Title="TV Movie", Description="wow tv"},
                new Genre{GenreId=53,Title="Thriller", Description="Thrilling"},
                new Genre{GenreId=10752,Title="War", Description="War"},
                new Genre{GenreId=37,Title="Western", Description="Cowboys"}
            });
            modelBuilder.Entity<PersonGenre>()
                .HasIndex(persg => new { persg.FkPersonId, persg.FkGenreId }).IsUnique();
            modelBuilder.Entity<Movie>().HasIndex(pm => new { pm.Link }).IsUnique();
        }
    }

}


