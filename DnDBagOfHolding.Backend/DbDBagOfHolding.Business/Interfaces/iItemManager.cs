using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Business.Interfaces
{
    public interface iItemManager
    {
        Task<rDtoItem> GetItem(long id);
        Task<IEnumerable<rDtoItem>> GetItems();
        Task<rDtoItem> CreateItem(rDtoItem item);
        Task<rDtoItem> UpdateItem(rDtoItem item);
        Task DeleteItem(long id);
    }
}