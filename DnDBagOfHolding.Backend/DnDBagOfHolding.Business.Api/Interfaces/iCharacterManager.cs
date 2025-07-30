using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Api.Interfaces
{
    public interface iCharacterManager
    {
        Task<rDtoCharacter> GetCharacter(long id);
        
        Task<IEnumerable<rDtoCharacter>> GetCharacters();
        
        Task<rDtoCharacter> CreateCharacter(rDtoCharacter character);
        
        Task<rDtoCharacter> UpdateCharacter(rDtoCharacter character);
        
        Task DeleteCharacter(long id);
    }
}
