using BlazorMovies.Client.Helpers.Interface;
using BlazorMovies.Client.Helpers.Services;
using BlazorMovies.Client.Repository.Interface;
using BlazorMovies.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/people";

        public PersonRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<PersonDTO>>> GetPeople(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<PersonDTO>>(url, paginationDTO);
        }

        public async Task<List<PersonDTO>> GetPeopleByName(string name)
        {
            var response = await httpService.Get<List<PersonDTO>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PersonDTO> GetPersonById(int id)
        {
            return await httpService.GetHelper<PersonDTO>($"{url}/{id}");
        }

        public async Task CreatePerson(PersonDTO person)
        {
            var response = await httpService.Post(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdatePerson(PersonDTO person)
        {
            var response = await httpService.Put(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeletePerson(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}