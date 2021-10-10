using System.Collections.Generic;

namespace BlazorMovies.Shared.DTOs
{
    public class DetailsMovieDTO
    {
        public MovieDTO Movie { get; set; }
        public List<GenreDTO> Genres { get; set; }
        public List<PersonDTO> Actors { get; set; }
        public double AverageVote { get; set; }
        public int UserVote { get; set; }
    }
}