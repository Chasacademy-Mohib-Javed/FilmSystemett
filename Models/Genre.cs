using System.ComponentModel.DataAnnotations;
namespace FilmAPI.Models
{
    public class Genre
    {
        [Key]
        [Required]
        public int GenreId { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        public List<PersonGenre>? PersonGenres { get; set; }
        public List<MovieGenre>? MovieGenres { get; set; }


    }
}
