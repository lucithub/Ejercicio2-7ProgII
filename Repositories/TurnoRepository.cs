using TurnoWebApi.Models;

namespace TurnoWebApi.Repositories
{
    public class TurnoRepository : ITurnoRepository
    {
        private readonly turnos_dbContext _context;
        public TurnoRepository(turnos_dbContext context)
        {
            _context = context;
        }
        public bool Delete(int id)
        {
            var turno = _context.TTurnos.Find(id);
            if (turno != null)
            {
                _context.TTurnos.Remove(turno);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public List<TTurno> GetTurnos()
        {
            //var tlist = _context.TTurnos.Where(x => x.Hora == "08:20").ToList();
            var tlist = _context.TTurnos.ToList();
            return tlist;
        }

        public bool Save(TTurno turno)
        {
            _context.TTurnos.Add(turno);
            return _context.SaveChanges() > 0;
        }

        public bool Update(TTurno turno)
        {
            _context.TTurnos.Add(turno);
            return _context.SaveChanges() > 0;
        }
    }
}
