using BlazorMovies.Shared.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository.Interface
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(MovieDTO movie);

        Task DeleteMovie(int Id);

        Task<DetailsMovieDTO> GetDetailsMovieDTO(int id);

        Task<IndexPageDTO> GetIndexPageDTO();

        Task<MovieUpdateDTO> GetMovieForUpdate(int id);

        Task<PaginatedResponse<List<MovieDTO>>> GetMoviesFiltered(FilterMoviesDTO filterMoviesDTO);

        Task UpdateMovie(MovieDTO movie);
    }
}