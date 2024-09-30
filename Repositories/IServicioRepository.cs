using TurnoWebApi.Models;

namespace TurnoWebApi.Repositories
{
    public interface IServicioRepository
    {
        List<TServicio> GetServicios();
        bool Save(TServicio servicio);
        bool Delete(int id);
    }
}
