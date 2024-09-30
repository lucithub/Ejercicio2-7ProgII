using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurnoWebApi.Models;
using TurnoWebApi.Services;

namespace TurnoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TurnoController : Controller
    {
        public ITurnoService _turnoService;
        public TurnoController(ITurnoService turnoService)
        {
            _turnoService = turnoService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            // FALTA VALIDAR ETC ETC ETC
            return Ok(_turnoService.GetTurnos());
        }
        [HttpPost]
        public IActionResult Post([FromBody] TTurno turno)
        {
            // FALTA VALIDAR ETC ETC ETC
            return Ok(_turnoService.Save(turno));
        }
        [HttpPut]
        public IActionResult Put([FromBody] TTurno turno)
        {
            // FALTA VALIDAR ETC ETC ETC
            return Ok(_turnoService.Update(turno));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // FALTA VALIDAR ETC ETC ETC
            return Ok(_turnoService.Delete(id));
        }
    }
}
