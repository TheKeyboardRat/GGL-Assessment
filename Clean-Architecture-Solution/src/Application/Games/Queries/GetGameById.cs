using Domain.Entities;
using MediatR;

namespace Application.Games.Queries
{
    public class GetGameById : IRequest<Game>
    {
        public int Id { get; set; }
    }
}
