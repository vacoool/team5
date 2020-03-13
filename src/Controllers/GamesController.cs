using Microsoft.AspNetCore.Mvc;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers
{
    [Route("api/games")]
    public class GamesController : Controller
    {
        [HttpPost]
        public IActionResult Index([FromBody]int index)
        {
            return new ObjectResult(TestData.AGameDto(new Vec(1, 1), index));
        }
    }
}
