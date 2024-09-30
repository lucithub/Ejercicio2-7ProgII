using TurnoWebApi.Models;

namespace TurnoWebApi.Repositories
{
    public interface ITurnoRepository
    {
        List<TTurno> GetTurnos();
        bool Save(TTurno turno);
        bool Update(TTurno turno);
        bool Delete(int id);

    }
}
