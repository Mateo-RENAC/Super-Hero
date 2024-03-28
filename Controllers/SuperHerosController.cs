using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Data;
using SuperHero.Services.SuperHeroService;

namespace Super_Hero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHerosController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHerosController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }
        

        [HttpPost]
        public async Task<ActionResult<List<SuperHeros>>> AddSuperHeros(SuperHeros superheros)
        {
            var result = _superHeroService.AddSuperHeros(superheros);
            if (result == null)
            {
                return NotFound("You need a SuperHero");
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IList<SuperHeros>>> GetSuperHeroes()
        {
            var result = _superHeroService.GetSuperHeroes();
            if (result == null)
            {
                return NotFound("No SuperHero");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IList<SuperHeros>>> GetHeros(int id)
        {
            var result = _superHeroService.GetHeros(id);
            if (result == null)
            {
                return NotFound("No Hero at this Id : " + id);
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<IList<SuperHeros>>> UpdateSuperHeros(int id, SuperHeros request)
        {
            var result = _superHeroService.UpdateSuperHeros(id, request);
            if (result == null)
            {
                return NotFound("No super hero at this Id : " + id);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<IList<SuperHeros>>> DeleteSuperHeros(int id)
        {
            var result = _superHeroService.DeleteSuperHeros(id);
            if (result == null)
            {
                return BadRequest("No Hero in this Id : " + id);
            }
            return Ok(result);
        }
    }
}
