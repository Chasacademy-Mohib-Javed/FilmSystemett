﻿// <auto-generated />
using FilmAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmAPI.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 28,
                            Description = "Explosions",
                            Title = "Action"
                        },
                        new
                        {
                            GenreId = 12,
                            Description = "Adventuretime",
                            Title = "Adventure"
                        },
                        new
                        {
                            GenreId = 16,
                            Description = "Graphic Beauty!",
                            Title = "Animation"
                        },
                        new
                        {
                            GenreId = 35,
                            Description = "Will make you laugh",
                            Title = "Comedy"
                        },
                        new
                        {
                            GenreId = 80,
                            Description = "Watch out!",
                            Title = "Crime"
                        },
                        new
                        {
                            GenreId = 99,
                            Description = "about the world",
                            Title = "Documentary"
                        },
                        new
                        {
                            GenreId = 18,
                            Description = "dramatic",
                            Title = "Drama"
                        },
                        new
                        {
                            GenreId = 10751,
                            Description = "fun for everyone",
                            Title = "Family"
                        },
                        new
                        {
                            GenreId = 14,
                            Description = "Fantastic",
                            Title = "Fantasy"
                        },
                        new
                        {
                            GenreId = 36,
                            Description = "Historical epicness",
                            Title = "History"
                        },
                        new
                        {
                            GenreId = 27,
                            Description = "Horrific",
                            Title = "Horror"
                        },
                        new
                        {
                            GenreId = 10402,
                            Description = "Musical magic",
                            Title = "Music"
                        },
                        new
                        {
                            GenreId = 9648,
                            Description = "Mysterical",
                            Title = "Mystery"
                        },
                        new
                        {
                            GenreId = 10749,
                            Description = "Lovely",
                            Title = "Romance"
                        },
                        new
                        {
                            GenreId = 878,
                            Description = "Lasers",
                            Title = "Science Fiction"
                        },
                        new
                        {
                            GenreId = 10770,
                            Description = "wow tv",
                            Title = "TV Movie"
                        },
                        new
                        {
                            GenreId = 53,
                            Description = "Thrilling",
                            Title = "Thriller"
                        },
                        new
                        {
                            GenreId = 10752,
                            Description = "War",
                            Title = "War"
                        },
                        new
                        {
                            GenreId = 37,
                            Description = "Cowboys",
                            Title = "Western"
                        });
                });

            modelBuilder.Entity("FilmAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FkPersonId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("FkPersonId");

                    b.HasIndex("Link")
                        .IsUnique()
                        .HasFilter("[Link] IS NOT NULL");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("FilmAPI.Models.MovieGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FkGenreId")
                        .HasColumnType("int");

                    b.Property<int>("FkMovieid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FkGenreId");

                    b.HasIndex("FkMovieid");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("FilmAPI.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Email")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("FilmAPI.Models.PersonGenre", b =>
                {
                    b.Property<int>("PersonGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonGenreId"));

                    b.Property<int>("FkGenreId")
                        .HasColumnType("int");

                    b.Property<int>("FkPersonId")
                        .HasColumnType("int");

                    b.HasKey("PersonGenreId");

                    b.HasIndex("FkGenreId");

                    b.HasIndex("FkPersonId", "FkGenreId")
                        .IsUnique();

                    b.ToTable("PersonGenres");
                });

            modelBuilder.Entity("FilmAPI.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"));

                    b.Property<int>("FkMovieId")
                        .HasColumnType("int");

                    b.Property<int>("FkPersonId")
                        .HasColumnType("int");

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("FkMovieId");

                    b.HasIndex("FkPersonId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("FilmAPI.Models.Movie", b =>
                {
                    b.HasOne("FilmAPI.Models.Person", "Persons")
                        .WithMany("Movies")
                        .HasForeignKey("FkPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("FilmAPI.Models.MovieGenre", b =>
                {
                    b.HasOne("FilmAPI.Models.Genre", "Genres")
                        .WithMany("MovieGenres")
                        .HasForeignKey("FkGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmAPI.Models.Movie", "Movies")
                        .WithMany("MovieGenres")
                        .HasForeignKey("FkMovieid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("FilmAPI.Models.PersonGenre", b =>
                {
                    b.HasOne("FilmAPI.Models.Genre", "Genres")
                        .WithMany("PersonGenres")
                        .HasForeignKey("FkGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmAPI.Models.Person", "Persons")
                        .WithMany("PersonGenres")
                        .HasForeignKey("FkPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("FilmAPI.Models.Rating", b =>
                {
                    b.HasOne("FilmAPI.Models.Movie", "Movies")
                        .WithMany("Ratings")
                        .HasForeignKey("FkMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmAPI.Models.Person", "Persons")
                        .WithMany("Ratings")
                        .HasForeignKey("FkPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movies");

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("FilmAPI.Models.Genre", b =>
                {
                    b.Navigation("MovieGenres");

                    b.Navigation("PersonGenres");
                });

            modelBuilder.Entity("FilmAPI.Models.Movie", b =>
                {
                    b.Navigation("MovieGenres");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("FilmAPI.Models.Person", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("PersonGenres");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
