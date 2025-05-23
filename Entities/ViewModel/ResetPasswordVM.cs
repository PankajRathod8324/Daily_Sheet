using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModel;

public class ResetPasswordVM
{  

    public string? Email { get; set; }
    public string? Token {get; set;}
    
    [Required(ErrorMessage = "New password required", AllowEmptyStrings = false)]
    [DataType(DataType.Password)]
    public string? NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Compare("NewPassword", ErrorMessage = "New password and confirm password does not match")]
    public string? ConfirmPassword { get; set; }
}

