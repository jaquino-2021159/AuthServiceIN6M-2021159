using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Domain.Entities;
public class UserRole
{
    [Key]
    [MaxLength(16)]

    public string Id { get; set; } = string.Empty;

    [Required]
    [MaxLength(16)]
    public string UserId { get; set; } = string.Empty;

    [Required]
    [MaxLength(16)]
    public String RoleId { get; set; } = string.Empty;

    [Required]
    public User User { get; set; } = null!;

    [Required]
    public Role Role { get; set; } = null!; 

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }
}