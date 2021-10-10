using BlazorMovies.Shared.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository.Interface
{
    public interface IGenreRepository
    {
        Task CreateGenre(GenreDTO genre);

        Task<GenreDTO> GetGenre(int Id);

        Task<List<GenreDTO>> GetGenres();

        Task UpdateGenre(GenreDTO genre);

        Task DeleteGenre(int Id);
    }
}