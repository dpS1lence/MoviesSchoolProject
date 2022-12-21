using Movies.Models;

namespace Movies.Services.Contracts
{
    public interface IActorService
    {
        Task<List<ActorModel>> GetAll();
    }
}
