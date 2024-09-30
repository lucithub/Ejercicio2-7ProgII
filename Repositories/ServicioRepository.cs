using TurnoWebApi.Models;

namespace TurnoWebApi.Repositories
{
    public class ServicioRepository : IServicioRepository
    {
        private readonly turnos_dbContext _context;
        public ServicioRepository(turnos_dbContext context)
        {
            _context = context;
        }
        public bool Delete(int id)
        {
            TServicio servicio = _context.TServicios.Find(id);
            if (servicio != null)
            {
                _context.TServicios.Remove(servicio);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public List<TServicio> GetServicios()
        {
            List<TServicio> lstServicios = _context.TServicios.ToList();
            return lstServicios;
        }

        public bool Save(TServicio servicio)
        {
            _context.TServicios.Add(servicio);
            _context.SaveChanges();
            return true;
        }
    }
}
