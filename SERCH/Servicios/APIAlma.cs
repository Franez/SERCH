using Newtonsoft.Json;
using SERCH.DTO.Configuracion;
using SERCH.Models.ApiAlma;
using SERCH.Utilities;
using System.Text;

namespace SERCH.Servicios
{
    public class APIAlma
    {
        private static UsuarioSession _session;
        public static HttpContext _httpContexto { get; set; }

        private static string _errorEJecucion = "";

        #region Generacion de token del usuario para consultas al servicio api alma
        private static RespHttpClient ClientHeadersAutenticated()
        {
            RespHttpClient respHttpClient = new RespHttpClient();
            _httpContexto = WebHelpers.HttpContext;

            HttpClient cliente = new HttpClient();

            var tokeenn = Token();
            if (tokeenn != null)
            {
                cliente = new HttpClient();
                cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokeenn);

                respHttpClient.Success = true;
                respHttpClient.HttpClientRes = cliente;
                respHttpClient.Cod = 1;
                respHttpClient.Desc = "Correcto.";
            }
            else
            {
                respHttpClient.Success = false;
                respHttpClient.HttpClientRes = null;
                respHttpClient.Cod = 0;
                respHttpClient.Desc = _errorEJecucion;
            }


            return respHttpClient;
        }

        private static string Token()
        {
            string token = null;
            ResTokenAlma _sessionTokenAlma = new ResTokenAlma();

            if (_httpContexto.Session.GetString("_TokenAlma") != null)
            {
                _sessionTokenAlma = JsonConvert.DeserializeObject<ResTokenAlma>(_httpContexto.Session.GetString("_TokenAlma").ToString());

                if (_sessionTokenAlma.Token != null && _sessionTokenAlma.Expired != null)
                {

                    DateTime D_fecha_ = new DateTime();
                    DateTime L_fecha = new DateTime();

                    if (DateTime.TryParse(_sessionTokenAlma.Expired.ToString(), out D_fecha_))
                    {
                        L_fecha = D_fecha_;
                    }

                    if (DateTime.Now > L_fecha)
                    {
                        var result_ = GetToken();
                        if (result_.Success)
                        {
                            token = result_.Result.Token;
                            _sessionTokenAlma.Token = token;
                            _sessionTokenAlma.Expired = DateTime.Now;
                        }
                    }
                    else
                    {
                        token = _sessionTokenAlma.Token;
                    }
                }
                else
                {
                    var result_ = GetToken();

                    if (result_.Success)
                    {
                        _sessionTokenAlma.Expired = result_.Result.Expired;
                        _sessionTokenAlma.Token = result_.Result.Token;
                        token = result_.Result.Token;
                        _httpContexto.Session.SetString("_TokenAlma", JsonConvert.SerializeObject(_sessionTokenAlma));
                    }


                }
            }
            else
            {
                var result_ = GetToken();
                if (result_.Success)
                {
                    _sessionTokenAlma.Expired = result_.Result.Expired;
                    _sessionTokenAlma.Token = result_.Result.Token;
                    token = result_.Result.Token;
                    _httpContexto.Session.SetString("_TokenAlma", JsonConvert.SerializeObject(_sessionTokenAlma));
                }
                else
                {
                    _errorEJecucion = result_.Result.Mensaje;
                }


            }
            // _httpContext.Session.SetString("_TokenAlmaUsr", JsonConvert.SerializeObject(_usuarioSession));

            return token;
        }

        private static ResGetTokenAlma GetToken()
        {
            ResGetTokenAlma resp_ = null;
            ReqGetTokenAlma data = new ReqGetTokenAlma();
            if (_httpContexto.Session.GetString("_UsuarioSession") != null)
            {
                _session = JsonConvert.DeserializeObject<UsuarioSession>(_httpContexto.Session.GetString("_UsuarioSession"));
            }
            else
            {
                resp_ = new ResGetTokenAlma();
                resp_.Success = false;
                return resp_;
            }


            data.ContraseñaFun = Security.Decrypt(_session.PassWordAD);
            data.KeySistema = Funciones.GetKeyApiAlma();
            data.UsuarioAD = _session.UsuarioAD;

            try
            {
                string servicio = "api/Login/LoginJWT";
                string jsoninfo = "";

                using (var cliente = new HttpClient())
                {
                    var post_data = data;
                    var url = Funciones.GetLinkApiAlma();
                    url = url + servicio;

                    string contentType = "application/json";
                    var serializedCustomer = JsonConvert.SerializeObject(post_data);
                    var content = new StringContent(serializedCustomer, Encoding.UTF8, contentType);

                    cliente.BaseAddress = new Uri(url);
                    cliente.DefaultRequestHeaders.Accept.Clear();
                    cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var respuesta = cliente.PostAsync(url, content);
                    var datos = respuesta.Result.Content.ReadAsStringAsync().Result.ToString();
                    jsoninfo = datos;
                }
                resp_ = JsonConvert.DeserializeObject<ResGetTokenAlma>(jsoninfo);
                return resp_;
            }
            catch (Exception)
            {
                resp_ = new ResGetTokenAlma();
                resp_.Success = false;
                return resp_;
            }
        }

        #endregion

        public static ResGetInfoFuncionarioRut GetInfoFuncionarioLogin(UsuarioSession usuarioSession)
        {
            ResGetInfoFuncionarioRut Imagenes = new ResGetInfoFuncionarioRut();
            string servicio = "api/Funcionario/InfoFuncionarioLogin";
            string jsoninfo = "";

            try
            {
                var ResCliente = ClientHeadersAutenticated();
                if (ResCliente.Success)
                {
                    using (var cliente = ResCliente.HttpClientRes)
                    {

                        var post_data = new { usuarioAD = usuarioSession.UsuarioAD, contraseñaFun = Security.Decrypt(usuarioSession.PassWordAD) };

                        var url = Funciones.GetLinkApiAlma();
                        url = url + servicio;

                        string contentType = "application/json";
                        var serializedCustomer = JsonConvert.SerializeObject(post_data);
                        var content = new StringContent(serializedCustomer, Encoding.UTF8, contentType);

                        cliente.BaseAddress = new Uri(url);
                        cliente.DefaultRequestHeaders.Accept.Clear();
                        cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                        var respuesta = cliente.PostAsync(url, content);
                        var datos = respuesta.Result.Content.ReadAsStringAsync().Result.ToString();
                        jsoninfo = datos;

                    }
                    Imagenes = JsonConvert.DeserializeObject<ResGetInfoFuncionarioRut>(jsoninfo);


                }
                else
                {
                    Imagenes.Success = false;
                    Imagenes.Code = 0;
                    Imagenes.Description = ResCliente.Desc;
                }

                return Imagenes;

            }
            catch (Exception ex)
            {
                Imagenes = new ResGetInfoFuncionarioRut();
                Imagenes.Code = 1;
                Imagenes.Description = ex.Message.ToString();
                Imagenes.Success = false;
                return Imagenes;
            }
        }

    }
}
