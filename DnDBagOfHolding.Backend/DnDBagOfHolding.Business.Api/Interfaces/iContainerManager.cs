using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Api.Interfaces
{
    public interface iContainerManager
    {
        Task<rDtoContainer> GetContainer(long id);
        
        Task<IEnumerable<rDtoContainer>> GetContainers();
        
        Task<rDtoContainer> CreateContainer(rDtoContainer container);
        
        Task<rDtoContainer> UpdateContainer(rDtoContainer container);
        
        Task DeleteContainer(long id);
    }
}
