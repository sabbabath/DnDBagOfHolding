using DnDBagOfHolding.Business.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DnDBagOfHolding.Business.Managers
{
    public class cContainerTypeManager(cDbContext dbContext, IMapper mapper) : iContainerTypeManager
    {
        private readonly cDbContext dbContext = dbContext;

        private readonly IMapper _mapper = mapper;

        public async Task<rDtoContainerType> GetContainerType(long id)
        {
            var dbContainerType = await dbContext.ContainerTypes
                .FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Container does not exist.");
            return _mapper.Map<rDtoContainerType>(dbContainerType);
        }

        public async Task<IEnumerable<rDtoContainerType>> GetContainerTypes()
        {
            var dbContainerTypes = await dbContext.ContainerTypes.ToListAsync();
            return _mapper.Map<IEnumerable<rDtoContainerType>>(dbContainerTypes);
        }

        public async Task<rDtoContainerType> CreateContainerType(rDtoContainerType containerType)
        {
            var dbContainerType = _mapper.Map<cDbContainerType>(containerType);
            await dbContext.ContainerTypes.AddAsync(dbContainerType);
            await dbContext.SaveChangesAsync();

            return containerType;
        }

        public async Task<rDtoContainerType> UpdateContainerType(rDtoContainerType containerType)
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
