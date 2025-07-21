using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Api.Interfaces
{
    public interface iContainerManager
    {
        Task<cDtoContainer> GetContainer(long id);
        
        Task<IEnumerable<cDtoContainer>> GetContainers();
        
        Task<cDtoContainer> CreateContainer(cDtoContainer container);
        
        Task<cDtoContainer> UpdateContainer(cDtoContainer container);
        
        Task DeleteContainer(long id);
    }
}
