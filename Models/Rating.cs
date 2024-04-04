using System.ComponentModel.DataAnnotations;
namespace FilmAPI.Models
{
    public class Rating
    {
        [Key]
        [Required]
        public int RatingId { get; set; }
        public int Ratings { get; set; }
        public int FkPersonId { get; set; }
        public int FkMovieId { get; set; }

        public virtual Person? Persons { get; set; }
        public virtual Movie? Movies { get; set; }

    }
}
