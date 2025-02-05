using System.ComponentModel.DataAnnotations;

namespace controlersLoveGame.Models
{
    public class ResetPasswordRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
