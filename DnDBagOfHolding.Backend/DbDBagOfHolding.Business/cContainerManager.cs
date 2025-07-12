using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBagOfHolding.Business
{
    public class cContainerManager(cDbContext dbContext)
    {
        private readonly cDbContext dbContext = dbContext;

        public Task<cDtoContainer> CreateContainer(cDtoContainer container)
        {

        }

        public Task<cDtoContainer> UpdateContainer(cDtoContainer container)
        {

        }

        public async Task DeleteContainer(long id)
        {
            var container = await dbContext.Containers.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Container does not exist.");
            dbContext.Containers.Remove(container);
            await dbContext.SaveChangesAsync();
        }
    }
}
