using DnDBagOfHolding.Business.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class cCharactersController(iCharacterManager characterManager, ILogger<cCharactersController> cLogger) : ControllerBase
    {
        private readonly iCharacterManager mCharacterManager = characterManager;

        private readonly ILogger<cCharactersController> cLogger = cLogger;

        [HttpGet()]
        public async Task<ActionResult> GetAll()
        {
            var characters = await mCharacterManager.GetCharacters();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(long id)
        {
            var character = await mCharacterManager.GetCharacter(id);
            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }
    }
}
