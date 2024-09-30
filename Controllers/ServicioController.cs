using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurnoWebApi.Models;
using TurnoWebApi.Services;

namespace TurnoWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicioController : Controller
    {
        private readonly IServicioService _servicioService;
        public ServicioController(IServicioService servicio)
        {
            _servicioService = servicio;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<TServicio> lst = _servicioService.GetServicios();
            if (lst.Count > 0)
            {
                return Ok(lst);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] TServicio servicio)
        {
            if (_servicioService.Save(servicio) == true)
            {
                return Ok("Servicio ingresado con exito");
            }
            else
            {
                return StatusCode(500,"Error al ingresar el servicio");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_servicioService.Delete(id) == true)
            {
                return Ok("Servicio eliminado con exito");
            }
            else
            {
                return BadRequest("Error al eliminar el servicio");
            }
        }
    }
}
