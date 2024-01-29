using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using SERCH.DTO.Configuracion;
using SERCH.Models;
using SERCH.Servicios;
using SERCH.Utilities;
using System.Diagnostics;
using System.Reflection;
using System.Security.Claims;
using System.Net;

namespace SERCH.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;       
        public IHttpContextAccessor _accessor;
        private readonly IMemoryCache _cache;
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor, IMemoryCache cache)
        {
            _logger = logger;
            _accessor = accessor;
            _cache = cache;
        }

        public IActionResult Index()
        {

            UsuarioSession _usuarioSession = new UsuarioSession();
            if (HttpContext.Session.GetString("_UsuarioSession") != null)
            {
                _usuarioSession = JsonConvert.DeserializeObject<UsuarioSession>(HttpContext.Session.GetString("_UsuarioSession").ToString());

                if (_usuarioSession == null) return View("LogIn");
                else
                {


                }
                return RedirectToAction("Index","Casos");
            }
            else
            {
                return View("LogIn");
            }
        }

        public IActionResult LogIn()
        {

            return View();
        
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public JsonResult LogInUsr(LoginModel model)
        {

            
            CustomResponse customResponse = new CustomResponse();
            UsuarioSession _usuarioSession = new UsuarioSession();
            List<FuncionarioAplicacion> funcionariosPermitido;

            _usuarioSession.UsuarioAD = model.UserName;
            _usuarioSession.PassWordAD = Security.Encrypt(model.Password); // Encriptamos clave

            

            HttpContext.Session.SetString("_UsuarioSession", JsonConvert.SerializeObject(_usuarioSession));

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var _ApiAlma = APIAlma.GetInfoFuncionarioLogin(_usuarioSession);
            if (_ApiAlma.Success)
            {
                foreach (var item in _ApiAlma.Result)
                {
                    _usuarioSession.RunFun = item.Rut_Fun;
                }


                var rutUser = _usuarioSession.RunFun;
                using (var dbContext = new BrainContext())
                {
                    funcionariosPermitido = dbContext.FuncionarioAplicacions
                        .Where(f => f.ApliNro == 14 && f.ApliFunActivo == 1 && f.ApliFunPerfil >= 41 && f.PerFunRut == rutUser)
                        .ToList();
                }
                HttpContext.Session.SetString("_UsuarioSession", JsonConvert.SerializeObject(_usuarioSession));

                if (funcionariosPermitido.Count > 0)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, _usuarioSession.UsuarioAD),

                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    AuthenticationProperties p = new();

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), p);

                    customResponse.Cod = 1;
                    customResponse.Desc = "Correcto.";
                    customResponse.Success = true;
                }
                else
                {
                    customResponse.Cod = 0;
                    customResponse.Desc = "No posee permisos para ingresar.";
                    customResponse.Success = false;
                }

              
            }
            else
            {
                //matar la sesion creada al inicio de la funcion.
                customResponse.Cod = 0;
                customResponse.Desc = "Usuario y/o Contraseña no valido.";
                customResponse.Success = false;
            }

            var json = Json(customResponse);
            return json;
        }




    }
}