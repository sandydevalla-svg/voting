
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/votes")]
public class VotesController : ControllerBase
{
    [HttpPost]
    public IActionResult Vote(CastVoteCommand command)
    {
        return Ok();
    }
}
