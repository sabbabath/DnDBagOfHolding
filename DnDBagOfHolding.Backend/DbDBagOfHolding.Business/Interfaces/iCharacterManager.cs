using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Interfaces
{
    public interface iCharacterManager
    {
        Task<cDtoCharacter> GetCharacter(long id);
        
        Task<IEnumerable<cDtoCharacter>> GetCharacters();
        
        Task<cDtoCharacter> CreateCharacter(cDtoCharacter character);
        
        Task<cDtoCharacter> UpdateCharacter(cDtoCharacter character);
        
        Task DeleteCharacter(long id);
    }
}
