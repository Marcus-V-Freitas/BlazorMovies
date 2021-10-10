using BlazorMovies.Shared.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository.Interface
{
    public interface IUsersRepository
    {
        Task AssignRole(EditRoleDTO editRole);

        Task<List<RoleDTO>> GetRoles();

        Task<PaginatedResponse<List<UserDTO>>> GetUsers(PaginationDTO paginationDTO);

        Task RemoveRole(EditRoleDTO editRole);
    }
}