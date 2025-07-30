using DnDBagOfHolding.Business.Api.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Business.Managers
{
    public class cItemManager(cDbContext dbContext, IMapper mapper) : iItemManager
    {
        private readonly cDbContext dbContext = dbContext;

        private readonly IMapper _mapper = mapper;

        public async Task<rDtoItem> GetItem(long id)
        {
            var dbItem = await dbContext.Items.FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new Exception("Container does not exist.");
            return _mapper.Map<rDtoItem>(dbItem);
        }

        public async Task<IEnumerable<rDtoItem>> GetItems()
        {
            var dbItems = await dbContext.Items.ToListAsync();
            return _mapper.Map<IEnumerable<rDtoItem>>(dbItems);
        }

        public async Task<rDtoItem> CreateItem(rDtoItem item)
        {
            var dbItem = _mapper.Map<cDbItem>(item);
            await dbContext.Items.AddAsync(dbItem);
            await dbContext.SaveChangesAsync();

            return item;
        }

        public async Task<rDtoItem> UpdateItem(rDtoItem item)
        {
            var dbItem = await dbContext.Items.FirstOrDefaultAsync(x => x.Id == item.Id)
                ?? throw new Exception("Container does not exist.");
            dbItem.UpdateFromDto(item);
            await dbContext.SaveChangesAsync();

            return item;
        }

        public async Task DeleteItem(long id)
        {
            var dbItem = await dbContext.Items.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Container does not exist.");
            dbContext.Items.Remove(dbItem);
            await dbContext.SaveChangesAsync();
        }
    }
}
