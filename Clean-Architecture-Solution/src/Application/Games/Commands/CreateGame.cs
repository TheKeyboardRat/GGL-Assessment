using MediatR;
using Domain.Entities;

namespace Application.Games.Commands
{
    public class CreateGame : IRequest<Game>
    {
        public string game_title { get; set; } = string.Empty;
        public string genre { get; set; } = string.Empty;
        public string platform {  get; set; } = string.Empty;
        public string release_date {  get; set; } = string.Empty;
        public double rating {  get; set; }
        public double price { get; set; }
        public string image_url { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string studio_name { get; set; } = string.Empty;

    }
}
