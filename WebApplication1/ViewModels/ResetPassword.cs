using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class ResetPassword
    {
        public string? Id{ get; set; }
        public string? Username{ get; set; }
        [Required]
        public string? NewPassword{ get; set; }
        [Compare(nameof(NewPassword))]
        [Required]
        public string? ConfirmPassword{ get; set; }
    }
}
