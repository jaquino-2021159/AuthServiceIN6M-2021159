using System.ComponentModel.DataAnnotations;
namespace AuthServiceIN6BM.Application.DTOs;

public class LoginDto
{
    [Required]
    public string EmailOrUser { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}