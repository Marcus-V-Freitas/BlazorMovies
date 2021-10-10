using System.Collections.Generic;

namespace BlazorMovies.Shared.DTOs
{
    public class MovieUpdateDTO
    {
        public MovieDTO Movie { get; set; }
        public List<PersonDTO> Actors { get; set; }
        public List<GenreDTO> SelectedGenres { get; set; }
        public List<GenreDTO> NotSelectedGenres { get; set; }
    }
}