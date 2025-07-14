using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Business
{
    public class cContainerManager(cDbContext dbContext, IMapper mapper)
    {
        private readonly cDbContext dbContext = dbContext;

        private readonly IMapper _mapper = mapper;

        public async Task<cDtoContainer> CreateContainer(cDtoContainer container)
        {
            var dbContainer = _mapper.Map<cDbContainer>(container);
            await dbContext.Containers.AddAsync(dbContainer);
            await dbContext.SaveChangesAsync();

            return container;
        }

        public async Task<cDtoContainer> UpdateContainer(cDtoContainer container)
        {
            var dbContainer = await dbContext.Containers.FirstOrDefaultAsync(x => x.Id == container.Id)
                ?? throw new Exception("Container does not exist.");
            dbContainer.UpdateFromDto(container);
            await dbContext.SaveChangesAsync();

            return container;
        }

        public async Task DeleteContainer(long id)
        {
            var container = await dbContext.Containers.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Container does not exist.");
            dbContext.Containers.Remove(container);
            await dbContext.SaveChangesAsync();
        }
    }
}
