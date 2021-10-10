namespace BlazorMovies.Shared.DTOs
{
    public class MoviesActorsDTO
    {
        public int PersonId { get; set; }
        public int MovieId { get; set; }
        public PersonDTO Person { get; set; }
        public MovieDTO Movie { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}