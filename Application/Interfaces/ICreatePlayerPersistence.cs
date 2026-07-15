using WorldRank.Domain.Entity;

namespace WorldRank.Application.Interfaces
{
    public interface ICreatePlayerPersistence
    {
        Task Persist(Player player);
    }
}
