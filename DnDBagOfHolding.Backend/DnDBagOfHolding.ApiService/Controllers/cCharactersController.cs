using DnDBagOfHolding.Business.Api.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
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

        [HttpPost]
        public async Task<ActionResult> CreateCharacter([FromBody] cDtoCharacter dto)
        {
            var character = await mCharacterManager.CreateCharacter(dto);
            return Ok(character);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCharacter([FromBody] cDtoCharacter dto)
        {
            var character = await mCharacterManager.UpdateCharacter(dto);
            return Ok(character);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCharacter(long id)
        {
            await mCharacterManager.DeleteCharacter(id);
            return NoContent();
        }
    }
}
