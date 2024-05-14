using Application.Abstractions.Repositories;
using Application.Games.Queries;
using Domain.Entities;
using MediatR;

namespace Application.Person.Queries.QueryHandlers
{
    public class GetAllGamesHandler : IRequestHandler<GetAllGames, List<Game>>
    {
        private readonly IGameRepository _gameRepository;

        public GetAllGamesHandler(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public Task<List<Game>> Handle(GetAllGames request, CancellationToken cancellationToken)
        {
            var result = _gameRepository.GetAllGames();
            return result;

        }
    }
}
