using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBagOfHolding.Business
{
    public class cItemManager
    {
        private readonly cDbContext dbContext;

        public cItemManager(cDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<cDtoItem> CreateItem()
        {

        }

        public Task<cDtoItem> UpdateItem()
        {

        }

        public Task DeleteItem()
        {

        }
    }
}
