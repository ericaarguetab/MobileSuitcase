using System;
using System.ComponentModel.DataAnnotations;

namespace MobileSuitcase.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El correo electrónico es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo nombre es requerido")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Campo apellido es requerido")]
        public string LastName { get; set; }
    }
}
