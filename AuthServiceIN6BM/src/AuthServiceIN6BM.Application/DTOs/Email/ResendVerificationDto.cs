using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Application.DTOs.Email;

public class ResendVericationDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}