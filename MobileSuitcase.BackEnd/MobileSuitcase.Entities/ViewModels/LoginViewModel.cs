namespace MobileSuitcase.Entities.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {

        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Password { get; set; }
    }
}
