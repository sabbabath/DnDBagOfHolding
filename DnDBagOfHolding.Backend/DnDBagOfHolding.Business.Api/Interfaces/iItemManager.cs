using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Api.Interfaces
{
    public interface iItemManager
    {
        Task<cDtoItem> GetItem(long id);
        
        Task<IEnumerable<cDtoItem>> GetItems();
        
        Task<cDtoItem> CreateItem(cDtoItem item);
        
        Task<cDtoItem> UpdateItem(cDtoItem item);
        
        Task DeleteItem(long id);
    }
}
