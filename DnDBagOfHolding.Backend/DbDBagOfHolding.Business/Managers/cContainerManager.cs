using DnDBagOfHolding.Business.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Business.Managers
{
    public class cContainerManager(cDbContext dbContext, IMapper mapper) : iContainerManager
    {
        private readonly cDbContext dbContext = dbContext;

        private readonly IMapper _mapper = mapper;
        
        public async Task<cDtoContainer> GetContainer(long id)
        {
            var dbContainer = await dbContext.Containers
                .Include(x => x.ContainerType)
                .FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Container does not exist.");
            return _mapper.Map<cDtoContainer>(dbContainer);
        }

        public async Task<IEnumerable<cDtoContainer>> GetContainers()
        {
            var dbContainers = await dbContext.Containers
                .Include(x => x.ContainerType)
                .ToListAsync();
            return _mapper.Map<IEnumerable<cDtoContainer>>(dbContainers);
        }

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
