using Application.Abstractions.Repositories;
using Application.Games.Queries;
using Domain.Entities;
using MediatR;

namespace Application.Person.Queries.QueryHandlers
{
    public class GetGameByIdHandler : IRequestHandler<GetGameById, Game>
    {
        private readonly IGameRepository _gameRepository;

        public GetGameByIdHandler(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<Game> Handle(GetGameById request, CancellationToken cancellationToken)
        { 
            return await _gameRepository.GetGameById(request.Id);

        }
    }
}
