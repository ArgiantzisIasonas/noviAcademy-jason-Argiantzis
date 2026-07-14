using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using WorldRank.Domain.Entity;
using WorldRank.Infrastructure.Persistencies.Context;

namespace WorldRank.Infrastructure
{
    public class EfPlayerRepository : IPlayerRepository
    {
        private readonly WorldRankDbContext _context;

        public EfPlayerRepository(WorldRankDbContext context) { _context = context;  }


        public async Task AddAsync(Player player,CancellationToken cancellationToken = default)
        {
            await _context.Players.AddAsync(player, cancellationToken);
            await  _context.SaveChangesAsync(cancellationToken);
        }
    }
}
