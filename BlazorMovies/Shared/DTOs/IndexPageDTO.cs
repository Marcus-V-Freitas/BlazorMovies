using System.Collections.Generic;

namespace BlazorMovies.Shared.DTOs
{
    public class IndexPageDTO
    {
        public List<MovieDTO> Intheaters { get; set; }
        public List<MovieDTO> UpcomingReleases { get; set; }
    }
}