using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Summary { get; set; }
        public bool InTheaters { get; set; }
        public string Trailer { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        public string Poster { get; set; }
        public List<MoviesGenresDTO> MoviesGenres { get; set; } = new List<MoviesGenresDTO>();
        public List<MoviesActorsDTO> MoviesActors { get; set; } = new List<MoviesActorsDTO>();

        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                {
                    return null;
                }

                if (Title.Length > 60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }
    }
}