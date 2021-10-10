using BlazorMovies.Shared.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository.Interface
{
    public interface IPersonRepository
    {
        Task CreatePerson(PersonDTO person);

        Task DeletePerson(int Id);

        Task<PaginatedResponse<List<PersonDTO>>> GetPeople(PaginationDTO paginationDTO);

        Task<List<PersonDTO>> GetPeopleByName(string name);

        Task<PersonDTO> GetPersonById(int id);

        Task UpdatePerson(PersonDTO person);
    }
}