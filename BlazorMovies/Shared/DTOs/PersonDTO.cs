using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorMovies.Shared.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }

        public List<MoviesActorsDTO> MoviesActors { get; set; } = new List<MoviesActorsDTO>();

        [NotMapped]
        public string Character { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is PersonDTO p2)
            {
                return Id == p2.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}