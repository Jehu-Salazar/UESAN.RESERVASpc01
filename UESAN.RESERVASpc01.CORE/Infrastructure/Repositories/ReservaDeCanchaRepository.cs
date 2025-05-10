using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UESAN.RESERVASpc01.CORE.CORE.Entities;
using UESAN.RESERVASpc01.CORE.Infrastructure.Data;

namespace UESAN.RESERVASpc01.CORE.Infrastructure.Repositories
{
    public class ReservaDeCanchaRepository
    {
        private readonly ReservaDeCanchaContext _context;
        public ReservaDeCanchaRepository(ReservaDeCanchaContext context)
        {
            _context = context;
        }

        //get all canchas
        public List<Canchas> GetCanchas()
        {
            return _context.Canchas.ToList();
        }

        //Get canchas by id async
        public async Task<Canchas> GetCanchaByIdAsync(int id)
        {
            return await _context.Canchas.FindAsync(id);
        }

        // Create canchaas async
        public async Task<Canchas> CreateCanchaAsync(Canchas cancha)
        {
            _context.Canchas.Add(cancha);
            await _context.SaveChangesAsync();
            return cancha;
        }

        //Delete canchas async
        public async Task<bool> DeleteCanchaAsync(int id)
        {
            var cancha = await _context.Canchas.FindAsync(id);
            if (cancha == null)
            {
                return false;
            }
            _context.Canchas.Remove(cancha);
            await _context.SaveChangesAsync();
            return true;
        }

        //Update canchas async
        public async Task<Canchas> UpdateCanchaAsync(Canchas cancha)
        {
            _context.Canchas.Update(cancha);
            await _context.SaveChangesAsync();
            return cancha;
        }




    }
}
