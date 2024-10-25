using Microsoft.AspNetCore.Mvc;
using tamrin_ba_ghazale.Data;

namespace tamrin_ba_ghazale.Controllers
{
    public class AppUserController : Controller
    {
        private readonly Context _context;
        public AppUserController(Context context)
        {
            _context = context;  
        }
        
        public IActionResult Index()
        {
            var AppUsers = _context.AppUsers.ToList();
            return View(AppUsers);
        }
    }
}
