using WorldRank.Application.Interfaces;
using WorldRank.Domain.Entity;
using WorldRank.Infrastructure.Persistencies.Context;

namespace WorldRank.Infrastructure.Persistencies.Command.Players
{
    public class CreatePlayerPersistence : ICreatePlayerPersistence
    {
        private readonly WorldRankDbContext _db;

        public CreatePlayerPersistence(WorldRankDbContext db)
        {
            _db = db;
        }

        public async Task Persist(Player player)
        {
            _db.Add(player);
            await _db.SaveChangesAsync();
        }
    }
}
