using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Business
{
    public class cCharacterManager(cDbContext dbContext, IMapper mapper)
    {
        private readonly cDbContext dbContext = dbContext;

        private readonly IMapper _mapper = mapper;

        public async Task<cDtoCharacter> CreateCharacter(cDtoCharacter character)
        {
            var dbCharacter = _mapper.Map<cDbCharacter>(character);
            await dbContext.Characters.AddAsync(dbCharacter);
            await dbContext.SaveChangesAsync();

            return character;
        }

        public async Task<cDtoCharacter> UpdateCharacter(cDtoCharacter character)
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
