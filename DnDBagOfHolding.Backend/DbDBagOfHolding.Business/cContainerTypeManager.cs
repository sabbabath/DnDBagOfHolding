using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBagOfHolding.Business
{
    public class cContainerTypeManager
    {
        private readonly cDbContext dbContext;

        public cContainerTypeManager(cDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<cDtoContainerType> CreateContainerType()
        {

        }

        public Task<cDtoContainerType> UpdateContainerType()
        {

        }

        public Task DeleteContainerType()
        {

        }

    }
}
