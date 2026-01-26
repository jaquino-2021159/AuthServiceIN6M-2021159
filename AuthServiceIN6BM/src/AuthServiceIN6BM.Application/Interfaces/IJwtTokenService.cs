using AuthServiceIN6BM.Domain.Entities;

namespace AuthServiceIN6BM.Application.Interfaces;

public interface IJwTokenService
{
    string GenerateToken (User user);
}