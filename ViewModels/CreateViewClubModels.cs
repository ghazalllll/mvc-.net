
using tamrin_ba_ghazale.Data.Enum;
using tamrin_ba_ghazale.Models;

namespace tamrin_ba_ghazale.ViewModels
{
    public class CreateClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Adress Adress { get; set; }
        public IFormFile Image { get; set; }
        public CategoryClub CategoryClub { get; set; }
        public string AppUserId { get; set; }
    }
}
