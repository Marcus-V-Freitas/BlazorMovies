using BlazorMovies.Shared.DTOs;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository.Interface
{
    public interface IRatingRepository
    {
        Task Vote(MovieRatingDTO movieRating);
    }
}