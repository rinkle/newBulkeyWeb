using BulkeyWebNewTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkeyWebNewTest.Controllers
{
    public class TeamController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TeamController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            TeamModel Modal = new TeamModel();
            List<Team> TeamList = new List<Team>();
            Modal.TeamList = _db.Team.ToList();
            return View(Modal);
        }
    }

   
}
