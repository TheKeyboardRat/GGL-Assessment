using Application.Abstractions.Repositories;
using Domain.Entities;
using MediatR;


namespace Application.Games.Commands.Handlers
{
    public class DeleteGameHandler : IRequestHandler<DeleteGame>
    {
        private readonly IGameRepository _gameRepository;

        public DeleteGameHandler(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task Handle(DeleteGame request, CancellationToken cancellationToken)
        {

           await _gameRepository.DeleteGame(request.Id);
        }
    }
}
