

using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(Appuser user);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<Appuser>> GetUsresAsync();

        Task<Appuser> GetUserByIdAsync (int id);

        Task<Appuser> GetUserByUsernameAsync (string username);

        Task<IEnumerable<MemberDto>> GetMembersAsync();

        Task<MemberDto> GetMemberAsync(string username);

        
    }
}