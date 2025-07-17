using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Interfaces
{
    public interface iContainerTypeManager
    {
        Task<cDtoContainerType> GetContainerType(long id);
        
        Task<IEnumerable<cDtoContainerType>> GetContainerTypes();
        
        Task<cDtoContainerType> CreateContainerType(cDtoContainerType containerType);
        
        Task<cDtoContainerType> UpdateContainerType(cDtoContainerType containerType);
        
        Task DeleteContainerType(long id);
    }
}
