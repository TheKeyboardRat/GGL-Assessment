using Domain.Entities;
using MediatR;

namespace Application.Games.Commands
{
    public class DeleteGame : IRequest
    {
        public int Id { get; set; }
    }
}
