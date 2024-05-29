using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; } = null!;

        [Required]
        [StringLength(5, MinimumLength = 4)]
        public string Password { get; set; } = null!;
    }
}