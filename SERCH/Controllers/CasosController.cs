using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SERCH.DTO;
using SERCH.DTO.Configuracion;
using SERCH.Models;
using Dapper;
using Microsoft.AspNetCore.Authorization;

namespace SERCH.Controllers
{
    [Authorize]
    public class CasosController : Controller
    {
        private readonly BrainContext _context;

        public CasosController(BrainContext context)
        {
            _context = context;
        }

        public JsonResult BuscarCasos(ParametrosDataTable parametros)
        {
            // Valida que exista la query
            DTO.CustomResponse respuesta = new DTO.CustomResponse();

            if (parametros.query == null)
            {
                respuesta.Success = false;
                respuesta.Mensaje = "Debe agregar un filtro.";
                return Json(respuesta);
            }

            try
            {
                // Cuenta la paginación
                int numeroDePagina;
                int tamanoDePagina = parametros.length;
                int totalDeRegistros = parametros.length;

                if (tamanoDePagina > 0)
                {
                    numeroDePagina = (parametros.start / parametros.length) + 1;
                }
                else
                {
                    numeroDePagina = 1; // Valor predeterminado seguro
                }

                string query = parametros.query;

                var result = _context.Database.GetDbConnection().Query(query);

                respuesta.Success = true;
                respuesta.Mensaje = "Correcto.";
                respuesta.Data = new
                {
                    draw = parametros.draw,
                    recordsTotal = result.Count(),
                    recordsFiltered = result.Count(),
                    result = result.ToList()
                };

                return Json(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.Success = false;
                respuesta.Mensaje = "Error al ejecutar la consulta, por favor revisar que la query esté correctamente construida";
                Console.WriteLine(ex.Message);
                return Json(respuesta);
            }
        }



        public ActionResult ListarCasos(ParametrosDataTable parametros)
        {

            int numeroDePagina;
            int tamanoDePagina = parametros.length;

            if (tamanoDePagina > 0)
            {
                numeroDePagina = (parametros.start / parametros.length) + 1;
            }
            else
            {
                // Establecer numeroDePagina a algún valor predeterminado o manejar el error de alguna otra manera
                numeroDePagina = 1; // Aquí estoy asumiendo que 1 es un valor seguro.
            }

            var query = _context.InpCasos.AsQueryable();


            var data = query
                .Where(a => !string.IsNullOrEmpty(a.InpFolio) && !string.IsNullOrEmpty(a.InpRelatoHecho))
                .OrderBy(a => a.InpFolio)
                .Skip((numeroDePagina - 1) * tamanoDePagina)
                .Take(tamanoDePagina)
                .ToList();



            var commandText = "SELECT COUNT(1) FROM Inp_caso";
            int totalDeRegistros;

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = commandText;
                _context.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    result.Read();
                    totalDeRegistros = result.GetInt32(0);
                }
            }

            return Json(new
            {
                draw = parametros.draw,
                recordsTotal = totalDeRegistros,
                recordsFiltered = totalDeRegistros,
                result = data
            });

        }

        // GET: Casos
        public async Task<IActionResult> Index()
        {
            var query = _context.InpCasos
                .Where(a => !string.IsNullOrEmpty(a.InpFolio) && !string.IsNullOrEmpty(a.InpRelatoHecho))
                .Take(50);

            if (query.Any())
            {
                return View(await query.ToListAsync());
            }
            else
            {
                return Problem("No hay elementos que cumplan con la validación.");
            }
        }


        // GET: Casos/Details/5
        public async Task<IActionResult> Details(string id, ParametrosDataTable parametros)
        {

            //string query = parametros.query; 
            ViewBag.Palabras = parametros.palabras;

            if (id == null || _context.InpCasos == null)
            {
                return NotFound();
            }

            var inpCaso = await _context.InpCasos
                .FirstOrDefaultAsync(m => m.InpFolio == id);
            if (inpCaso == null)
            {
                return NotFound();
            }

            return View(inpCaso);
        }

        public ActionResult BarraQuery()
        {
            return View();
        }
    }
}
