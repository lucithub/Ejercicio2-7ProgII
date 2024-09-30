using TurnoWebApi.Models;

namespace TurnoWebApi.Services
{
    public interface ITurnoService
    {
        List<TTurno> GetTurnos();
        bool Save(TTurno turno);
        bool Update(TTurno turno);
        bool Delete(int id);
    }
}
