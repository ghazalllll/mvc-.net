using tamrin_ba_ghazale.Models;
using tamrin_ba_ghazale.Data;
using Microsoft.EntityFrameworkCore;

namespace tamrin_ba_ghazale.Repository.service
{
    public class ClubRepository : IClubInterface
    {
        private readonly Context _context;
        public ClubRepository(Context context)
        {
            _context = context;
        }

        public bool Add(Club club)
        {
           _context.Add(club);
           return Save();
        }

        public bool Delete(Club club)
        {
            _context.Remove(club);
            return Save();
        }

        public async Task<List<Club>> GetAll()
        {
           return await _context.Clubs.ToListAsync();
            
        }

        public async Task<IEnumerable<Club>> GetClubByCity(string city)
        {
           return await _context.Clubs.Where(c => c.Adress.City.Contains(city)).ToListAsync();
        }

        public async Task<Club> GetClubById(int id)
        {
            return await _context.Clubs.Include(a =>  a.Adress).FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var Saved = _context.SaveChanges();
            return Saved > 0 ? true:false ;
        }

        public bool Update(Club club)
        {
            _context.Update(club);
            return Save();
        }
    }
}
