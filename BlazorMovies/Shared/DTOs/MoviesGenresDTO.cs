namespace BlazorMovies.Shared.DTOs
{
    public class MoviesGenresDTO
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public MovieDTO Movie { get; set; }
        public GenreDTO Genre { get; set; }
    }
}