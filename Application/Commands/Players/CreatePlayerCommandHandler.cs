using MediatR;

using WorldRank.Application.Interfaces;
using WorldRank.Domain.Entity;

namespace WorldRank.Application.Commands.Players
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand,int>
    {
        private readonly ICreatePlayerPersistence _createPlayerPersistence;

        public CreatePlayerCommandHandler(ICreatePlayerPersistence createPlayerPersistence)
        {
            _createPlayerPersistence = createPlayerPersistence;
        }

        public async Task<int> Handle(CreatePlayerCommand request,CancellationToken cancellationToken)
        { 
            var player = Player.CreateNew(request.name);

            await _createPlayerPersistence.Persist(player);
            return player.Id;
        }
    }
}
