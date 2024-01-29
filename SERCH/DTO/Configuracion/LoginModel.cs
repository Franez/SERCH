using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SERCH.DTO.Configuracion
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
