using Domain.Entities;
using MediatR;
using Application.Games.Commands;
using Application.Abstractions.Repositories;

namespace Application.Games.Commands.Handlers
{
    public class CreateGameHandler : IRequestHandler<CreateGame, Game>
    {
        private readonly IGameRepository _gameRepository;

        public CreateGameHandler(IGameRepository gameRepository) 
        {
            _gameRepository = gameRepository;
        }

        public async Task<Game> Handle(CreateGame request, CancellationToken cancellationToken) 
        {
            var game = new Game
            {
                 game_title = request.game_title,
                 genre = request.genre,
                 platform = request.platform,
                 release_date = request.release_date,
                 rating = request.rating,
                 price = request.price,
                 image_url = request.image_url,
                 description = request.description,
                 studio_name = request.studio_name
            };

            return await _gameRepository.AddGame(game);
        }
    }
}
