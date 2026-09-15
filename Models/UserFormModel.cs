using System.ComponentModel.DataAnnotations;

namespace AspNetAjaxForm.Models;

public class UserFormModel
{
    [Required(ErrorMessage = "Имя обязательно")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email обязателен")]
    [EmailAddress(ErrorMessage = "Некорректный email")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Сообщение обязательно")]
    public string Message { get; set; } = string.Empty;
}
