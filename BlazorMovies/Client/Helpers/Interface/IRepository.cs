using BlazorMovies.Shared.DTOs;
using System.Collections.Generic;

namespace BlazorMovies.Client.Helpers.Interface
{
    public interface IRepository
    {
        List<MovieDTO> GetMovies();
    }
}