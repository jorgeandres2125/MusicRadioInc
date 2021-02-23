using MusicRadioStore.Core.Contracts.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicRadioStore.WebUI.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {

        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "El Email no debe estar vacío.", MinimumLength = 3)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "La Identificación debe tener minimo 6 caracteres.", MinimumLength = 6)]
        [Display(Name = "Identificacion")]
        public string Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El password debe tener minimo 6 caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme Password")]
        [Compare("Password", ErrorMessage = "El password y la confirmacion no son iguales.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(100, ErrorMessage = "El Nombre no debe estar vacío.", MinimumLength = 2)]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Dirección")]
        [StringLength(500, ErrorMessage = "La Dirección no debe estar vacío.", MinimumLength = 3)]
        public string Direction { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El Telefono no debe estar vacío.", MinimumLength = 3)]
        [Display(Name = "Telefono")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Este campo es solo numerico")]
        public string Phone { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
