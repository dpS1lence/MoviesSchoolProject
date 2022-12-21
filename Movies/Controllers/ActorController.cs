using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Data.Models;
using Movies.Data.Repositories.Contracts;
using Movies.Models;
using Movies.Services.Contracts;

namespace Movies.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService actorService;

        public ActorController(IActorService actorService)
        {
            this.actorService = actorService;
        }

        public async Task<IActionResult> Actor()
        {
            var model = await actorService.GetAll();

            return View(model);
        }
    }
}
