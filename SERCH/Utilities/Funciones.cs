using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Configuration;

namespace SERCH.Utilities
{
    public class Funciones
    {
        public static IConfiguration _configuration;
        private static string nodeConfiguration = "Configuration";
        private static string nodeApiAlma = "ApiAlma";


        public static string GetKeyPass()
        {
            string Retorno = "";
            string NodeCompleto = String.Concat("Configuration:", "KeyPass");
            Retorno = _configuration[NodeCompleto].ToString();

            return Retorno;


        }
        public static string GetAmbienteAlma()
        {
            string retunr = "";

            retunr = _configuration["Configuration:ApiAlma:Ambiente"].ToString();

            return retunr;

        }

        public static string GetLinkApiAlma()
        {
            string Retorno = "";
            string Ambiente = GetAmbienteAlma();

            string NodeCompleto = String.Concat(nodeConfiguration, ":", nodeApiAlma, ":", Ambiente);
            Retorno = _configuration[NodeCompleto].ToString();

            return Retorno;
        }

        public static string GetKeyApiAlma()
        {
            string Retorno = "";          
            string NodeCompleto = String.Concat(nodeConfiguration, ":", nodeApiAlma, ":Key");
            Retorno = _configuration[NodeCompleto].ToString();

            return Retorno;
        }
    }
}
