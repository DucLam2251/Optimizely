using System.ComponentModel.DataAnnotations;

namespace New_Project.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
