using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Games.Queries;
using Microsoft.AspNetCore.Authorization;
using Application.Games.Commands;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class GamesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GamesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetGame/{id}")]
        public async Task<IActionResult> GetGameById(int id)
        {
            var result = await _mediator.Send(new GetGameById { Id = id });
            if(result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> GetAllGames()
        {
            var result = await _mediator.Send(new GetAllGames { });
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        [Route("DeleteGame/{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            await _mediator.Send(new DeleteGame { Id = id });
            return Ok();
        }
    }
}
