using TurnoWebApi.Models;
using TurnoWebApi.Repositories;

namespace TurnoWebApi.Services
{
    public class ServicioService : IServicioService
    {
        private readonly IServicioRepository _servicioRepository;
        public ServicioService(IServicioRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }
        public bool Delete(int id)
        {
            return _servicioRepository.Delete(id);
        }

        public List<TServicio> GetServicios()
        {
            return _servicioRepository.GetServicios();
        }

        public bool Save(TServicio servicio)
        {
            return _servicioRepository.Save(servicio);
        }
    }
}
