using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Domain.Entities;
public class User
{

    [Required]
    [MaxLength(16)]
    public String Id { get; set; } = string.Empty;

    [Required (ErrorMessage = "El nonbre es obligatorio" ]
    [MaxLength(25, ErrorMessage = "El nombre no puede tener mas de 25 carácteres.")]
    public string Name { get; set; } = string.Empty;

    [Required (ErrorMessage = "El apellido es obligatorio" ]
    [MaxLength(25, ErrorMessage = "El apellido no puede tener mas de 25 carácteres.")]
    public string Surname { get; set; } = string.Empty;

    [Required (ErrorMessage = "El nonbre de usuario es obligatorio" ]
    [MaxLength(25, ErrorMessage = "El nombre de usuario no puede tener mas de 25 carácteres.")]
    public string User Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    [MaxLength(150, ErrorMessage = "El correo electrónico no puede tener más de 150 carácteres. ")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 carácteres.")]
    [MaxLength(255, ErrorMessage = "La contraseña no puede tener más de 255 caráctes.")]
    public string Password { get; set; } = string.Empty;

    public bool Status { get; set; } = false; 

    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }

    public UserProfeile UserProfile { get; set; } = null!;
    public ICollection<UserRole> UserRoles { get; set; } = [];

    public UserEmail UserEmail { get; set; } = null!;

    public UserPasswordReset UserPasswordReset { get; set; } = null!;
}