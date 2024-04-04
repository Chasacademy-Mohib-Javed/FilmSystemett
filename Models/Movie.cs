using System.ComponentModel.DataAnnotations;
namespace FilmAPI.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(60)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Link { get; set; }
        public int FkPersonId { get; set; }
        public virtual Person? Persons { get; set; }
        public List<Rating>? Ratings { get; set; }
        //public List<PersonGenre>? PersonGenre { get; set; }
        public List<MovieGenre>? MovieGenres { get; set; }

    }
}
