using Domain.Entities;

namespace Application.Abstractions.Repositories
{
    public interface IGameRepository
    {
        Task<Game> GetGameById(int id);
        Task<Game> AddGame(Game game);
        Task DeleteGame(int id);
        Task UpdateGame(Game game);
        Task<List<Game>> GetAllGames();
    }
}
