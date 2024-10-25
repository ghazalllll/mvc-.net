using tamrin_ba_ghazale.Models;

namespace tamrin_ba_ghazale.Repository
{
    public interface IClubInterface
    {
        Task<List<Club>> GetAll();
        Task<IEnumerable<Club>> GetClubByCity(string city);
        Task<Club> GetClubById(int id);
        bool Add (Club club);
        bool Delete(Club club);
        bool Update (Club club);
        bool Save();



    }
}
