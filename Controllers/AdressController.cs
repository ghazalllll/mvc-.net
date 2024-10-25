using Microsoft.AspNetCore.Mvc;
using tamrin_ba_ghazale.Data;

namespace tamrin_ba_ghazale.Controllers
{
    public class AdressController : Controller
    {
        private readonly Context _context;
        public AdressController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Adresses = _context.Adresses.ToList(); 
            return View(Adresses);
        }
    }
}
