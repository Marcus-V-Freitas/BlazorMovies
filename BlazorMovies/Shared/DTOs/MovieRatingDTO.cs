using System;

namespace BlazorMovies.Shared.DTOs
{
    public class MovieRatingDTO
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public DateTime RatingDate { get; set; }
        public int MovieId { get; set; }
        public MovieDTO Movie { get; set; }
        public string UserId { get; set; }
    }
}