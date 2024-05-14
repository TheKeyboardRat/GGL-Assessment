using Domain.Entities;
using Application.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly GameDbContext _context;

        public GameRepository(GameDbContext context)
        {
            _context = context;
        }

        public async Task<Game> AddGame(Game game)
        {
            _context.Games.Add(game);

            await _context.SaveChangesAsync();

            return game;
        }

        public async Task DeleteGame(int id)
        {
            var game = _context.Games.FirstOrDefault(x => x.id == id);

            if (game == null) return;

            _context.Games.Remove(game);

            await _context.SaveChangesAsync();
        }

        public async Task<Game> GetGameById(int id)
        {
            var game = await _context.Games.FirstOrDefaultAsync(x => x.id == id);

            return game;
        }

        public Task<List<Game>> GetAllGames()
        {
            var games = _context.Games.ToList();

            return Task.FromResult(games);
        }

        public async Task UpdateGame(Game update)
        {
            var game = await _context.Games.FirstAsync(p => p.id == update.id);

            game.game_title = update.game_title;
            game.genre = update.genre;
            game.platform = update.platform;
            game.release_date = update.release_date;
            game.rating = update.rating;
            game.price = update.price;
            game.image_url = update.image_url;
            game.description = update.description;
            game.studio_name = update.studio_name;

            await _context.SaveChangesAsync();
        }
    }
}
