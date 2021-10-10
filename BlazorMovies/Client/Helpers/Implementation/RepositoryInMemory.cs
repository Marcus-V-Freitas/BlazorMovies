using BlazorMovies.Client.Helpers.Interface;
using BlazorMovies.Shared.DTOs;
using System;
using System.Collections.Generic;

namespace BlazorMovies.Client.Helpers.Implementation
{
    public class RepositoryInMemory: IRepository
    {
        public List<MovieDTO> GetMovies()
        {
            return new List<MovieDTO>()
    {
                new MovieDTO(){Title = "Spider-Man: Far From Home",
                    ReleaseDate = new DateTime(2019, 7, 2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"
                },
                new MovieDTO(){Title = "Moana",
                    ReleaseDate = new DateTime(2016, 11, 23),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg"
                },
                new MovieDTO(){Title = "Inception",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SY1000_CR0,0,675,1000_AL_.jpg"
                }
            };
        }
    }
}