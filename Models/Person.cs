using System.ComponentModel.DataAnnotations;

namespace FilmAPI.Models
{
    public class Person
    {
        [Key]
        [Required]
        public int PersonId { get; set; }
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(75)]
        public string? Email { get; set; }
        public List<PersonGenre>? PersonGenres { get; set; }
        public List<Rating>? Ratings { get; set; }
        public List<Movie>? Movies { get; set; }

    }
}
