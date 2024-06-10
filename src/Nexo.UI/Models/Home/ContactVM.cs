using System.ComponentModel.DataAnnotations;

namespace Nexo.UI.Models.Home;

public class ContactVM
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "O email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O email não é válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O assunto é obrigatório.")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "A mensagem é obrigatória.")]
    public string Body { get; set; } = string.Empty;
}
