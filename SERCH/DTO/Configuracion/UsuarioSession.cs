using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SERCH.DTO.Configuracion
{
    public class UsuarioSession
    {
        public string UsuarioAD { get; set; }
        public string PassWordAD { get; set; }
        public int RunFun { get; set; }
        public string Nombre { get; set; }
        public string ApeMaterno { get; set; }
        public string ApePaterno { get; set; }

    }
}
