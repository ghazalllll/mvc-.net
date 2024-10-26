using Microsoft.AspNetCore.Mvc;
using tamrin_ba_ghazale.Data;
using tamrin_ba_ghazale.Models;
using Microsoft.EntityFrameworkCore;
using tamrin_ba_ghazale.Repository;
using tamrin_ba_ghazale.Repository.service;

namespace tamrin_ba_ghazale.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubInterface _clubRepository;
        public ClubController(IClubInterface clubRepository)
        {
            _clubRepository = clubRepository;
        }
        public async Task<IActionResult> Index()
        {
            List < Club > Clubs = await _clubRepository.GetAll();
            return View(Clubs);
        }
       public async Task<IActionResult> Detail(int id)
        {
            Club club =  await _clubRepository.GetClubById(id) ;
            return View(club);
        }
        public IActionResult Create()
        {
            return View();
        }



    }
}
