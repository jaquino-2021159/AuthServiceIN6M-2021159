using Sytem.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Domain.Entities;

public class UserProfile 
{
    [key]
    [MaxLength(16)]
    public string Id  get; set; } = string.Empty;

    [Required]
    [MaxLength(16)]
    public string UserId { get; set; } = string.Empty;

    [MaxLength(512)]
    public string ProfilePicture { get; set; } = string.Empty;

    [Required]
    [StringLength(8, MininumLength = 8, ErrorMessage = "El numero de teléfono debe tener exactamente 8 dígitos.")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "El teléfono solo debe tener números.") ]
    public string Phone { get; set; } = string.Empty;
    
    [Required]
    public User User { get; set; } = null!;
}