using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Business
{
    public class cContainerTypeManager(cDbContext dbContext, IMapper mapper)
    {
        private readonly cDbContext dbContext = dbContext;

        private readonly IMapper _mapper = mapper;

        public async Task<cDtoContainerType> CreateContainerType(cDtoContainerType containerType)
        {
            var dbContainerType = _mapper.Map<cDbContainerType>(containerType);
            await dbContext.ContainerTypes.AddAsync(dbContainerType);
            await dbContext.SaveChangesAsync();

            return containerType;
        }

        public async Task<cDtoContainerType> UpdateContainerType(cDtoContainerType containerType)
        {
            var dbContainerType = await dbContext.ContainerTypes.FirstOrDefaultAsync(x => x.Id == containerType.Id)
                ?? throw new Exception("Container does not exist.");
            dbContainerType.UpdateFromDto(containerType);
            await dbContext.SaveChangesAsync();

            return containerType;
        }

        public async Task DeleteContainerType(long id)
        {
            var dbContainerType = await dbContext.ContainerTypes.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Container does not exist.");
            dbContext.ContainerTypes.Remove(dbContainerType);
            await dbContext.SaveChangesAsync();
        }

    }
}
