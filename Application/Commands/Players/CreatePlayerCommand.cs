using MediatR;

namespace WorldRank.Application.Commands.Players
{
    public record CreatePlayerCommand(string name, int score) : IRequest<int>;
}
