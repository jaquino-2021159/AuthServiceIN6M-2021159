using AuthServiceIN6BM.Domain.Entities;
namespace AuthServiceIN6BM.Domain.Interfaces;

public interface IRoleRespository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyCollection<User>> GetUsersByRoleAsync(string roleName);
    Task<IReadOnlyCollection<string>> GetUserRoleNameAsync(string userId);
}