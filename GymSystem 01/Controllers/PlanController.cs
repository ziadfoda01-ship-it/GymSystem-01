using GymSystem.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystem_01.Controllers
{
    
    public class PlanController : Controller
    {
        private GymDbcontext context = new();
        public IActionResult Index()
        {
            return View();
        }
        public  async Task <IActionResult> IndexTest ()
        {
            var plan = await context.Plans.ToListAsync();
            return View(plan); 
        }
    }
}
