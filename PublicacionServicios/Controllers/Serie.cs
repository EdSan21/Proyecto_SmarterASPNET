using Microsoft.AspNetCore.Mvc;
using Model.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PublicacionServicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Serie : ControllerBase
    {
        // GET: api/<Serie>
        [HttpGet("SeriesPopulares")]
        public async Task<IActionResult> SeriesPopulares([FromBody] SerieModel IdSerie)
        {
            try
            {
                var Resultado = "El número de Id es: " + IdSerie.idserie;
                return Ok(Resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el método: ", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("DatosSerie/{id}")]
        public ActionResult<string> DatosSerie(int id)
        {
            return "Datos de la serie";
        }

        [Route("IngresoDirector")]
        [HttpPost]
        public async Task<ActionResult> IngresoDirector([FromBody] Director modelo)
        {
            var resultado = new Respuesta();

            if (modelo.iddirector == 1)
            {
                resultado.id = 1;
                resultado.mensaje_resultado = "Registro insertado.";
            }
            else
            {
                resultado.id = 0;
                resultado.mensaje_resultado = "Error al generar el registro.";
            }
            return Ok(resultado);
        }
    }
}
