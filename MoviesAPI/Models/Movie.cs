using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "O campo titulo e obrigatorio!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "O campo diretor e obrigatorio!")]
        public string Director { get; set; }
        [Required(ErrorMessage = "O campo genero e obrigatorio!")]
        public string Genre { get; set; }
        [Range(1, 600, ErrorMessage = "O campo duracao precisar ter de 0 a 600 minutos!")]
        public int Duration { get; set; }
    }
}
