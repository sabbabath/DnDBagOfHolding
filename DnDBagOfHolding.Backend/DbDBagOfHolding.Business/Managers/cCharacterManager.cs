using DnDBagOfHolding.Business.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Business.Managers
{
    public class cCharacterManager(cDbContext dbContext, IMapper mapper) : iCharacterManager
    {
        private readonly cDbContext dbContext = dbContext;

        private readonly IMapper _mapper = mapper;

        public async Task<rDtoCharacter> GetCharacter(long id)
        {
            var dbCharacter = await dbContext.Characters
                .FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Character does not exist.");
            return _mapper.Map<rDtoCharacter>(dbCharacter);
        }

        public async Task<IEnumerable<rDtoCharacter>> GetCharacters()
        {
            var dbCharacters = await dbContext.Characters.ToListAsync();
            return _mapper.Map<IEnumerable<rDtoCharacter>>(dbCharacters);
        }

        public async Task<rDtoCharacter> CreateCharacter(rDtoCharacter character)
        {
            var dbCharacter = _mapper.Map<cDbCharacter>(character);
            await dbContext.Characters.AddAsync(dbCharacter);
            await dbContext.SaveChangesAsync();

            return character;
        }

        public async Task<rDtoCharacter> UpdateCharacter(rDtoCharacter character)
        {
            var dbCharacter = await dbContext.Characters.FirstOrDefaultAsync(x => x.Id == character.Id)
                ?? throw new Exception("Character does not exist.");
            dbCharacter.UpdateFromDto(character);
            await dbContext.SaveChangesAsync();

            return character;
        }

        public async Task DeleteCharacter(long id)
        {
            var character = await dbContext.Characters.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Character does not exist.");
            dbContext.Characters.Remove(character);
            await dbContext.SaveChangesAsync();
        }
    }
}
