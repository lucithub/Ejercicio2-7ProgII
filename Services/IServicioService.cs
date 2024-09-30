using TurnoWebApi.Models;

namespace TurnoWebApi.Services
{
    public interface IServicioService
    {
        List<TServicio> GetServicios();
        bool Save(TServicio servicio);
        bool Delete(int id);
    }
}
