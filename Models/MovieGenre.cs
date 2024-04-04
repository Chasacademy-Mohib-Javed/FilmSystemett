using System.ComponentModel.DataAnnotations;
namespace FilmAPI.Models
{
    public class MovieGenre
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int FkGenreId { get; set; }
        public int FkMovieid { get; set; }
        public virtual Genre? Genres { get; set; }
        public virtual Movie? Movies { get; set; }
    }
}
