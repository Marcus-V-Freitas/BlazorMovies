using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.DTOs
{
    public class GenreDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

        public List<MoviesGenresDTO> MoviesGenres { get; set; } = new List<MoviesGenresDTO>();
    }
}