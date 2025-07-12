using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBagOfHolding.Business
{
    public class cCharacterManager
    {
        private readonly cDbContext dbContext;

        public cCharacterManager(cDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<cDtoCharacter> CreateCharacter()
        {

        }

        public Task<cDtoCharacter> UpdateCharacter()
        {

        }

        public Task DeleteCharacter()
        {

        }
    }
}
