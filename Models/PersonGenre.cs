using System.ComponentModel.DataAnnotations;

namespace FilmAPI.Models
{
    public class PersonGenre
    {
        [Key]
        [Required]
        public int PersonGenreId { get; set; }
        public int FkPersonId { get; set; }
        public int FkGenreId { get; set; }
        public virtual Person? Persons { get; set; }
        public virtual Genre? Genres { get; set; }
        //public virtual Movie? Movies { get; set; }
    }
}
