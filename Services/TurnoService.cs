using TurnoWebApi.Models;
using TurnoWebApi.Repositories;

namespace TurnoWebApi.Services
{
    public class TurnoService : ITurnoService
    {
        private readonly ITurnoRepository _turnoRepository;

        public TurnoService(ITurnoRepository turnoRepository)
        {
            _turnoRepository = turnoRepository;
        }

        public List<TTurno> GetTurnos()
        {
            return _turnoRepository.GetTurnos();
        }

        public bool Save(TTurno turno)
        {
            return _turnoRepository.Save(turno);
        }

        public bool Update(TTurno turno)
        {
            return _turnoRepository.Update(turno);
        }

        public bool Delete(int id)
        {
            return _turnoRepository.Delete(id);
        }
    }
}
