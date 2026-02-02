using AuthServiceIN6BM.Domain.Entities;
namespace AuthServiceIN6BM.Domain.Interfaces;

public interface IRoleRespository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyList<User>> GetUsersByRoleAsync(string roleName);
    Task<IReadOnlyList<string>> GetUserRoleNameAsync(string userId);
}