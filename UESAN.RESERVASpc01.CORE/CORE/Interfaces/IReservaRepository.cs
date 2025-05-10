using System.Collections.Generic;
using System.Threading.Tasks;
using UESAN.RESERVASpc01.CORE.CORE.Entities;

namespace UESAN.RESERVASpc01.CORE.CORE.Interfaces
{
    public interface IReservaRepository
    {
        Task<List<Reservas>> GetReservasAsync();
        Task<Reservas> GetReservaByIdAsync(int id);
        Task<Reservas> CreateReservaAsync(Reservas reserva);
        Task<Reservas> UpdateReservaAsync(Reservas reserva);
        Task<bool> DeleteReservaAsync(int id);
    }
}
