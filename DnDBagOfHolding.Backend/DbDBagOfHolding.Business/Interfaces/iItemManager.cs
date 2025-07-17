using DnDBagOfHolding.Common.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DnDBagOfHolding.Business.Interfaces
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
