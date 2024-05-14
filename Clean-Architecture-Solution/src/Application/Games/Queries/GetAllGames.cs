using Domain.Entities;
using MediatR;


namespace Application.Games.Queries
{
    public class GetAllGames : IRequest<List<Game>>
    {
    }
}
