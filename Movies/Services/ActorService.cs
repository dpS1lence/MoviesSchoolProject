using Microsoft.EntityFrameworkCore;
using Movies.Data.Models;
using Movies.Data.Repositories.Contracts;
using Movies.Models;
using Movies.Services.Contracts;

namespace Movies.Services
{
    public class ActorService : IActorService
    {
        private readonly IRepository repo;

        public ActorService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<List<ActorModel>> GetAll()
        {
            var allActors = await repo.All<Actor>().ToListAsync();

            var model = new List<ActorModel>();
            foreach (var actor in allActors)
            {
                model.Add(new ActorModel()
                {
                    ActorId = actor.ActorId,
                    FullName = actor.FullName,
                    Bio = actor.Bio,
                    ProfilePictureUrl = actor.ProfilePictureUrl
                });
            }

            return model;
        }
    }
}
