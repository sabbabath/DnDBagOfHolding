using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Api.Interfaces
{
    public interface iContainerTypeManager
    {
        Task<rDtoContainerType> GetContainerType(long id);
        
        Task<IEnumerable<rDtoContainerType>> GetContainerTypes();
        
        Task<rDtoContainerType> CreateContainerType(rDtoContainerType containerType);
        
        Task<rDtoContainerType> UpdateContainerType(rDtoContainerType containerType);
        
        Task DeleteContainerType(long id);
    }
}
